/*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
*/

package pe.edu.pucp.pucpsaludable.receta.model;

import java.util.ArrayList;

public class Receta {    
    private int idReceta;
    private String nombre;
    private String descripcion;
    private String indicaciones;
    private int tipo;
    private boolean estado;
    //constructo
    public Receta(){}

    public Receta(String nombre, String descripcion, String indicaciones,int tipo) {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.indicaciones = indicaciones;
        this.tipo = tipo;
    }
    
    public int getIdReceta() {    
        return idReceta;
    }

    // Setters y getters
    public void setIdReceta(int idReceta) {    
        this.idReceta = idReceta;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public String getIndicaciones() {
        return indicaciones;
    }

    public void setIndicaciones(String indicaciones) {
        this.indicaciones = indicaciones;
    }    

    public boolean isEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }

    
    // Métodos

    // Retorna true en caso de éxito o false en caso de error
    public boolean registrarReceta(){
        return true;
    }
    // Retorna true en caso de éxito o false en caso de error
    public boolean modificarReceta(){
        return true;
    }
    // Retorna true en caso de éxito o false en caso de error
    public boolean eliminarReceta(){
        return true;
    }
    // Retorna un arreglo con los detalles de una receta (nombre, descripción,...)
    public ArrayList<String> buscarReceta(){
        return new ArrayList<String>();
    }

    public int getTipo() {
        return tipo;
    }

    public void setTipo(int tipo) {
        this.tipo = tipo;
    }
    
    
}
