import { ErrorHandler, Injectable, Injector } from "@angular/core";
import { Router } from "@angular/router";
import { AppModalService } from "../services/modal.service";

@Injectable()
export class AppErrorHandler implements ErrorHandler {
    constructor(private readonly injector: Injector) { }

    handleError(error: any) {
        const appModalService = this.injector.get(AppModalService);
        const router = this.injector.get(Router);

        if (!error.status) { return; }

        switch (error.status) {
            case 422: {
                appModalService.alert(error.error);
                break;
            }
            case 401: {
                router.navigate(["/login"]);
                break;
            }
            default: {
                console.error(error);
                break;
            }
        }
    }
}
