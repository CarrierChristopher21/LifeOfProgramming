package com.revature.eval.java.core;

import java.time.Duration;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.temporal.ChronoUnit;
import java.time.temporal.Temporal;
import java.util.*;


//@SuppressWarnings("unused")
public class EvaluationService {

	/**	Question 1 - PASS
	 * 1. Without using the StringBuilder or StringBuffer class, write a method that
	 * reverses a String. Example: reverse("example"); -> "elpmaxe"
	 * 
	 * @param string
	 * @return
	 */
	/*	Question 1 - Pass
	public String reverse(String string) {
		char[] reversed = new char[string.length()];
		for (int i = reversed.length - 1, j=0; i >= 0; i--, j++) {
			reversed[j] = string.charAt(i);
		}
		return new String(reversed);
	}
*/
	
	/**	Question 2 - PASS
	 * 2. Convert a phrase to its acronym. Techies love their TLA (Three Letter
	 * Acronyms)! Help generate some jargon by writing a program that converts a
	 * long name like Portable Network Graphics to its acronym (PNG).
	 * 
	 * @param phrase
	 * @return
	 */
	/*	Question 2 - PASS
	public String acronym(String phrase) {
		// TODO Write an implementation for this method declaration
		boolean testLetter = false;
		StringBuilder word = new StringBuilder();
		char w;
		System.out.println(phrase);
		for(int i = 0; i< phrase.length(); i++) {
			w = phrase.charAt(i);
			if(Character.isLetter(w) && !testLetter) {
				word.append(w);
				testLetter = true;
				System.out.println(word);
			}else if(!Character.isLetter(w)) {
				testLetter = false;
			}
			
		}
		return word.toString().toUpperCase();
	}
*/
	
	/**	Question 3	- PASS
	 * 3. Determine if a triangle is equilateral, isosceles, or scalene. An
	 * equilateral triangle has all three sides the same length. An isosceles
	 * triangle has at least two sides the same length. (It is sometimes specified
	 * as having exactly two sides the same length, but for the purposes of this
	 * exercise we'll say at least two.) A scalene triangle has all sides of
	 * different lengths.
	 *
	 */
	/*	Question 3 - Pass
	static class Triangle {
		private double sideOne;
		private double sideTwo;
		private double sideThree;

		public Triangle() {
			super();
		}

		public Triangle(double sideOne, double sideTwo, double sideThree) {
			this();
			this.sideOne = sideOne;
			this.sideTwo = sideTwo;
			this.sideThree = sideThree;
		}

		public double getSideOne() {
			return sideOne;
		}

		public void setSideOne(double sideOne) {
			this.sideOne = sideOne;
		}

		public double getSideTwo() {
			return sideTwo;
		}

		public void setSideTwo(double sideTwo) {
			this.sideTwo = sideTwo;
		}

		public double getSideThree() {
			return sideThree;
		}

		public void setSideThree(double sideThree) {
			this.sideThree = sideThree;
		}

		public boolean isEquilateral() {	//	All same number
			// TODO Write an implementation for this method declaration
			if(this.getSideOne() == this.getSideTwo()){
				if(this.getSideOne() == this.getSideThree()) {
					return true;
				}else 
					return false;
				
			}else 
				return false;
						
			
		}

		public boolean isIsosceles() {		//	2 sides same 1 off
			// TODO Write an implementation for this method declaration
			if(this.getSideOne() == this.getSideTwo()) {
				return true;
			}
			else if(this.getSideOne() == this.getSideThree()) {
				return true;
			}
			else if(this.getSideTwo() == this.getSideThree()) {
				return true;
			}else
				return false;
			
		}

		public boolean isScalene() {		//	3 different sides number
			// TODO Write an implementation for this method declaration
			if(this.getSideOne() != this.getSideTwo()) {
				if(this.getSideOne() != this.getSideThree()) 
					return true;
				else if(this.getSideTwo() != this.getSideThree()) 
					return true;
				return true;
				
			}else
				return false;
			
		}

	}
*/
	
