/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.administrador.model;

import java.util.ArrayList;

/**
 *
 * @author angel
 */
public class Rol
{
    private int id_rol;
    private String nombre;
    private boolean estado;
    private ArrayList<Regla> reglas;
    public Rol()
    {
        reglas = new ArrayList<Regla>();
    }
    
    public Rol(String nombre)
    {
        reglas = new ArrayList<Regla>();
        this.nombre = nombre;
        this.estado = true;
    }
    /**
     * @return the id_rol
     */
    public int getId_rol()
    {
        return id_rol;
    }

    /**
     * @param id_rol the id_rol to set
     */
    public void setId_rol(int id_rol)
    {
        this.id_rol = id_rol;
    }

    /**
     * @return the nombre
     */
    public String getNombre()
    {
        return nombre;
    }

    /**
     * @param nombre the nombre to set
     */
    public void setNombre(String nombre)
    {
        this.nombre = nombre;
    }

    /**
     * @return the estado
     */
    public boolean isEstado()
    {
        return estado;
    }

    /**
     * @param estado the estado to set
     */
    public void setEstado(boolean estado)
    {
        this.estado = estado;
    }
    /**
     * @return the reglas
     */
    public ArrayList<Regla> getReglas()
    {
        return reglas;
    }

    /**
     * @param reglas the reglas to set
     */
    public void setReglas(ArrayList<Regla> reglas)
    {
        this.reglas = reglas;
    }
}
