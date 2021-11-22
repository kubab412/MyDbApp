import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { WearDto } from '../models/wear-dto.model';

@Component({
  selector: 'app-wear',
  templateUrl: './wear.component.html',
  styleUrls: ['./wear.component.css']
})
export class WearComponent implements OnInit {
  wearDto = new WearDto();
  wears: Array<WearDto>;
  constructor(private http: HttpClient) { }

  ngOnInit() {
  }
  SendRequest() {
    this.http.post("https://localhost:5001/wear/add", this.wearDto).subscribe(x => x == this.wearDto);
  }
  ShowAll() {
    this.http.get<Array<WearDto>>("https://localhost:5001/wear/show").subscribe(x => this.wears = x);
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
    this.http.delete("https://localhost:5001/wear/" + id).subscribe(x => console.log(id));
  }

  Edit(id: number, name: string, count: number, place: string) {
    var edit = new WearDto()
    {
      edit.Id = id,
        edit.Name = name,
        edit.Count = count,
        edit.Place = place
    };
    this.http.put("https://localhost:5001/wear/edit", edit).subscribe(x => console.log(edit));
  }
}