	/**	Question 4	- Pass
	 * 4. Given a word, compute the scrabble score for that word.
	 * 
	 * --Letter Values-- Letter Value A, E, I, O, U, L, N, R, S, T = 1; D, G = 2; B,
	 * C, M, P = 3; F, H, V, W, Y = 4; K = 5; J, X = 8; Q, Z = 10; Examples
	 * "cabbage" should be scored as worth 14 points:
	 * 
	 * 3 points for C, 1 point for A, twice 3 points for B, twice 2 points for G, 1
	 * point for E And to total:
	 * 
	 * 3 + 2*1 + 2*3 + 2 + 1 = 3 + 2 + 6 + 3 = 5 + 9 = 14
	 * 
	 * @param string
	 * @return
	 */
	/*	Question 4 - PASS
	public int getScrabbleScore(String string) {
		// TODO Write an implementation for this method declaration
		string = string.toUpperCase();
//		char [] arrayWord = string.toCharArray();
		
		int score = 0;
		for(int count = 0; count < string.length(); count++) {
			switch(string.charAt(count)) {
			case 'A':
			case 'E':
			case 'I':
			case 'O':
			case 'U':
			case 'L':
			case 'N':
			case 'R':
			case 'S':
			case 'T':
				score += 1;
//				System.out.println(score);
				break;
			case 'D':
			case 'G':
				score += 2;
//				System.out.println(score);
				break;
			case 'B':
			case 'C':
			case 'M':
			case 'P':
				score += 3;
//				System.out.println(score);
				break;
			case 'F':
			case 'H':
			case 'V':
			case 'W':
			case 'Y':
				score += 4;
//				System.out.println(score);
				break;
			case 'K':
				score += 5;
//				System.out.println(score);
				break;
			case 'J':
			case 'X':
				score += 8;
//				System.out.println(score);
				break;
			case 'Q':
			case 'Z':
				score += 10;
//				System.out.println(score);
				break;
			}
		}
		
		System.out.println(string + " is equivalent to " + score);
//		string.charAt(num);		
		
		return score;
	}

*/
	
	/**	Question 5
	 * 5. Clean up user-entered phone numbers so that they can be sent SMS messages.
	 * 
	 * The North American Numbering Plan (NANP) is a telephone numbering system used
	 * by many countries in North America like the United States, Canada or Bermuda.
	 * All NANP-countries share the same international country code: 1.
	 * 
	 * NANP numbers are ten-digit numbers consisting of a three-digit Numbering Plan
	 * Area code, commonly known as area code, followed by a seven-digit local
	 * number. The first three digits of the local number represent the exchange
	 * code, followed by the unique four-digit number which is the subscriber
	 * number.
	 * 
	 * The format is usually represented as
	 * 
	 * 1 (NXX)-NXX-XXXX where N is any digit from 2 through 9 and X is any digit
	 * from 0 through 9.
	 * 
	 * Your task is to clean up differently formatted telephone numbers by removing
	 * punctuation and the country code (1) if present.
	 * 
	 * For example, the inputs
	 * 
	 * +1 (613)-995-0253 613-995-0253 1 613 995 0253 613.995.0253 should all produce
	 * the output
	 * 
	 * 6139950253
	 * 
	 * Note: As this exercise only deals with telephone numbers used in
	 * NANP-countries, only 1 is considered a valid country code.
	 */
	/*	Question 5
	public String cleanPhoneNumber(String string) {
		// TODO Write an implementation for this method declaration
		return null;
	}
*/
	
	/**	Question 6
	 * 6. Given a phrase, count the occurrences of each word in that phrase.
	 * 
	 * For example for the input "olly olly in come free" olly: 2 in: 1 come: 1
	 * free: 1
	 * 
	 * @param string
	 * @return
	 */
//	/*	Question 6
	public Map<String, Integer> wordCount(String string) {
		// TODO Write an implementation for this method declaration
		System.out.println("We have: " + string + "\n");
//		System.out.println("We Box: " + + "\n");
		
		
		return null;
	}
//*/
	
