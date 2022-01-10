/*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
*/

package pe.edu.pucp.pucpsaludable.miembroPUCP.model;
import java.util.Date;

public class CumplimientoRutina {
    
    private int id_cumplimientoRutina;
    private int fid_alumno;
    private int fid_taller;
    private Date fecha;
    private int cumplio;
    private int tipoRutina;
    private int tipoComida;
    private String nombreReceta; 
    private int dia;
        
    
    //constructor
    public CumplimientoRutina(){}
   
    //set y get

    public int getId_cumplimientoRutina() {
        return id_cumplimientoRutina;
    }

    public void setId_cumplimientoRutina(int id_cumplimientoRutina) {
        this.id_cumplimientoRutina = id_cumplimientoRutina;
    }

    public int getFid_alumno() {
        return fid_alumno;
    }

    public void setFid_alumno(int fid_alumno) {
        this.fid_alumno = fid_alumno;
    }
    
    



    public int getFid_taller() {
        return fid_taller;
    }

    public void setFid_taller(int fid_taller) {
        this.fid_taller = fid_taller;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public int getCumplio() {
        return cumplio;
    }

    public void setCumplio(int cumplio) {
        this.cumplio = cumplio;
    }



    public int getTipoRutina() {
        return tipoRutina;
    }

    public void setTipoRutina(int tipoRutina) {
        this.tipoRutina = tipoRutina;
    }

    public int getTipoComida() {
        return tipoComida;
    }

    public void setTipoComida(int tipoComida) {
        this.tipoComida = tipoComida;
    }

    public String getNombreReceta() {
        return nombreReceta;
    }

    public void setNombreReceta(String nombreReceta) {
        this.nombreReceta = nombreReceta;
    }   

    public int getDia() {
        return dia;
    }

    public void setDia(int dia) {
        this.dia = dia;
    }
    

    
    
}
