/*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
*/

package pe.edu.pucp.pucpsaludable.miembroPUCP.model;
import java.util.Date;

public class HorasSuenho {

    private int id_horasSueno;
    private double horas;
    private Date fecha;
    private int fid_alumno;
    
    //constructor
    public HorasSuenho(){}

    public HorasSuenho(double horas, Date fecha) {
        this.horas = horas;
        this.fecha = fecha;
    }
    
    
    //get y set

    public int getId_horasSueno() {
        return id_horasSueno;
    }

    public void setId_horasSueno(int id_horasSueno) {
        this.id_horasSueno = id_horasSueno;
    }    


    public double getHoras() {
        return horas;
    }

    public void setHoras(double horas) {
        this.horas = horas;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public int getFid_alumno() {
        return fid_alumno;
    }

    public void setFid_alumno(int fid_alumno) {
        this.fid_alumno = fid_alumno;
    }
    
    
    
}