	/**	Question 7	- PASS
	 * 7. Implement a binary search algorithm.
	 * 
	 * Searching a sorted collection is a common task. A dictionary is a sorted list
	 * of word definitions. Given a word, one can find its definition. A telephone
	 * book is a sorted list of people's names, addresses, and telephone numbers.
	 * Knowing someone's name allows one to quickly find their telephone number and
	 * address.
	 * 
	 * If the list to be searched contains more than a few items (a dozen, say) a
	 * binary search will require far fewer comparisons than a linear search, but it
	 * imposes the requirement that the list be sorted.
	 * 
	 * In computer science, a binary search or half-interval search algorithm finds
	 * the position of a specified input value (the search "key") within an array
	 * sorted by key value.
	 * 
	 * In each step, the algorithm compares the search key value with the key value
	 * of the middle element of the array.
	 * 
	 * If the keys match, then a matching element has been found and its index, or
	 * position, is returned.
	 * 
	 * Otherwise, if the search key is less than the middle element's key, then the
	 * algorithm repeats its action on the sub-array to the left of the middle
	 * element or, if the search key is greater, on the sub-array to the right.
	 * 
	 * If the remaining array to be searched is empty, then the key cannot be found
	 * in the array and a special "not found" indication is returned.
	 * 
	 * A binary search halves the number of items to check with each iteration, so
	 * locating an item (or determining its absence) takes logarithmic time. A
	 * binary search is a dichotomic divide and conquer search algorithm.
	 * 
	 */
	/*	Question 7	- PASS
	static class BinarySearch<T> {
		private List<T> sortedList;

		public int indexOf(T t) {
			// TODO Write an implementation for this method declaration
			int sizeList = sortedList.size();
            int low = 0; int high = sizeList - 1;
            int num = 0;
            T l;
            System.out.println("Idex number: " + t);
            for (int i = 0; i < sizeList; i++) {
                num = (high + low) / 2;
                l = sortedList.get(num);
                if (l.equals(t)) {
                    break;
                } else if ((int)l < (int)t) {
                    low = (int)num + 1;
                } else if ((int)l > (int)t) {
                    high = (int)num - 1;
                }
                
            }
            System.out.println("The sorted list is: " + sortedList);
            System.out.println("high number: " + high);
            System.out.println("Final number is: " + num + "\n");
			return num;
		}

		public BinarySearch(List<T> sortedList) {
			super();
			this.sortedList = sortedList;
		}

		public List<T> getSortedList() {
			return sortedList;
		}

		public void setSortedList(List<T> sortedList) {
			this.sortedList = sortedList;
		}

	}
*/
	
	/**	Question 8	- Pass
	 * 8. Implement a program that translates from English to Pig Latin.
	 * 
	 * Pig Latin is a made-up children's language that's intended to be confusing.
	 * It obeys a few simple rules (below), but when it's spoken quickly it's really
	 * difficult for non-children (and non-native speakers) to understand.
	 * 
	 * Rule 1: If a word begins with a vowel sound, add an "ay" sound to the end of
	 * the word. Rule 2: If a word begins with a consonant sound, move it to the end
	 * of the word, and then add an "ay" sound to the end of the word. There are a
	 * few more rules for edge cases, and there are regional variants too.
	 * 
	 * See http://en.wikipedia.org/wiki/Pig_latin for more details.
	 * 
	 * @param string
	 * @return
	 */
	/*	Question 8	- Pass
	public String toPigLatin(String string) {
		// TODO Write an implementation for this method declaration
		string.toLowerCase();
		char vowel[] = {'a', 'e', 'i', 'o', 'u'};
		StringBuilder lang = new StringBuilder();
		StringBuilder letter = new StringBuilder();
		StringBuilder end = new StringBuilder();
		String word = null;
		String[] words = {};
		words = string.split(" ");
		
//		System.out.println(string);
		for(int a = 0; a < words.length; a++) {
			lang.delete(0,  lang.length());
			letter.delete(0, letter.length());
			for(int i = 0; i < words[a].length(); i++) {
				word = "" + words[a].charAt(i);
				
				if(Arrays.toString(vowel).contains(word)) {
					lang.append(words[a], i, words[a].length());
					break;
				}else {
					letter.append(word);
					if(words[a].contains("qu")) {
						letter.append("u");
						i++;
					}
				}	
			
			}
			lang.append(letter.toString() + "ay");
			
			end.append(lang.toString());
			if(words.length > 1 && a != (words.length -1)) {
				end.append(" ");
			}
		}

		
		
		System.out.println(end.toString());
		return end.toString();
	}
*/
	
