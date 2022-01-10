/*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
*/

package pe.edu.pucp.pucpsaludable.receta.model;

import java.util.ArrayList;

public class PresetReceta {
    private int idPresetReceta;
    private String nombre;
    private double kcal;
    private int estado;
    private int tipo;
    // Constructor
    public PresetReceta(){}

    public PresetReceta(String nombre, int kcal) {
        this.nombre = nombre;
        this.kcal = kcal;
    }
    
    // Setters y getters

    public int getIdPresetReceta() {
        return idPresetReceta;
    }

    public void setIdPresetReceta(int idPresetReceta) {
        this.idPresetReceta = idPresetReceta;
    }
    
    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public double getKcal() {
        return kcal;
    }

    public void setKcal(double kcal) {
        this.kcal = kcal;
    }



    public int isEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }

    public int getTipo() {
        return tipo;
    }

    public void setTipo(int tipo) {
        this.tipo = tipo;
    }
    
    
    
    // Métodos
    
    // Retorna true en caso de éxito o false en caso de error
    public boolean registrarPresetReceta(){
        return true;
    }
    // Retorna true en caso de éxito o false en caso de error
    public boolean modificarPresetReceta(){
        return true;
    }
    // Retorna true en caso de éxito o false en caso de error
    public boolean eliminarPresetReceta(){
        return true;
    }
    // Retorna un arreglo de cadenas con información básica de una receta
    public ArrayList<String> buscarPresetReceta(){
        return new ArrayList<String>();
    }
    // Retorna un arreglo de ingredientes de una receta
    public ArrayList<Ingrediente> consultarPresetReceta(){
        return new ArrayList<Ingrediente>();
    }
    // Retorna true en caso de éxito o false en caso de error
    public boolean vincularIngrediente(){
        return true;
    }
    // Retorna true en caso de éxito o false en caso de error
    public boolean desvincularIngrediente(){
        return true;
    }
}
