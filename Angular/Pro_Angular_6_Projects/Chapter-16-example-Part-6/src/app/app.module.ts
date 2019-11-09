

//  The Contents of app.module.ts File

//import { AppComponent } from './app.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ProductComponent } from "./component";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { PaAttrDirective } from "./attr.directive";
import { PaModel } from "./twoway.directive";
import { PaStructureDirective } from "./structure.directive";


@NgModule({
	declarations: [ProductComponent, PaAttrDirective, PaModel, PaStructureDirective],
	imports: [BrowserModule, FormsModule, ReactiveFormsModule],
	providers: [],
	bootstrap: [ProductComponent]
})


export class AppModule { }
