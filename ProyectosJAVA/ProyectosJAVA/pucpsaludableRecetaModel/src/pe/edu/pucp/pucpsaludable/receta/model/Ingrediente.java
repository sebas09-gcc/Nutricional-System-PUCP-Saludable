/*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
*/

package pe.edu.pucp.pucpsaludable.receta.model;

import java.util.ArrayList;

public class Ingrediente{
    
    private int idIngrediente;
    private  String nombre;
    //private int  tipoAlimento;
    //nuevos
    private String unidad;
    private double cantidad;
    
    private int  kcal;
    private  boolean grasasSaturadas;
    private  boolean azucar;
    private boolean  sodio;
    private  boolean grasasTrans;
    private boolean estado;
    
    private String detalle; //aqui se modifica para listar lo del plan
    // Constructor
    public Ingrediente(){}

    public Ingrediente(String nombre,String unidad,double cantidad, int kcal, boolean grasasSaturadas, boolean azucar, boolean sodio, boolean grasasTrans) {
        this.idIngrediente=-1;
        this.nombre = nombre;
        //this.tipoAlimento = tipoAlimento;
        //nuevo
        this.unidad = unidad;
        this.cantidad = cantidad;
        
        this.kcal = kcal;
        this.grasasSaturadas = grasasSaturadas;
        this.azucar = azucar;
        this.sodio = sodio;
        this.grasasTrans = grasasTrans;
        this.detalle= " ";
    }
    
    // Setters y getters

    public int getIdIngrediente() {
        return idIngrediente;
    }

    public void setIdIngrediente(int idIngrediente) {
        this.idIngrediente = idIngrediente;
    }
    
    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getUnidad() {
        return unidad;
    }

    public void setUnidad(String unidad) {
        this.unidad = unidad;
    }

    public double getCantidad() {
        return cantidad;
    }

    public void setCantidad(double cantidad) {
        this.cantidad = cantidad;
    }

    
    public int getKcal() {
        return kcal;
    }

    public void setKcal(int kcal) {
        this.kcal = kcal;
    }

    public boolean isGrasasSaturadas() {
        return grasasSaturadas;
    }

    public void setGrasasSaturadas(boolean grasasSaturadas) {
        this.grasasSaturadas = grasasSaturadas;
    }

    public boolean isAzucar() {
        return azucar;
    }

    public void setAzucar(boolean azucar) {
        this.azucar = azucar;
    }

    public boolean isSodio() {
        return sodio;
    }

    public void setSodio(boolean sodio) {
        this.sodio = sodio;
    }

    public boolean isGrasasTrans() {
        return grasasTrans;
    }

    public void setGrasasTrans(boolean grasasTrans) {
        this.grasasTrans = grasasTrans;
    }

    public boolean isEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }

    public String getDetalle() {
        return detalle;
    }

    public void setDetalle(String detalle) {
        this.detalle = detalle;
    }
    
    
    // Métodos
    
    // Retorna true en caso de éxito o false en caso de error
    public boolean registrarIngrediente(){
        return true;
    }
    // Retorna true en caso de éxito o false en caso de error
    public boolean modificarIngrediente(){
        return true;
    }
    // Retorna true en caso de éxito o false en caso de error
    public boolean eliminarIngrediente(){
        return true;
    }
    // Retorna un arreglo de cadenas con información básica de un ingrediente
    public ArrayList<String> buscarIngrediente(){
        return new ArrayList<String>();
    }
    // Retorna un arreglo de cadenas con información detallada de un ingrediente
    public ArrayList<String> consultarIngrediente(){
        return new ArrayList<String>();
    }    
    
    
}
