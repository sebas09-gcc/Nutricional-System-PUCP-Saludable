/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.Eventos.mysql;

import java.util.Date;

/**
 *
 * @author sebas
 */
public class CitaRep {
    private int id_cita;
    private String nomAlumno;
    private String apAlumno;
    private String nomEspecialista;
    private String apEspecialista;
    private int atencion;
    private Date fechaHoraRegistro;
    private Date fechaHoraAtencion;
    private String diagnostico;
    private String referencia;

    public CitaRep() {
    }    
    
    public int getId_cita() {
        return id_cita;
    }

    public void setId_cita(int id_cita) {
        this.id_cita = id_cita;
    }

    public int getAtencion() {
        return atencion;
    }

    public void setAtencion(int atencion) {
        this.atencion = atencion;
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

    public String getNomAlumno() {
        return nomAlumno;
    }

    public void setNomAlumno(String nomAlumno) {
        this.nomAlumno = nomAlumno;
    }

    public String getApAlumno() {
        return apAlumno;
    }

    public void setApAlumno(String apAlumno) {
        this.apAlumno = apAlumno;
    }

    public String getNomEspecialista() {
        return nomEspecialista;
    }

    public void setNomEspecialista(String nomEspecialista) {
        this.nomEspecialista = nomEspecialista;
    }

    public String getApEspecialista() {
        return apEspecialista;
    }

    public void setApEspecialista(String apEspecialista) {
        this.apEspecialista = apEspecialista;
    }    
    
}
