/*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
*/
package pe.edu.pucp.pucpsaludable.miembroPUCP.model;

import java.util.Date;


public class HorarioHabitual {

    private int fid_alumno;
    private Date despertarse;
    private Date acostarse;
    private Date desayuno;
    private Date mediaManana;
    private Date comida;
    private Date merienda;
    private Date cena;    
    
    //constructor
    public HorarioHabitual(){}

    public HorarioHabitual(int fid_alumno, Date despertarse, Date acostarse, Date desayuno, Date mediaManana, Date comida, Date merienda, Date cena) {
        this.fid_alumno = fid_alumno;
        this.despertarse = despertarse;
        this.acostarse = acostarse;
        this.desayuno = desayuno;
        this.mediaManana = mediaManana;
        this.comida = comida;
        this.merienda = merienda;
        this.cena = cena;
    }

    
    
    public int getFid_alumno() {
        return fid_alumno;
    }

    //set y get
    public void setFid_alumno(int fid_alumno) {
        this.fid_alumno = fid_alumno;
    }

    public Date getDespertarse() {
        return despertarse;
    }

    public void setDespertarse(Date despertarse) {
        this.despertarse = despertarse;
    }

    public Date getAcostarse() {
        return acostarse;
    }

    public void setAcostarse(Date acostarse) {
        this.acostarse = acostarse;
    }

    public Date getDesayuno() {
        return desayuno;
    }

    public void setDesayuno(Date desayuno) {
        this.desayuno = desayuno;
    }

    public Date getMediaManana() {
        return mediaManana;
    }

    public void setMediaManana(Date mediaManana) {
        this.mediaManana = mediaManana;
    }

    public Date getComida() {
        return comida;
    }

    public void setComida(Date comida) {
        this.comida = comida;
    }

    public Date getMerienda() {
        return merienda;
    }

    public void setMerienda(Date merienda) {
        this.merienda = merienda;
    }

    public Date getCena() {
        return cena;
    }

    public void setCena(Date cena) {
        this.cena = cena;
    }

    
    
    
    // Los siguientes metodos retornan 1 si se realizaron correctamente
    public int registrarHorarioHabitual(){
        return 1;
    }
    public int modificarHorarioHabitual(){
        return 1;
    }
    public int consultarHorarioHabitual(){
        return 1;
    }
    
}
