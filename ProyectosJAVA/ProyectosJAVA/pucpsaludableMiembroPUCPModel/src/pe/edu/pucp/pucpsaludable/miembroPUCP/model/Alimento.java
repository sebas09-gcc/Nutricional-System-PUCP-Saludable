/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.miembroPUCP.model;

/**
 *
 * @author sebas
 */
public class Alimento {
    
    private int fid_alumno;
    private int fid_ingrediente;
    private int preferencia;
    
    //constructor

    public Alimento() {}

    public Alimento(int fid_alumno, int fid_ingrediente, int preferencia) {
        this.fid_alumno = fid_alumno;
        this.fid_ingrediente = fid_ingrediente;
        this.preferencia = preferencia;
    }
    
    //getset 

    public int getFid_alumno() {
        return fid_alumno;
    }

    public void setFid_alumno(int fid_alumno) {
        this.fid_alumno = fid_alumno;
    }

    public int getFid_ingrediente() {
        return fid_ingrediente;
    }

    public void setFid_ingrediente(int fid_ingrediente) {
        this.fid_ingrediente = fid_ingrediente;
    }

    public int getPreferencia() {
        return preferencia;
    }

    public void setPreferencia(int preferencia) {
        this.preferencia = preferencia;
    }
    
    
}
