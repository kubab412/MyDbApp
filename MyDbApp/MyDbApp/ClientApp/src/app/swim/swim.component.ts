import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { SwimDto } from '../models/swim-dto.model';

@Component({
  selector: 'app-swim',
  templateUrl: './swim.component.html',
  styleUrls: ['./swim.component.css']
})
export class SwimComponent implements OnInit {
  swimDto = new SwimDto();
  swims: Array<SwimDto>;
  constructor(private http: HttpClient) { }

  ngOnInit() {
  }
  SendRequest() {
    this.http.post("https://localhost:5001/swim/add", this.swimDto).subscribe(x => x == this.swimDto);
  }
  ShowAll() {
    this.http.get<Array<SwimDto>>("https://localhost:5001/swim/show").subscribe(x => this.swims = x);
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
    this.http.delete("https://localhost:5001/swim/" + id).subscribe(x => console.log(id));
  }

  Edit(id: number, name: string, count: number, place: string) {
    var edit = new SwimDto()
    {
      edit.Id = id,
        edit.Name = name,
        edit.Count = count,
        edit.Place = place
    };
    this.http.put("https://localhost:5001/swim/edit", edit).subscribe(x => console.log(edit));
  }
}
