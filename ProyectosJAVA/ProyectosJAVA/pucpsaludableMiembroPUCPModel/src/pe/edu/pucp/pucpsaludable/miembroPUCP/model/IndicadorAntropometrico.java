    /*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
*/

package pe.edu.pucp.pucpsaludable.miembroPUCP.model;
import java.util.Date;

public class IndicadorAntropometrico {
    private int id_indicadorAntropometrico;
    private double pesoHabitual;
    private double estatura;
    private double circunferenciaBrazo;
    private double circunferenciaCintura;
    private double circunferenciaCadera;
    private double circunferenciaAbdominal;
    private Date fechaRegistro;
    private int fid_alumno;
        
    //constructor
    public IndicadorAntropometrico(){}

    public IndicadorAntropometrico(double pesoHabitual, double estatura, double circunferenciaBrazo, double circunferenciaCintura, double circunferenciaCadera, double circunferenciaAbdominal, Date fechaRegistro,int fid_alumno) {
        this.pesoHabitual = pesoHabitual;
        this.estatura = estatura;
        this.circunferenciaBrazo = circunferenciaBrazo;
        this.circunferenciaCintura = circunferenciaCintura;
        this.circunferenciaCadera = circunferenciaCadera;
        this.circunferenciaAbdominal = circunferenciaAbdominal;
        this.fechaRegistro = fechaRegistro;
        this.fid_alumno = fid_alumno;
    }
    
    //set y get

    public int getId_indicadorAntropometrico() {
        return id_indicadorAntropometrico;
    }

    public void setId_indicadorAntropometrico(int id_indicadorAntropometrico) {
        this.id_indicadorAntropometrico = id_indicadorAntropometrico;
    }
    
    

    public double getPesoHabitual() {
        return pesoHabitual;
    }

    public void setPesoHabitual(double pesoHabitual) {
        this.pesoHabitual = pesoHabitual;
    }

    public double getEstatura() {
        return estatura;
    }

    public void setEstatura(double estatura) {
        this.estatura = estatura;
    }

    public double getCircunferenciaBrazo() {
        return circunferenciaBrazo;
    }

    public void setCircunferenciaBrazo(double circunferenciaBrazo) {
        this.circunferenciaBrazo = circunferenciaBrazo;
    }

    public double getCircunferenciaCintura() {
        return circunferenciaCintura;
    }

    public void setCircunferenciaCintura(double circunferenciaCintura) {
        this.circunferenciaCintura = circunferenciaCintura;
    }

    public double getCircunferenciaCadera() {
        return circunferenciaCadera;
    }

    public void setCircunferenciaCadera(double circunferenciaCadera) {
        this.circunferenciaCadera = circunferenciaCadera;
    }

    public double getCircunferenciaAbdominal() {
        return circunferenciaAbdominal;
    }

    public void setCircunferenciaAbdominal(double circunferenciaAbdominal) {
        this.circunferenciaAbdominal = circunferenciaAbdominal;
    }

    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }

    public int getFid_alumno() {
        return fid_alumno;
    }

    public void setFid_alumno(int fid_alumno) {
        this.fid_alumno = fid_alumno;
    }


    
    
}
