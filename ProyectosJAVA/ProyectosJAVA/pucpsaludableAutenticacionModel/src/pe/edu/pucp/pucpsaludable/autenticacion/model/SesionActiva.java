/*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
*/
package pe.edu.pucp.pucpsaludable.autenticacion.model;
import java.util.ArrayList;
import java.util.Date;

public class SesionActiva {

    private int id;
    private int idUsuario;
    private String descripcion;
    private Date fechaInicio;
    private boolean valida;
    
    // Constructor

    public SesionActiva(){}
    
    public SesionActiva(int idUsuario, String descripcion, Date fechaInicio) {
        this.idUsuario = idUsuario;
        this.descripcion = descripcion;
        this.fechaInicio = fechaInicio;
        this.valida = true;
    }
    
    // Setters y getters

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getIdUsuario() {
        return idUsuario;
    }

    public void setIdUsuario(int idUsuario) {
        this.idUsuario = idUsuario;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public Date getFechaInicio() {
        return fechaInicio;
    }

    public void setFechaInicio(Date fechaInicio) {
        this.fechaInicio = fechaInicio;
    }

    public boolean getValida() {
        return valida;
    }

    public void setValida(boolean valida) {
        this.valida = valida;
    }
    
    // Métodos de la clase

    // Retorna true en caso de establecimiento de sesión exitoso o false en caso de error
    public boolean establecerSesion(){
        return true;
    }
    // Retorna true en caso de desconexión exitosa o false en caso de error
    public boolean desconectarSesion(){
        return true;
    }
    // Retorna una lista de cadenas con información sobre cada sesión activa de un usuario
    public ArrayList<String> consultarSesionesActivas(){
        return new ArrayList<String>();
    }
}
