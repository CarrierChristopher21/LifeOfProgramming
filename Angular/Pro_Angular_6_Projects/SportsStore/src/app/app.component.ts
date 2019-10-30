

//	Adding an Element in the app.component.ts File
import { Component } from '@angular/core';

@Component({
	selector: "app",
	template: "<router-outlet></router-outlet>"
	
})

export class AppComponent { }


/*	
@Component({
  selector: 'app',
  template: "<store></store>"
})
export class AppComponent {	}
*/

/*
//	The Contents of the app.component.ts File
@Component({
  selector: 'app',
  template: `<div class="bg-success p-2 text-center text-white">
					This is SportsStore
				</div>`
})
export class AppComponent {	}

*/