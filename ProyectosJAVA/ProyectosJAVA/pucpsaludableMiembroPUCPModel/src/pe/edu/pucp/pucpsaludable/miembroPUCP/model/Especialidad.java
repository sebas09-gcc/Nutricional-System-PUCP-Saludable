/*
Autor: Marco Bossio Principe
Codigo: 20142886
Fecha: 29/09/2021
Hora: 01:25:06 AM
*/

package pe.edu.pucp.pucpsaludable.miembroPUCP.model;


public class Especialidad {
    
    private int id_especialidad; 
    private Facultad facultad;
    private String nombreEspecialidad;
    private String descripcionEspecialidad;
    
    public Especialidad(){}

    public Especialidad(String nombreEspecialidad, String descripcionEspecialidad) {
        
        this.nombreEspecialidad = nombreEspecialidad;
        this.descripcionEspecialidad = descripcionEspecialidad;
    }

    public int getId_especialidad() {
        return id_especialidad;
    }

    public void setId_especialidad(int id_especialidad) {
        this.id_especialidad = id_especialidad;
    }

    public Facultad getFacultad() {
        return facultad;
    }

    public void setFacultad(Facultad facultad) {
        this.facultad = facultad;
    }
    
    public String getNombreEspecialidad() {
        return nombreEspecialidad;
    }

    public void setNombreEspecialidad(String nombreEspecialidad) {
        this.nombreEspecialidad = nombreEspecialidad;
    }

    public String getDescripcionEspecialidad() {
        return descripcionEspecialidad;
    }

    public void setDescripcionEspecialidad(String descripcionEspecialidad) {
        this.descripcionEspecialidad = descripcionEspecialidad;
    }  
    
}
