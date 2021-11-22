import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { RunDto } from '../models/run-dto.model';

@Component({
  selector: 'app-run',
  templateUrl: './run.component.html',
  styleUrls: ['./run.component.css']
})
export class RunComponent implements OnInit {
  runDto = new RunDto();
  runs: Array<RunDto>;
  constructor(private http: HttpClient) { }

  ngOnInit() {
  }
  SendRequest() {
    this.http.post("https://localhost:5001/run/add", this.runDto).subscribe(x => x == this.runDto);
  }
  ShowAll() {
    this.http.get<Array<RunDto>>("https://localhost:5001/run/show").subscribe(x => this.runs = x);
    /*fetch('https://localhost:5001/gym/show', {
      method: 'GET',
      headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
      }
    }).then(response => response.json())
      .then(data => {
        this.gyms = data;
        this.ngOnInit();
      });*/
  }
  Remove(id: number) {
    this.http.delete("https://localhost:5001/run/" + id).subscribe(x => console.log(id));
  }

  Edit(id: number, name: string, count: number, place: string) {
    var edit = new RunDto()
    {
      edit.Id = id,
        edit.Name = name,
        edit.Count = count,
        edit.Place = place
    };
    this.http.put("https://localhost:5001/run/edit", edit).subscribe(x => console.log(edit));
  }
}
