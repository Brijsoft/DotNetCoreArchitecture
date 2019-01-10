import { NgModule } from "@angular/core";
import { AppAuthenticationGuard } from "./authentication.guard";

@NgModule({
    providers: [AppAuthenticationGuard]
})
export class AppGuardsModule { }
