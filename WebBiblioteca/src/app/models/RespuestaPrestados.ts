import { Data } from "@angular/router";

export interface ResponseObjectPrestados {
    NombreLibro: string;
    NombreEstudiante:  string;
    FechaSolicitud: Data;
    FechaEntrega:Data;
    Dias:number;
}
export interface PeticionPrestados {
    IdLibro:    number;
    IdEstudiante: number;
    FechaSolicitud:   string;
    FechaEntrega:string;
}
