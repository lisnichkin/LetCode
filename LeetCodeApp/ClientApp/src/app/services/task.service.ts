import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Task } from '../models/task';

@Injectable()
export class TaskService {

  private url = "/api/algorithms";

  constructor(private http: HttpClient) { 

  }

  getTasks()
  {
    return this.http.get(this.url);
  }
}