	/**	Question 9 - Pass
	 * 9. An Armstrong number is a number that is the sum of its own digits each
	 * raised to the power of the number of digits.
	 * 
	 * For example:
	 * 
	 * 9 is an Armstrong number, because 9 = 9^1 = 9 10 is not an Armstrong number,
	 * because 10 != 1^2 + 0^2 = 2 153 is an Armstrong number, because: 153 = 1^3 +
	 * 5^3 + 3^3 = 1 + 125 + 27 = 153 154 is not an Armstrong number, because: 154
	 * != 1^3 + 5^3 + 4^3 = 1 + 125 + 64 = 190 Write some code to determine whether
	 * a number is an Armstrong number.
	 * 
	 * @param input
	 * @return
	 */
	/*	Question 9 - Pass
//	Inspired from: https://www.javatpoint.com/armstrong-number-in-java
//	https://www.programiz.com/java-programming/examples/armstrong-number
	public boolean isArmstrongNumber(int input) {
		// TODO Write an implementation for this method declaration
		int br = 0, statsis, calc = 0, n = 0;
		
		
		statsis = input;	//	duplicate digit for loop
		
		 for (;statsis != 0; statsis /= 10, ++n);
		 
	 	statsis = input;	//	duplicate digit for loop
		 
	 	for (;statsis != 0; statsis /= 10)
        {
            br = statsis % (10);
            calc += Math.pow(br, n);
        }

		 	
//		while(input != 0) {
//			br = input % 10;
//			input /=  10;
//			calc += Math.pow(br, 3);//(blast * blast * blast);
//		}
		
		if(input == calc) {
			System.out.println("We are GO for lift off! " + input +
					" == " + calc);
			return true;
		}else{
			System.out.println("We have a problem Houston! " + input + 
					" != " + calc);
			return false;
		}
	}
*/
	
	/**	Question 10 - Pass
	 * 10. Compute the prime factors of a given natural number.
	 * 
	 * A prime number is only evenly divisible by itself and 1.
	 * 
	 * Note that 1 is not a prime number.
	 * 
	 * @param l
	 * @return
	 */
	/*	Question 10 - Pass
	public List<Long> calculatePrimeFactorsOf(long l) {
		// TODO Write an implementation for this method declaration
		List<Long> pRay = new ArrayList<Long>();
		long prime = l;
		for(int a = 2; a <= prime; a++) {
			if(prime % a == 0) {
//				System.out.println("Current prime: " + a);
				pRay.add((long) a);
				prime = prime / a;
				a = a- 1;
				
			}
		}
		
		
		
		
//		System.out.println(l + " is not prime: " + prime);
			
		
		return pRay;
	}
*/
	
	/**	Question 11
	 * 11. Create an implementation of the rotational cipher, also sometimes called
	 * the Caesar cipher.
	 * 
	 * The Caesar cipher is a simple shift cipher that relies on transposing all the
	 * letters in the alphabet using an integer key between 0 and 26. Using a key of
	 * 0 or 26 will always yield the same output due to modular arithmetic. The
	 * letter is shifted for as many values as the value of the key.
	 * 
	 * The general notation for rotational ciphers is ROT + <key>. The most commonly
	 * used rotational cipher is ROT13.
	 * 
	 * A ROT13 on the Latin alphabet would be as follows:
	 * 
	 * Plain: abcdefghijklmnopqrstuvwxyz Cipher: nopqrstuvwxyzabcdefghijklm It is
	 * stronger than the Atbash cipher because it has 27 possible keys, and 25
	 * usable keys.
	 * 
	 * Ciphertext is written out in the same formatting as the input including
	 * spaces and punctuation.
	 * 
	 * Examples: ROT5 omg gives trl ROT0 c gives c ROT26 Cool gives Cool ROT13 The
	 * quick brown fox jumps over the lazy dog. gives Gur dhvpx oebja sbk whzcf bire
	 * gur ynml qbt. ROT13 Gur dhvpx oebja sbk whzcf bire gur ynml qbt. gives The
	 * quick brown fox jumps over the lazy dog.
	 */
	/*	Question 11
	static class RotationalCipher {
		private int key;

		public RotationalCipher(int key) {
			super();
			this.key = key;
		}

		public String rotate(String string) {
			// TODO Write an implementation for this method declaration
			return null;
		}

	}
*/
	
	/**	Question 12 - Pass
	 * 12. Given a number n, determine what the nth prime is.
	 * 
	 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see
	 * that the 6th prime is 13.
	 * 
	 * If your language provides methods in the standard library to deal with prime
	 * numbers, pretend they don't exist and implement them yourself.
	 * 
	 * @param i
	 * @return
	 */
	/*	Question 12 - PASS
	public int calculateNthPrime(int i) {
		// TODO Write an implementation for this method declaration
//		System.out.println("The position that I'm looking for is " + i);
		int num = 0;
		int a = 0;
		int r;
		int remain = 0; // count
//		int cut = 0;
//		int maxCheck = 200000;
//		boolean isPrime = true;
		// Match maxCheck with i so that way you have the right output
		 do{
			if(i == 0) {
				throw new IllegalArgumentException();
			}else {
				num = num + 1;
				for (r = 2; r <= num; r++) {
					if(num % r == 0) {
						break;
					}
				}
				if(r == num) {
					remain += 1;
					
				}
//				System.out.println(num);
			}			
			
		}while(remain < i);	
		
		System.out.println("You Pass!");
		return num;
	}
*/
	
