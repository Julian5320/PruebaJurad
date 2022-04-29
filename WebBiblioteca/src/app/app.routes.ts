import { Routes } from "@angular/router";
import { CrearPrestamosComponent } from "./components/crear-prestamos/crear-prestamos.component";
import { EstadosComponent } from "./components/estados/estados.component";
import { EstudiantesComponent } from "./components/estudiantes/estudiantes.component";
import { LibrosComponent } from "./components/libros/libros.component";


export const ROUTES: Routes=[
    {path: 'Estudiantes', component:EstudiantesComponent},
    {path: 'Libros', component:LibrosComponent},
    {path: 'Estados', component:EstadosComponent},
    {path: 'Prestamos', component:CrearPrestamosComponent},

    {path:'**', pathMatch:'full', redirectTo:'Libros'}
]