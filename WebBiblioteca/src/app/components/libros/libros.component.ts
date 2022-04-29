import { Component, OnInit } from '@angular/core';
import { ResponseObject } from 'src/app/models/RespuestaGlobal';
import { ServiceService } from 'src/app/services/service.service';

@Component({
  selector: 'app-libros',
  templateUrl: './libros.component.html',
  styleUrls: ['./libros.component.css']
})
export class LibrosComponent implements OnInit {
  resultado:any = [];
  constructor(private service:ServiceService) { }

  ngOnInit(): void {
    this.iniciarData();
  }
  iniciarData():void{
    debugger
    this.service.getLibros()
    .subscribe((data:ResponseObject)=>
      {
       console.log(data);
      this.resultado = data;
      setTimeout(() => {
       console.log("Datos cargados")
      }, 2000);
      })
  }
}
