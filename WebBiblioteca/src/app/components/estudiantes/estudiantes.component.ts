import { Component, OnInit } from '@angular/core';
import { ResponseObject } from 'src/app/models/RespuestaGlobal';
import { ServiceService } from 'src/app/services/service.service';

@Component({
  selector: 'app-estudiantes',
  templateUrl: './estudiantes.component.html',
  styleUrls: ['./estudiantes.component.css']
})
export class EstudiantesComponent implements OnInit {

  resultado:any = [];
  constructor(private service:ServiceService) { }

  ngOnInit(): void {
    this.iniciarData();
  }
  iniciarData():void{
    debugger
    this.service.getEstudiantes()
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
