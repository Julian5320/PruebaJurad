import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { ROUTES } from './app.routes';
import { AppComponent } from './app.component';
import { EstudiantesComponent } from './components/estudiantes/estudiantes.component';
import { LibrosComponent } from './components/libros/libros.component';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { HttpClientModule } from '@angular/common/http';
import { EstadosComponent } from './components/estados/estados.component';
import { CrearPrestamosComponent } from './components/crear-prestamos/crear-prestamos.component';

@NgModule({
  declarations: [
    AppComponent,
    EstudiantesComponent,
    LibrosComponent,
    NavbarComponent,
    EstadosComponent,
    CrearPrestamosComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(ROUTES),
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
