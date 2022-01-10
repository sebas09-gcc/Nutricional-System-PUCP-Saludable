/*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
*/

package pe.edu.pucp.pucpsaludable.eventos.model;

import java.util.Date;

public class Cita {
    private int id_cita;
    private int fid_alumno;
    private int fid_especialista;
    private int estado;
    private int atencion;
    private Date fechaHoraRegistro;
    private Date fechaHoraAtencion;
    private String diagnostico;
    private String referencia;

    public int getAtencion() {
        return atencion;
    }

    public void setAtencion(int atencion) {
        this.atencion = atencion;
    }
    
    public Cita(){
        
    }

    public Cita(int fid_alumno, int fid_especialista, int estado, int atencion, Date fechaHoraRegistro, Date fechaHoraAtencion, String diagnostico, String referencia) {
        //this.id_cita = id_cita;
        this.fid_alumno = fid_alumno;
        this.fid_especialista = fid_especialista;
        this.estado = estado;
        this.atencion = atencion;
        this.fechaHoraRegistro = fechaHoraRegistro;
        this.fechaHoraAtencion = fechaHoraAtencion;
        this.diagnostico = diagnostico;
        this.referencia = referencia;
    }

    public int getId_cita() {
        return id_cita;
    }

    public void setId_cita(int id_cita) {
        this.id_cita = id_cita;
    }

    public int getFid_alumno() {
        return fid_alumno;
    }

    public void setFid_alumno(int fid_alumno) {
        this.fid_alumno = fid_alumno;
    }

    public int getFid_especialista() {
        return fid_especialista;
    }

    public void setFid_especialista(int fid_especialista) {
        this.fid_especialista = fid_especialista;
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }

    public Date getFechaHoraRegistro() {
        return fechaHoraRegistro;
    }

    public void setFechaHoraRegistro(Date fechaHoraRegistro) {
        this.fechaHoraRegistro = fechaHoraRegistro;
    }

    public Date getFechaHoraAtencion() {
        return fechaHoraAtencion;
    }

    public void setFechaHoraAtencion(Date fechaHoraAtencion) {
        this.fechaHoraAtencion = fechaHoraAtencion;
    }

    public String getDiagnostico() {
        return diagnostico;
    }

    public void setDiagnostico(String diagnostico) {
        this.diagnostico = diagnostico;
    }

    public String getReferencia() {
        return referencia;
    }

    public void setReferencia(String referencia) {
        this.referencia = referencia;
    }
 
}
