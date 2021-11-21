import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { GymDto } from '../models/gym-dto.model';

@Component({
  selector: 'app-gym',
  templateUrl: './gym.component.html',
  styleUrls: ['./gym.component.css']
})
export class GymComponent implements OnInit {
  gymDto = new GymDto();
  gyms: Array<GymDto>;
  constructor(private http: HttpClient) { }

  ngOnInit() {
  }
  SendRequest() {
    this.http.post("https://localhost:5001/gym/add", this.gymDto).subscribe(x => x == this.gymDto);
  }
  ShowAll() {
    this.http.get<Array<GymDto>>("https://localhost:5001/gym/show").subscribe(x =>this.gyms = x);
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
    this.http.delete("https://localhost:5001/gym/" + id).subscribe(x => console.log(id));
  }
  
  Edit(id: number, name: string, count: number, place: string) {
    var edit = new GymDto()
    {
      edit.Id = id,
        edit.Name = name,
        edit.Count = count,
        edit.Place = place
    };
    this.http.put("https://localhost:5001/gym/edit", edit).subscribe(x => console.log(edit));
  }

}