	/**	Questions 13 & 14
	 * 13 & 14. Create an implementation of the atbash cipher, an ancient encryption
	 * system created in the Middle East.
	 * 
	 * The Atbash cipher is a simple substitution cipher that relies on transposing
	 * all the letters in the alphabet such that the resulting alphabet is
	 * backwards. The first letter is replaced with the last letter, the second with
	 * the second-last, and so on.
	 * 
	 * An Atbash cipher for the Latin alphabet would be as follows:
	 * 
	 * Plain: abcdefghijklmnopqrstuvwxyz Cipher: zyxwvutsrqponmlkjihgfedcba It is a
	 * very weak cipher because it only has one possible key, and it is a simple
	 * monoalphabetic substitution cipher. However, this may not have been an issue
	 * in the cipher's time.
	 * 
	 * Ciphertext is written out in groups of fixed length, the traditional group
	 * size being 5 letters, and punctuation is excluded. This is to make it harder
	 * to guess things based on word boundaries.
	 * 
	 * Examples Encoding test gives gvhg Decoding gvhg gives test Decoding gsvjf
	 * rxpyi ldmul cqfnk hlevi gsvoz abwlt gives thequickbrownfoxjumpsoverthelazydog
	 *
	 */
	//	Question 13 & 14
	/*
	static class AtbashCipher {

		/**	Question 13
		 * Question 13
		 * 
		 * @param string
		 * @return
		 */
	/*	Question 13
		public static String encode(String string) {
			// TODO Write an implementation for this method declaration
			return null;
		}
*/
		/**	Question 14
		 * Question 14
		 * 
		 * @param string
		 * @return
		 */
		/*	Question 14
		public static String decode(String string) {
			// TODO Write an implementation for this method declaration
			return null;
		}
		
	}*/

	/**	Question 15
	 * 15. The ISBN-10 verification process is used to validate book identification
	 * numbers. These normally contain dashes and look like: 3-598-21508-8
	 * 
	 * ISBN The ISBN-10 format is 9 digits (0 to 9) plus one check character (either
	 * a digit or an X only). In the case the check character is an X, this
	 * represents the value '10'. These may be communicated with or without hyphens,
	 * and can be checked for their validity by the following formula:
	 * 
	 * (x1 * 10 + x2 * 9 + x3 * 8 + x4 * 7 + x5 * 6 + x6 * 5 + x7 * 4 + x8 * 3 + x9
	 * * 2 + x10 * 1) mod 11 == 0 If the result is 0, then it is a valid ISBN-10,
	 * otherwise it is invalid.
	 * 
	 * Example Let's take the ISBN-10 3-598-21508-8. We plug it in to the formula,
	 * and get:
	 * 
	 * (3 * 10 + 5 * 9 + 9 * 8 + 8 * 7 + 2 * 6 + 1 * 5 + 5 * 4 + 0 * 3 + 8 * 2 + 8 *
	 * 1) mod 11 == 0 Since the result is 0, this proves that our ISBN is valid.
	 * 
	 * @param string
	 * @return
	 */
	/*	Question 15
	public boolean isValidIsbn(String string) {
		// TODO Write an implementation for this method declaration
		return false;
	}
*/
	
	/**	Question 16 - PASS
	 * 16. Determine if a sentence is a pangram. A pangram (Greek: παν γράμμα, pan
	 * gramma, "every letter") is a sentence using every letter of the alphabet at
	 * least once. The best known English pangram is:
	 * 
	 * The quick brown fox jumps over the lazy dog.
	 * 
	 * The alphabet used consists of ASCII letters a to z, inclusive, and is case
	 * insensitive. Input will not contain non-ASCII symbols.
	 * 
	 * @param string
	 * @return
	 */
	/*	Question 16 - PASS
	public boolean isPangram(String string) {
		// TODO Write an implementation for this method declaration
		char letter[] = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
				'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
				'w', 'x', 'y', 'z'};
		String let = null;
		for(int i = 0; i <= 25; i++) {
			
			let = "" + letter[i];
			if(!string.contains(let)) {
				
				return false;
			}			
		}
		
		return true;
	}

//*/
	
