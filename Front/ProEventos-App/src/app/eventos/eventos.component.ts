import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  standalone: false,
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent implements OnInit {

  public eventos: any = [ {
    tema: 'Angular',
    local: 'Belo Horizonte'
  },
  {
     tema: '.Net 6',
    local: 'São Paulo'
  },
  {
     tema: 'IA',
    local: 'Rio de Janeiro'
  }
]

  constructor(){}

  ngOnInit(): void{}

}
