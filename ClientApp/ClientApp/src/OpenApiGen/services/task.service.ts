/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { BaseService } from '../base-service';
import { ApiConfiguration } from '../api-configuration';
import { StrictHttpResponse } from '../strict-http-response';

import { apiTaskGet } from '../fn/task/api-task-get';
import { ApiTaskGet$Params } from '../fn/task/api-task-get';
import { apiTaskPost } from '../fn/task/api-task-post';
import { ApiTaskPost$Params } from '../fn/task/api-task-post';

@Injectable({ providedIn: 'root' })
export class TaskService extends BaseService {
  constructor(config: ApiConfiguration, http: HttpClient) {
    super(config, http);
  }

  /** Path part for operation `apiTaskGet()` */
  static readonly ApiTaskGetPath = '/api/Task';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiTaskGet()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiTaskGet$Response(params?: ApiTaskGet$Params, context?: HttpContext): Observable<StrictHttpResponse<void>> {
    return apiTaskGet(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiTaskGet$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiTaskGet(params?: ApiTaskGet$Params, context?: HttpContext): Observable<void> {
    return this.apiTaskGet$Response(params, context).pipe(
      map((r: StrictHttpResponse<void>): void => r.body)
    );
  }

  /** Path part for operation `apiTaskPost()` */
  static readonly ApiTaskPostPath = '/api/Task';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiTaskPost()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiTaskPost$Response(params?: ApiTaskPost$Params, context?: HttpContext): Observable<StrictHttpResponse<void>> {
    return apiTaskPost(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiTaskPost$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiTaskPost(params?: ApiTaskPost$Params, context?: HttpContext): Observable<void> {
    return this.apiTaskPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<void>): void => r.body)
    );
  }

}
