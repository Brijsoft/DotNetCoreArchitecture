import { HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { AppTokenService } from "../services/token.service";

@Injectable()
export class AppHttpInterceptor implements HttpInterceptor {
    constructor(private readonly appTokenService: AppTokenService) { }

    intercept(request: HttpRequest<any>, next: HttpHandler) {
        let url = request.url;

        if (!url.startsWith("http")) {
            url = document.getElementsByTagName("base").item(0).href + url;
        }

        request = request.clone({
            setHeaders: { Authorization: `Bearer ${this.appTokenService.get()}` },
            url
        });

        return next.handle(request);
    }
}
