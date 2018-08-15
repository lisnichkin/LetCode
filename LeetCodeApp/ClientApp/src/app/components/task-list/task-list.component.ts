import { Component, OnInit } from '@angular/core';
import {TaskService} from "../../services/task.service";
import {Task} from "../../models/task";

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css'],
  providers: [TaskService]
})

export class TaskListComponent implements OnInit {

//  
  tasks: Task[];

  constructor(private taskService: TaskService) {

  }

  ngOnInit() {
    this.loadData();
  }

  loadData()
  {
    this.taskService.getTasks().subscribe((data: Task[]) => this.tasks = data);
  }

}