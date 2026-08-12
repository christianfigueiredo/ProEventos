import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  standalone: false,
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  exibirImagem: boolean = true;

  constructor(private http: HttpClient){}

  ngOnInit(): void{
     this.getEventos();
  }

  alterarImagem(): void {
    this.exibirImagem = !this.exibirImagem;
  }

  public getEventos(): void {
    this.http.get('https://localhost:7275/api/eventos').subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );
  }
}
