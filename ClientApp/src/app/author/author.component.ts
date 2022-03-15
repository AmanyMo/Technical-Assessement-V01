//import { Component, OnInit } from '@angular/core';


//@Component({
//  selector: 'app-author',
//  templateUrl: './author.component.html',
//  styleUrls: ['./author.component.css']
//})
//export class AuthorComponent implements OnInit {

//  constructor() { }

//  ngOnInit() {
//  }

//}

import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-author',
  templateUrl: './author.component.html'
})
export class AuthorComponent {
  public authors: Author[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Author[]>(baseUrl + 'api/Author').subscribe(result => {
      this.authors = result;
    }, error => console.error(error));
  }
}

interface Author {
  id: number;
  name: string;
  dbo: Date;
  bio: string;
  image: string;
}
