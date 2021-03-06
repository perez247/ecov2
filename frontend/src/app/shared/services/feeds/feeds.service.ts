import { Injectable, Inject } from '@angular/core';
import { BaseApiService } from '../base-api.service';
import { DOCUMENT } from '@angular/platform-browser';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FeedsService extends BaseApiService  {
  token: string;

  constructor(private http: HttpClient) {
    super('home')
  }

  getProblems() {
    return this.http.get(`${this.api}/problem-feeds`);
  }
}