	/**	Question 17	- PASS
	 * 17. Calculate the moment when someone has lived for 10^9 seconds.
	 * 
	 * A gigasecond is 109 (1,000,000,000) seconds.
	 * 
	 * @param given
	 * @return
	 */
	/*	Question 17	- PASS
	public Temporal getGigasecondDate(Temporal given) {
		// TODO Write an implementation for this method declaration
		//	Could be 3 lines 1 if + else
		LocalDateTime time = LocalDate.from(given).atStartOfDay();
		int bil = 1000000000;
		 if(given.isSupported(ChronoUnit.SECONDS))
			 return given.plus(Duration.ofSeconds(bil));
		 else
			 return time.plusSeconds(bil);
	}
*/
	
	/**	Question 18	- Pass
	 * 18. Given a number, find the sum of all the unique multiples of particular
	 * numbers up to but not including that number.
	 * 
	 * If we list all the natural numbers below 20 that are multiples of 3 or 5, we
	 * get 3, 5, 6, 9, 10, 12, 15, and 18.
	 * 
	 * The sum of these multiples is 78.
	 * 
	 * @param i
	 * @param set
	 * @return
	 * 
	 * set replaces 3 or 5
	 * i replaces 20
	 * find output
	 */
	/*	Question 18 - PASS

	public int getSumOfMultiples(int i, int[] set) {
		// TODO Write an implementation for this method declaration


		int sum = 0;
		int amount = 0;
//		int num = i;
		ArrayList<Integer> count = new ArrayList<Integer>();
		Set<Integer> set1 = new LinkedHashSet<Integer>();
		for(int r = 0; r < set.length; r++) {
			int number = set[r];  
			System.out.println("The set number multiples: " + number);
			while(number < i) {
				set1.add(number);
				number += set[r];
			}
						
		}
		for ( int x : set1) {
			sum += x;
		}
		System.out.println("Up to " + i);
		System.out.println("The sum total is " + sum);
		
		System.out.println(set1 + "\n");
		
		
		return sum;
	}
*/
	
	/**	Question 19
	 * 19. Given a number determine whether or not it is valid per the Luhn formula.
	 * 
	 * The Luhn algorithm is a simple checksum formula used to validate a variety of
	 * identification numbers, such as credit card numbers and Canadian Social
	 * Insurance Numbers.
	 * 
	 * The task is to check if a given string is valid.
	 * 
	 * Validating a Number Strings of length 1 or less are not valid. Spaces are
	 * allowed in the input, but they should be stripped before checking. All other
	 * non-digit characters are disallowed.
	 * 
	 * Example 1: valid credit card number 1 4539 1488 0343 6467 The first step of
	 * the Luhn algorithm is to double every second digit, starting from the right.
	 * We will be doubling
	 * 
	 * 4_3_ 1_8_ 0_4_ 6_6_ If doubling the number results in a number greater than 9
	 * then subtract 9 from the product. The results of our doubling:
	 * 
	 * 8569 2478 0383 3437 Then sum all of the digits:
	 * 
	 * 8+5+6+9+2+4+7+8+0+3+8+3+3+4+3+7 = 80 If the sum is evenly divisible by 10,
	 * then the number is valid. This number is valid!
	 * 
	 * Example 2: invalid credit card number 1 8273 1232 7352 0569 Double the second
	 * digits, starting from the right
	 * 
	 * 7253 2262 5312 0539 Sum the digits
	 * 
	 * 7+2+5+3+2+2+6+2+5+3+1+2+0+5+3+9 = 57 57 is not evenly divisible by 10, so
	 * this number is not valid.
	 * 
	 * @param string
	 * @return
	 */
	/*	Question 19
	public boolean isLuhnValid(String string) {
		// TODO Write an implementation for this method declaration
		return false;
	}
*/
	
	/**	Question 20
	 * 20. Parse and evaluate simple math word problems returning the answer as an
	 * integer.
	 * 
	 * Add two numbers together.
	 * 
	 * What is 5 plus 13?
	 * 
	 * 18
	 * 
	 * Now, perform the other three operations.
	 * 
	 * What is 7 minus 5?
	 * 
	 * 2
	 * 
	 * What is 6 multiplied by 4?
	 * 
	 * 24
	 * 
	 * What is 25 divided by 5?
	 * 
	 * 5
	 * 
	 * @param string
	 * @return
	 */
//	/*	Question 20
	public int solveWordProblem(String string) {
		// TODO Write an implementation for this method declaration
		return 0;
	}
//	*/
}
