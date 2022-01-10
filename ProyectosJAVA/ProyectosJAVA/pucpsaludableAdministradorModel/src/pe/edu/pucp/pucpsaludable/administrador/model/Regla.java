/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.administrador.model;

/**
 *
 * @author angel
 */
public class Regla
{

    private int id_regla;
    private String nombre;
    private int clave;
    private int tipo;
    private boolean estado;
    public Regla()
    {
    }
    
    public Regla(String nombre, int clave, int tipo)
    {
        this.nombre = nombre;
        this.clave = clave;
        this.tipo = tipo;
        this.estado = true;
    }
    
    /**
     * @return the id_regla
     */
    public int getId_regla()
    {
        return id_regla;
    }

    /**
     * @param id_regla the id_regla to set
     */
    public void setId_regla(int id_regla)
    {
        this.id_regla = id_regla;
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
     * @return the codigo
     */
    public int getClave()
    {
        return clave;
    }

    /**
     * @param codigo the codigo to set
     */
    public void setClave(int clave)
    {
        this.clave = clave;
    }

    /**
     * @return the tipo
     */
    public int getTipo()
    {
        return tipo;
    }

    /**
     * @param tipo the tipo to set
     */
    public void setTipo(int tipo)
    {
        this.tipo = tipo;
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
}
