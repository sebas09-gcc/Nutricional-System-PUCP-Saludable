/*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
*/
package pe.edu.pucp.pucpsaludable.eventos.model;

import java.util.Date;

public class Horario {
    private int id_horario;
    private int id_taller;
    private int fid_especialista;//reservado para el de salud
    private Date horarioInicio;
    private Date horaFin;
    private int diaSemana;
    private Date fechaHoraRegistro;
    private int estado;
    
    public int getEstado(){
        return estado;
        
    }

//    private Especialista especialista;
//    private Taller taller;
    public void setEstado(int estado) {
        this.estado = estado;
    }

    public Horario() {
    }

    public Horario(int id_taller, int fid_especialista, Date horarioInicio, Date horaFin, int diaSemana, Date fechaHoraRegistro, int estado) {
        //this.id_horario = id_horario;
        this.id_taller = id_taller;
        this.fid_especialista = fid_especialista;
        this.horarioInicio = horarioInicio;
        this.horaFin = horaFin;
        this.diaSemana = diaSemana;
        this.fechaHoraRegistro = fechaHoraRegistro;
        this.estado = estado;
    }

    public int getId_horario() {
        return id_horario;
    }

    public void setId_horario(int id_horario) {
        this.id_horario = id_horario;
    }

    public int getId_taller() {
        return id_taller;
    }

    public void setId_taller(int id_taller) {
        this.id_taller = id_taller;
    }

    public int getFid_especialista() {
        return fid_especialista;
    }

    public void setFid_especialista(int fid_especialista) {
        this.fid_especialista = fid_especialista;
    }

    public Date getHorarioInicio() {
        return horarioInicio;
    }

    public void setHorarioInicio(Date horarioInicio) {
        this.horarioInicio = horarioInicio;
    }

    public Date getHoraFin() {
        return horaFin;
    }

    public void setHoraFin(Date horaFin) {
        this.horaFin = horaFin;
    }

    public int getDiaSemana() {
        return diaSemana;
    }

    public void setDiaSemana(int diaSemana) {
        this.diaSemana = diaSemana;
    }

    public Date getFechaHoraRegistro() {
        return fechaHoraRegistro;
    }

    public void setFechaHoraRegistro(Date fechaHoraRegistro) {
        this.fechaHoraRegistro = fechaHoraRegistro;
    }

}
