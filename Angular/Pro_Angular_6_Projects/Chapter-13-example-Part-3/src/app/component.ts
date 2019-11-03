
//  The Contents of the component.ts File

import { ApplicationRef, Component } from "@angular/core";
import { Model } from "./repository.model";
import { Product } from "./product.model";

@Component({
	selector: "app",
	templateUrl: "template.html"
})

export class ProductComponent {
	model: Model = new Model();

	constructor(ref: ApplicationRef) {
		(<any>window).appRef = ref;
		(<any>window).model = this.model;
	}

	getProductByPosition(position: number): Product {
		return this.model.getProducts()[position];
	}

	getClassesByPosition(position: number): string {
		let product = this.getProductByPosition(position);
		return "p-2 " + (product.price < 50 ? "bg-info" : "bg-warning");
	}

	getProduct(key: number): Product {
		return this.model.getProduct(key);
	}

	getProducts(): Product[] {
		return this.model.getProducts();
	}

	getProductCount(): number {
		console.log("getProductCount invoked");
		return this.getProducts().length;
	}

	targetName: string = "Kayak";

	counter: number = 1;

	get nextProduct(): Product {
		return this.model.getProducts().shift();
	}

	getProductPrice(index: number): number {
		return Math.floor(this.getProduct(index).price);
	}
}

/*getKey(index: number, product: Product) {
		return product.id;
	}*/

    /*
	getClasses(key: number): string {
		let product = this.model.getProduct(key);
		return "p-2 " + (product.price < 50 ? "bg-info" : "bg-warning");
	}

	getStyles(key: number) {
		let product = this.model.getProduct(key);
		return {
			fontSize: "30px",
			"margin.px": 100,
			color: product.price > 50 ? "red" : "green"
		};
	}

    
	getClassMap(key: number): Object {
		let product = this.model.getProduct(key);
		return {
			"text-center bg-danger": product.name = "Kayak",
			"bg-info": product.price < 50
		};
	}

	fontSizeWithUnits: string = "30px";
	fontSizeWithoutUnits: string = "30";
    */
