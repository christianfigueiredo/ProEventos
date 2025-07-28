import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [
    {
      Tema: '.Net 6', 
      Local: 'São Paulo'
    },
    {
      Tema: 'Angular e suas novidades', 
      Local:'Belo Horizonte'
    },
    {
      Tema: 'SQLSERVER', 
      Local:'Curitiba'
    }
  ];

  constructor() { }
  ngOnInit(): void {   
  }
}
