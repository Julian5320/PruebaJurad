import { Component, OnInit } from '@angular/core';
import { ResponseObject } from 'src/app/models/RespuestaGlobal';
import { PeticionPrestados, ResponseObjectPrestados } from 'src/app/models/RespuestaPrestados';
import { ServiceService } from 'src/app/services/service.service';

@Component({
  selector: 'app-crear-prestamos',
  templateUrl: './crear-prestamos.component.html',
  styleUrls: ['./crear-prestamos.component.css']
})
export class CrearPrestamosComponent implements OnInit {

  resultado:any = [];
  resultadoLibros:any = [];
  resultadoEstudiantes:any = [];
  constructor(private service:ServiceService) { }

  ngOnInit(): void {
    this.iniciarDataEstudiantes();
    this.iniciarDataLibros();
  }
  iniciarDataEstudiantes():void{
    debugger
    this.service.getEstudiantes()
    .subscribe((data:ResponseObject)=>
      {
       console.log(data);
      this.resultadoEstudiantes = data;
      setTimeout(() => {
       console.log("Datos cargados")
      }, 2000);
      })
  }
  iniciarDataLibros():void{
    debugger
    this.service.getLibros()
    .subscribe((data:ResponseObject)=>
      {
       console.log(data);
      this.resultadoLibros = data;
      setTimeout(() => {
       console.log("Datos cargados")
      }, 2000);
      })
  }

  consultVal(libro:string,Estudiante:string):void{

    const data = {
      IdLibro: Number(libro),
      IdEstudiante: Number(Estudiante),
      FechaSolicitud: this.ConvertirFecha(),
      FechaEntrega: this.ConvertirFecha()
    };
    if(Estudiante == "" || 1>Number(Estudiante)){
      return alert("Por favor ingresa valores para estudiante")
    }
    if(libro == "" || 1>Number(libro)){
      return alert("Por favor ingresa valores para libro ")
    }
    debugger
   this.service.CrearPrestamos(data)
  .subscribe((data:string)=>
    {
     console.log(data);
    this.resultado = data;
    setTimeout(() => {
     alert(this.resultado);
    }, 2000);
  
    })
    
  }
  ConvertirFecha():string{
    var today = new Date();
    var dd = String(today.getDate()).padStart(2, '0');
    var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
    var yyyy = today.getFullYear();

    return mm + '/' + dd + '/' + yyyy;
  }
}
