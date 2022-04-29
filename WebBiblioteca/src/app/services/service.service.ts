import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ResponseObject } from '../models/RespuestaGlobal';
import { PeticionPrestados, ResponseObjectPrestados } from '../models/RespuestaPrestados';

@Injectable({
  providedIn: 'root'
})
export class ServiceService {

  constructor(private http: HttpClient) {
    console.log("ServicioListo");
   }
   public url:string="api/";

   getLibros(): Observable<ResponseObject>{
       var service = "Libros/GetLibros"
      return this.http.get<ResponseObject>(this.url+service);
    }

    getEstudiantes(): Observable<ResponseObject>{
      var service = "Estudiantes/GetEstudiantes"
     return this.http.get<ResponseObject>(this.url+service);
   }

   getEstados(): Observable<ResponseObjectPrestados>{
    var service = "EstadosPrestamos/GetEstados"
   return this.http.get<ResponseObjectPrestados>(this.url+service);
   }
   CrearPrestamos(conver:PeticionPrestados){
    var service = "EstadosPrestamos/CrearEstadoPrestamo"
    return this.http.post<string>(this.url+service,conver);
    }
    EditarPrestamo(conver:number){
      var service = "EstadosPrestamos/CrearEstadoPrestamo?EstadoA="+conver
      return this.http.put<string>(this.url+service,conver);
      }
   
}
