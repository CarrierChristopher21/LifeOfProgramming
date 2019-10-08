/** 
2  * A Javascript implementation of a Sudoku game, including a 
3  * backtracking algorithm solver. For example usage see the 
4  * attached index.html demo. 
5  * 
6  * @author Moriel Schottlender 
7  */ 
8 var Sudoku = ( function ( $ ){ 
9 	var _instance, _game, 
10 		/** 
11 		 * Default configuration options. These can be overriden 
12 		 * when loading a game instance. 
13 		 * @property {Object} 
14 		 */ 
15 		defaultConfig = { 
16 			// If set to true, the game will validate the numbers 
17 			// as the player inserts them. If it is set to false, 
18 			// validation will only happen at the end. 
19 			'validate_on_insert': true, 
20 			// If set to true, the system will display the elapsed 
21 			// time it took for the solver to finish its operation. 
22 			'show_solver_timer': true, 
23 			// If set to true, the recursive solver will count the 
24 			// number of recursions and backtracks it performed and 
25 			// display them in the console. 
26 			'show_recursion_counter': true, 
27 			// If set to true, the solver will test a shuffled array 
28 			// of possible numbers in each empty input box. 
29 			// Otherwise, the possible numbers are ordered, which 
30 			// means the solver will likely give the same result 
31 			// when operating in the same game conditions. 
32 			'solver_shuffle_numbers': true 
33 		}, 
34 		paused = false, 
35 		counter = 0; 
36 
 
37 	/** 
38 	 * Initialize the singleton 
39 	 * @param {Object} config Configuration options 
40 	 * @returns {Object} Singleton methods 
41 	 */ 
42 	function init( config ) { 
43 		conf = $.extend( {}, defaultConfig, config ); 
44 		_game = new Game( conf ); 
45 
 
46 		/** Public methods **/ 
47 		return { 
48 			/** 
49 			 * Return a visual representation of the board 
50 			 * @returns {jQuery} Game table 
51 			 */ 
52 			getGameBoard: function() { 
53 				return _game.buildGUI(); 
54 			}, 
55 
 
56 			/** 
57 			 * Reset the game board. 
58 			 */ 
59 			reset: function() { 
60 				_game.resetGame(); 
61 			}, 
62 
 
63 			/** 
64 			 * Call for a validation of the game board. 
65 			 * @returns {Boolean} Whether the board is valid 
66 			 */ 
67 			validate: function() { 
68 				var isValid; 
69 
 
70 				isValid = _game.validateMatrix(); 
71 				$( '.sudoku-container' ).toggleClass( 'valid-matrix', isValid ); 
72 			}, 
73 
 
74 			/** 
75 			 * Call for the solver routine to solve the current 
76 			 * board. 
77 			 */ 
78 			solve: function() { 
79 				var isValid, starttime, endtime, elapsed; 
80 				// Make sure the board is valid first 
81 				if ( !_game.validateMatrix() ) { 
82 					return false; 
83 				} 
84 				// Reset counters 
85 				_game.recursionCounter = 0; 
86 				_game.backtrackCounter = 0; 
87 
 
88 				// Check start time 
89 				starttime = Date.now(); 
90 
 
91 				// Solve the game 
92 				isValid = _game.solveGame( 0, 0 ); 
93 
 
94 				// Get solving end time 
95 				endtime = Date.now(); 
96 
 
97 				// Visual indication of whether the game was solved 
98 				$( '.sudoku-container' ).toggleClass( 'valid-matrix', isValid ); 
99 				if ( isValid ) { 
100 					$( '.valid-matrix input' ).attr( 'disabled', 'disabled' ); 
101 				} 
102 
 
103 				// Display elapsed time 
104 				if ( _game.config.show_solver_timer ) { 
105 					elapsed = endtime - starttime; 
106 					window.console.log( 'Solver elapsed time: ' + elapsed + 'ms' ); 
107 				} 
108 				// Display number of reursions and backtracks 
109 				if ( _game.config.show_recursion_counter ) { 
110 					window.console.log( 'Solver recursions: ' + _game.recursionCounter ); 
111 					window.console.log( 'Solver backtracks: ' + _game.backtrackCounter ); 
112 				} 
113 			} 
114 		}; 
115 	} 
116 
 
117 	/** 
118 	 * Sudoku singleton engine 
119 	 * @param {Object} config Configuration options 
120 	 */ 
121 	function Game( config ) { 
122 		this.config = config; 
123 
 
124 		// Initialize game parameters 
125 		this.recursionCounter = 0; 
126 		this.$cellMatrix = {}; 
127 		this.matrix = {}; 
128 		this.validation = {}; 
129 
 
130 		this.resetValidationMatrices(); 
131 		return this; 
132 	} 
133 	/** 
134 	 * Game engine prototype methods 
135 	 * @property {Object} 
136 	 */ 
137 	Game.prototype = { 
138 		/** 
139 		 * Build the game GUI 
140 		 * @returns {jQuery} Table containing 9x9 input matrix 
141 		 */ 
142 		buildGUI: function() { 
143 			var $td, $tr, 
144 				$table = $( '<table>' ) 
145 					.addClass( 'sudoku-container' ); 
146 
 
147 			for ( var i = 0; i < 9; i++ ) { 
148 				$tr = $( '<tr>' ); 
149 				this.$cellMatrix[i] = {}; 
150 
 
151 				for ( var j = 0; j < 9; j++ ) { 
152 					// Build the input 
153 					this.$cellMatrix[i][j] = $( '<input>' ) 
154 						.attr( 'maxlength', 1 ) 
155 						.data( 'row', i ) 
156 						.data( 'col', j ) 
157 						.on( 'keyup', $.proxy( this.onKeyUp, this ) ); 
158 
 
159 					$td = $( '<td>' ).append( this.$cellMatrix[i][j] ); 
160 					// Calculate section ID 
161 					sectIDi = Math.floor( i / 3 ); 
162 					sectIDj = Math.floor( j / 3 ); 
163 					// Set the design for different sections 
164 					if ( ( sectIDi + sectIDj ) % 2 === 0 ) { 
165 						$td.addClass( 'sudoku-section-one' ); 
166 					} else { 
167 						$td.addClass( 'sudoku-section-two' ); 
168 					} 
169 					// Build the row 
170 					$tr.append( $td ); 
171 				} 
172 				// Append to table 
173 				$table.append( $tr ); 
174 			} 
175 			// Return the GUI table 
176 			return $table; 
177 		}, 
178 
 
179 		/** 
180 		 * Handle keyup events. 
181 		 * 
182 		 * @param {jQuery.event} e Keyup event 
183 		 */ 
184 		onKeyUp: function( e ) { 
185 			var sectRow, sectCol, secIndex, 
186 				starttime, endtime, elapsed, 
187 				isValid = true, 
188 				val = $.trim( $( e.currentTarget ).val() ), 
189 				row = $( e.currentTarget ).data( 'row' ), 
190 				col = $( e.currentTarget ).data( 'col' ); 
191 
 
192 			// Reset board validation class 
193 			$( '.sudoku-container' ).removeClass( 'valid-matrix' ); 
194 
 
195 			// Validate, but only if validate_on_insert is set to true 
196 			if ( this.config.validate_on_insert ) { 
197 				isValid = this.validateNumber( val, row, col, this.matrix.row[row][col] ); 
198 				// Indicate error 
199 				$( e.currentTarget ).toggleClass( 'sudoku-input-error', !isValid ); 
200 			} 
201 
 
202 			// Calculate section identifiers 
203 			sectRow = Math.floor( row / 3 ); 
204 			sectCol = Math.floor( col / 3 ); 
205 			secIndex = ( row % 3 ) * 3 + ( col % 3 ); 
206 
 
207 			// Cache value in matrix 
208 			this.matrix.row[row][col] = val; 
209 			this.matrix.col[col][row] = val; 
210 			this.matrix.sect[sectRow][sectCol][secIndex] = val; 
211 		}, 
212 
 
213 		/** 
214 		 * Reset the board and the game parameters 
215 		 */ 
216 		resetGame: function() { 
217 			this.resetValidationMatrices(); 
218 			for ( var row = 0; row < 9; row++ ) { 
219 				for ( var col = 0; col < 9; col++ ) { 
220 					// Reset GUI inputs 
221 					this.$cellMatrix[row][col].val( '' ); 
222 				} 
223 			} 
224 
 
225 			$( '.sudoku-container input' ).removeAttr( 'disabled' ); 
226 			$( '.sudoku-container' ).removeClass( 'valid-matrix' ); 
227 		}, 
228 
 
229 		/** 
230 		 * Reset and rebuild the validation matrices 
231 		 */ 
232 		resetValidationMatrices: function() { 
233 			this.matrix = { 'row': {}, 'col': {}, 'sect': {} }; 
234 			this.validation = { 'row': {}, 'col': {}, 'sect': {} }; 
235 
 
236 			// Build the row/col matrix and validation arrays 
237 			for ( var i = 0; i < 9; i++ ) { 
238 				this.matrix.row[i] = [ '', '', '', '', '', '', '', '', '' ]; 
239 				this.matrix.col[i] = [ '', '', '', '', '', '', '', '', '' ]; 
240 				this.validation.row[i] = []; 
241 				this.validation.col[i] = []; 
242 			} 
243 
 
244 			// Build the section matrix and validation arrays 
245 			for ( var row = 0; row < 3; row++ ) { 
246 				this.matrix.sect[row] = []; 
247 				this.validation.sect[row] = {}; 
248 				for ( var col = 0; col < 3; col++ ) { 
249 					this.matrix.sect[row][col] = [ '', '', '', '', '', '', '', '', '' ]; 
250 					this.validation.sect[row][col] = []; 
251 				} 
252 			} 
253 		}, 
254 
 
255 		/** 
256 		 * Validate the current number that was inserted. 
257 		 * 
258 		 * @param {String} num The value that is inserted 
259 		 * @param {Number} rowID The row the number belongs to 
260 		 * @param {Number} colID The column the number belongs to 
261 		 * @param {String} oldNum The previous value 
262 		 * @returns {Boolean} Valid or invalid input 
263 		 */ 
264 		validateNumber: function( num, rowID, colID, oldNum ) { 
265 			var isValid = true, 
266 				// Section 
267 				sectRow = Math.floor( rowID / 3 ), 
268 				sectCol = Math.floor( colID / 3 ); 
269 
 
270 			// This is given as the matrix component (old value in 
271 			// case of change to the input) in the case of on-insert 
272 			// validation. However, in the solver, validating the 
273 			// old number is unnecessary. 
274 			oldNum = oldNum || ''; 
275 
 
276 			// Remove oldNum from the validation matrices, 
277 			// if it exists in them. 
278 			if ( this.validation.row[rowID].indexOf( oldNum ) > -1 ) { 
279 				this.validation.row[rowID].splice( 
280 					this.validation.row[rowID].indexOf( oldNum ), 1 
281 				); 
282 			} 
283 			if ( this.validation.col[colID].indexOf( oldNum ) > -1 ) { 
284 				this.validation.col[colID].splice( 
285 					this.validation.col[colID].indexOf( oldNum ), 1 
286 				); 
287 			} 
288 			if ( this.validation.sect[sectRow][sectCol].indexOf( oldNum ) > -1 ) { 
289 				this.validation.sect[sectRow][sectCol].splice( 
290 					this.validation.sect[sectRow][sectCol].indexOf( oldNum ), 1 
291 				); 
292 			} 
293 			// Skip if empty value 
294 
 
295 			if ( num !== '' ) { 
296 
 
297 
 
298 				// Validate value 
299 				if ( 
300 					// Make sure value is numeric 
301 					$.isNumeric( num ) && 
302 					// Make sure value is within range 
303 					Number( num ) > 0 && 
304 					Number( num ) <= 9 
305 				) { 
306 					// Check if it already exists in validation array 
307 					if ( 
308 						$.inArray( num, this.validation.row[rowID] ) > -1 || 
309 						$.inArray( num, this.validation.col[colID] ) > -1 || 
310 						$.inArray( num, this.validation.sect[sectRow][sectCol] ) > -1 
311 					) { 
312 						isValid = false; 
313 					} else { 
314 						isValid = true; 
315 					} 
316 				} 
317 
 
318 				// Insert new value into validation array even if it isn't 
319 				// valid. This is on purpose: If there are two numbers in the 
320 				// same row/col/section and one is replaced, the other still 
321 				// exists and should be reflected in the validation. 
322 				// The validation will keep records of duplicates so it can 
323 				// remove them safely when validating later changes. 
324 				this.validation.row[rowID].push( num ); 
325 				this.validation.col[colID].push( num ); 
326 				this.validation.sect[sectRow][sectCol].push( num ); 
327 			} 
328 
 
329 			return isValid; 
330 		}, 
331 
 
332 		/** 
333 		 * Validate the entire matrix 
334 		 * @returns {Boolean} Valid or invalid matrix 
335 		 */ 
336 		validateMatrix: function() { 
337 			var isValid, val, $element, 
338 				hasError = false; 
339 
 
340 			// Go over entire board, and compare to the cached 
341 			// validation arrays 
342 			for ( var row = 0; row < 9; row++ ) { 
343 				for ( var col = 0; col < 9; col++ ) { 
344 					val = this.matrix.row[row][col]; 
345 					// Validate the value 
346 					isValid = this.validateNumber( val, row, col, val ); 
347 					this.$cellMatrix[row][col].toggleClass( 'sudoku-input-error', !isValid ); 
348 					if ( !isValid ) { 
349 						hasError = true; 
350 					} 
351 				} 
352 			} 
353 			return !hasError; 
354 		}, 
355 
 
356 		/** 
357 		 * A recursive 'backtrack' solver for the 
358 		 * game. Algorithm is based on the StackOverflow answer 
359 		 * http://stackoverflow.com/questions/18168503/recursively-solving-a-sudoku-puzzle-using-backtracking-theoretically 
360 		 */ 
361 		solveGame: function( row, col ) { 
362 			var cval, sqRow, sqCol, $nextSquare, legalValues, 
363 				sectRow, sectCol, secIndex, gameResult; 
364 
 
365 			this.recursionCounter++; 
366 			$nextSquare = this.findClosestEmptySquare( row, col ); 
367 			if ( !$nextSquare ) { 
368 				// End of board 
369 				return true; 
370 			} else { 
371 				sqRow = $nextSquare.data( 'row' ); 
372 				sqCol = $nextSquare.data( 'col' ); 
373 				legalValues = this.findLegalValuesForSquare( sqRow, sqCol ); 
374 
 
375 				// Find the segment id 
376 				sectRow = Math.floor( sqRow / 3 ); 
377 				sectCol = Math.floor( sqCol / 3 ); 
378 				secIndex = ( sqRow % 3 ) * 3 + ( sqCol % 3 ); 
379 
 
380 				// Try out legal values for this cell 
381 				for ( var i = 0; i < legalValues.length; i++ ) { 
382 					cval = legalValues[i]; 
383 					// Update value in input 
384 					$nextSquare.val( cval ); 
385 					// Update in matrices 
386 					this.matrix.row[sqRow][sqCol] = cval; 
387 					this.matrix.col[sqCol][sqRow] = cval; 
388 					this.matrix.sect[sectRow][sectCol][secIndex] = cval; 
389 
 
390 					// Recursively keep trying 
391 					if ( this.solveGame( sqRow, sqCol ) ) { 
392 						return true; 
393 					} else { 
394 						// There was a problem, we should backtrack 
395 						this.backtrackCounter++; 
396 
 
397 						// Remove value from input 
398 						this.$cellMatrix[sqRow][sqCol].val( '' ); 
399 						// Remove value from matrices 
400 						this.matrix.row[sqRow][sqCol] = ''; 
401 						this.matrix.col[sqCol][sqRow] = ''; 
402 						this.matrix.sect[sectRow][sectCol][secIndex] = ''; 
403 					} 
404 				} 
405 				// If there was no success with any of the legal 
406 				// numbers, call backtrack recursively backwards 
407 				return false; 
408 			} 
409 		}, 
410 
 
411 		/** 
412 		 * Find closest empty square relative to the given cell. 
413 		 * 
414 		 * @param {Number} row Row id 
415 		 * @param {Number} col Column id 
416 		 * @returns {jQuery} Input element of the closest empty 
417 		 *  square 
418 		 */ 
419 		findClosestEmptySquare: function( row, col ) { 
420 			var walkingRow, walkingCol, found = false; 
421 			for ( var i = ( col + 9*row ); i < 81; i++ ) { 
422 				walkingRow = Math.floor( i / 9 ); 
423 				walkingCol = i % 9; 
424 				if ( this.matrix.row[walkingRow][walkingCol] === '' ) { 
425 					found = true; 
426 					return this.$cellMatrix[walkingRow][walkingCol]; 
427 				} 
428 			} 
429 		}, 
430 
 
431 		/** 
432 		 * Find the available legal numbers for the square in the 
433 		 * given row and column. 
434 		 * 
435 		 * @param {Number} row Row id 
436 		 * @param {Number} col Column id 
437 		 * @returns {Array} An array of available numbers 
438 		 */ 
439 		findLegalValuesForSquare: function( row, col ) { 
440 			var legalVals, legalNums, val, i, 
441 				sectRow = Math.floor( row / 3 ), 
442 				sectCol = Math.floor( col / 3 ); 
443 
 
444 			legalNums = [ 1, 2, 3, 4, 5, 6, 7, 8, 9]; 
445 
 
446 			// Check existing numbers in col 
447 			for ( i = 0; i < 9; i++ ) { 
448 				val = Number( this.matrix.col[col][i] ); 
449 				if ( val > 0 ) { 
450 					// Remove from array 
451 					if ( legalNums.indexOf( val ) > -1 ) { 
452 						legalNums.splice( legalNums.indexOf( val ), 1 ); 
453 					} 
454 				} 
455 			} 
456 
 
457 			// Check existing numbers in row 
458 			for ( i = 0; i < 9; i++ ) { 
459 				val = Number( this.matrix.row[row][i] ); 
460 				if ( val > 0 ) { 
461 					// Remove from array 
462 					if ( legalNums.indexOf( val ) > -1 ) { 
463 						legalNums.splice( legalNums.indexOf( val ), 1 ); 
464 					} 
465 				} 
466 			} 
467 
 
468 			// Check existing numbers in section 
469 			sectRow = Math.floor( row / 3 ); 
470 			sectCol = Math.floor( col / 3 ); 
471 			for ( i = 0; i < 9; i++ ) { 
472 				val = Number( this.matrix.sect[sectRow][sectCol][i] ); 
473 				if ( val > 0 ) { 
474 					// Remove from array 
475 					if ( legalNums.indexOf( val ) > -1 ) { 
476 						legalNums.splice( legalNums.indexOf( val ), 1 ); 
477 					} 
478 				} 
479 			} 
480 
 
481 			if ( this.config.solver_shuffle_numbers ) { 
482 				// Shuffling the resulting 'legalNums' array will 
483 				// make sure the solver produces different answers 
484 				// for the same scenario. Otherwise, 'legalNums' 
485 				// will be chosen in sequence. 
486 				for ( i = legalNums.length - 1; i > 0; i-- ) { 
487 					var rand = getRandomInt( 0, i ); 
488 					temp = legalNums[i]; 
489 					legalNums[i] = legalNums[rand]; 
490 					legalNums[rand] = temp; 
491 				} 
492 			} 
493 
 
494 			return legalNums; 
495 		}, 
496 	}; 
497 
 
498 	/** 
499 	 * Get a random integer within a range 
500 	 * 
501 	 * @param {Number} min Minimum number 
502 	 * @param {Number} max Maximum range 
503 	 * @returns {Number} Random number within the range (Inclusive) 
504 	 */ 
505 	function getRandomInt(min, max) { 
506 		return Math.floor( Math.random() * ( max + 1 ) ) + min; 
507 	} 
508 
 
509 	return { 
510 		/** 
511 		 * Get the singleton instance. Only one instance is allowed. 
512 		 * The method will either create an instance or will return 
513 		 * the already existing instance. 
514 		 * 
515 		 * @param {[type]} config [description] 
516 		 * @returns {[type]} [description] 
517 		 */ 
518 		getInstance: function( config ) { 
519 			if ( !_instance ) { 
520 				_instance = init( config ); 
521 			} 
522 			return _instance; 
523 		} 
524 	}; 
525 } )( jQuery ); 
