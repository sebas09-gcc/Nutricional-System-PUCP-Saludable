/*
Autor: Marco Bossio Principe
Codigo: 20142886
Fecha: 29/09/2021
Hora: 01:21:17 AM
*/

package pe.edu.pucp.pucpsaludable.miembroPUCP.model;


public class Facultad {

    private int id_facultad;
    private String nombreFacultad;
    private String descripcionFacultad;

    public Facultad() {}

    public Facultad(String nombreFacultad, String descripcionFacultad) {
        
        this.nombreFacultad = nombreFacultad;
        this.descripcionFacultad = descripcionFacultad;        
    }

    public int getId_facultad() {
        return id_facultad;
    }

    public void setId_facultad(int id_facultad) {
        this.id_facultad = id_facultad;
    }

    public String getNombreFacultad() {
        return nombreFacultad;
    }

    public void setNombreFacultad(String nombreFacultad) {
        this.nombreFacultad = nombreFacultad;
    }

    public String getDescripcionFacultad() {
        return descripcionFacultad;
    }

    public void setDescripcionFacultad(String descripcionFacultad) {
        this.descripcionFacultad = descripcionFacultad;
    }

    
}
