/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.miembroPUCP.model;

import java.util.Date;

/**
 *
 * @author sebas
 */
public class Constancia {
    private int fid_alumno;
    private Date fechaRegistro;
    private byte[] archivoConstancia;
    private int estado;

    public Constancia() {
    }

    public Constancia(int fid_alumno, Date fechaRegistro, byte[] archivoConstancia, int estado) {
        this.fid_alumno = fid_alumno;
        this.fechaRegistro = fechaRegistro;
        this.archivoConstancia = archivoConstancia;
        this.estado = estado;
    }
    
    public int getFid_alumno() {
        return fid_alumno;
    }

    public void setFid_alumno(int fid_alumno) {
        this.fid_alumno = fid_alumno;
    }

    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }

    public byte[] getArchivoConstancia() {
        return archivoConstancia;
    }

    public void setArchivoConstancia(byte[] archivoConstancia) {
        this.archivoConstancia = archivoConstancia;
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }
    
    
    
    
    
}
