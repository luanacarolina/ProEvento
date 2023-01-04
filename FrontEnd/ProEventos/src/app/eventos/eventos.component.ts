import { Component, OnInit } from '@angular/core';
import { Evento } from '../eventos/Evento';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {
public eventos: any

  constructor(private httpClient:HttpClient) { }

  ngOnInit(): void {
    console.log(this.getEventos());
  }
getEventos(){
 return this.httpClient.get('https://localhost:5001/Evento').subscribe(
    response => console.log(this.eventos = response),
    error => console.log(error)
    );

}

}
