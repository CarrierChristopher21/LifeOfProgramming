
//	The Contents of the cartSummary.component.ts File

import { Component } from "@angular/core";
import { Cart } from "../model/cart.model";

@Component({
	selector: "cart-summary",
	templateUrl: "cartSummary.component.html"
})

export class CartSummaryComponent {
	
	constructor(public cart: Cart) { }
}
