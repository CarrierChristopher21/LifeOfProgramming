
//  The Contents of the component.ts File

import { Component } from "@angular/core";
import { Model } from "./repository.model";

@Component({
	selector: "app",
	templateUrl: "template.html"
})

export class ProductComponent {
	model: Model = new Model();
}
