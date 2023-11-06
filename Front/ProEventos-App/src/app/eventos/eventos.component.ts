import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  imgLarg=150;
  imgAlt=2;
  mostrarImagem: boolean = false;
  private _filtroLista: string = '';
  public eventosFiltrados: any = [];
 

  public get filtroLista(): string {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.eventosFiltrados=this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;    
  }

  filtrarEventos(filtrarPor: string): any{
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (eventos: any) => eventos.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      eventos.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }
  
  constructor(private http: HttpClient) { }
  ngOnInit(): void { 
    this.getEventos();
  }

  public getEventos(): void {
    this.http.get('https://localhost:7234/api/eventos').subscribe(
      response => {
        this.eventos = response,
        this.eventosFiltrados = this.eventos
      },       
        error => console.log(error)     
    );    
  }

  
  
}
