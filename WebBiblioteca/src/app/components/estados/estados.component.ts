import { Component, OnInit } from '@angular/core';
import { ResponseObjectPrestados } from 'src/app/models/RespuestaPrestados';
import { ServiceService } from 'src/app/services/service.service';

@Component({
  selector: 'app-estados',
  templateUrl: './estados.component.html',
  styleUrls: ['./estados.component.css']
})
export class EstadosComponent implements OnInit {

  resultado:any = [];
  constructor(private service:ServiceService) { }

  ngOnInit(): void {
    this.iniciarData();
  }
  iniciarData():void{
    debugger
    this.service.getEstados()
    .subscribe((data:ResponseObjectPrestados)=>
      {
       console.log(data);
      this.resultado = data;
      setTimeout(() => {
       console.log("Datos cargados")
      }, 2000);
      })
  }
  actualizarData(num:number): void{
    this.service.EditarPrestamo(num)
    .subscribe((data:string)=>
      {
       console.log(data);
      this.resultado = data;
      setTimeout(() => {
       alert(this.resultado);
      }, 2000);
    
      })
  }
  
}