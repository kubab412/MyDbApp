import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { CategoryDto } from '../models/category-dto.model';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {
  categoryDto = new CategoryDto();
  categories: Array<CategoryDto>;
  constructor(private http: HttpClient) { }

  ngOnInit() {
  }
  ShowAll() {
    this.http.get<Array<CategoryDto>>("https://localhost:5001/category/show").subscribe(x => this.categories = x);
  }
}
