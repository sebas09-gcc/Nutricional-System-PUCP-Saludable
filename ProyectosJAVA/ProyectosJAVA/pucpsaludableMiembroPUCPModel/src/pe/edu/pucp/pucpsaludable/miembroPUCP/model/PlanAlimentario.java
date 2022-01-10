/*
Autor: Marco Bossio Principe
Codigo: 20142886
Fecha: 09/10/2021
Hora: 12:17:28 AM
*/

package pe.edu.pucp.pucpsaludable.miembroPUCP.model;

import java.util.Date;
import pe.edu.pucp.pucpsaludable.receta.model.PresetReceta;


public class PlanAlimentario {
    private Date fecha;
    private int tipoComida;//desa medio alm merien cena
    private PresetReceta comida;
    private Alumno alumno;
    //Nutricionista nutricionista;
    private int fid_Nutricionista;
    //nuevo agregado
    //private String nombrePreset;
    //private int idPreset;
    private int dia;
    public PlanAlimentario() {
    }

    public int getTipoComida()
    {
        return tipoComida;
    }

    public void setTipoComida(int tipoComida)
    {
        this.tipoComida = tipoComida;
    }

    public PresetReceta getComida() {
        return comida;
    }

    public void setComida(PresetReceta comida) {
        this.comida = comida;
    }

    public Alumno getAlumno() {
        return alumno;
    }

    public void setAlumno(Alumno alumno) {
        this.alumno = alumno;
    }

    public int getFid_Nutricionista() {
        return fid_Nutricionista;
    }

    public void setFid_Nutricionista(int fid_Nutricionista) {
        this.fid_Nutricionista = fid_Nutricionista;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }


    public int getDia() {
        return dia;
    }

    public void setDia(int dia) {
        this.dia = dia;
    }
    
    
}
