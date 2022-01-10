/*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
*/

package pe.edu.pucp.pucpsaludable.miembroPUCP.model;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.pucpsaludable.autenticacion.model.Usuario;

public class Alumno extends Usuario {

    //atributos del alumno****************
    
    private Especialidad especialidad;
    private double creditosAprobados;
    private int matriculado;
    private String nombreContacto;
    private String parentezcoContacto;
    private String numContacto;
    
    //atributos de salud********************
    //aca iran los arreglos de horas de sueno, rutinas, etc
    private ArrayList<PlanAlimentario> planesAlimentarios;
    
    //constructor**************************
    public Alumno(){
        this.planesAlimentarios = new ArrayList<>();
    }

    public Alumno(String codigoPUCP, String contrasena, String nombres, String apellidos, String emailPUCP, Date fechaNacimiento, 
            char sexo, Especialidad especialidad, int matriculado, String nombreContacto, String parentezcoContacto, String numContacto) {
        super(codigoPUCP, contrasena, nombres, apellidos, emailPUCP, fechaNacimiento, sexo);
        this.especialidad = especialidad;        
        this.matriculado = matriculado;
        this.nombreContacto = nombreContacto;
        this.parentezcoContacto = parentezcoContacto;
        this.numContacto = numContacto;
    }
    
    //set y get****************************

    public Especialidad getEspecialidad() {
        return especialidad;
    }

    public void setEspecialidad(Especialidad especialidad) {
        this.especialidad = especialidad;
    }



    public double getCreditosAprobados() {
        return creditosAprobados;
    }

    public void setCreditosAprobados(double creditosAprobados) {
        this.creditosAprobados = creditosAprobados;
    }

    public int getMatriculado() {
        return matriculado;
    }

    public void setMatriculado(int matriculado) {
        this.matriculado = matriculado;
    }

    public String getNombreContacto() {
        return nombreContacto;
    }

    public void setNombreContacto(String nombreContacto) {
        this.nombreContacto = nombreContacto;
    }

    public String getParentezcoContacto() {
        return parentezcoContacto;
    }

    public void setParentezcoContacto(String parentezcoContacto) {
        this.parentezcoContacto = parentezcoContacto;
    }

    public String getNumContacto() {
        return numContacto;
    }

    public void setNumContacto(String numContacto) {
        this.numContacto = numContacto;
    }

    public ArrayList<PlanAlimentario> getPlanesAlimentarios() {
        return planesAlimentarios;
    }

    public void setPlanesAlimentarios(ArrayList<PlanAlimentario> planesAlimentarios) {
        this.planesAlimentarios = planesAlimentarios;
    }   
    

    
    ///*
    //otros metodos***************************************************
    // Los siguientes metodos retornan 1 si se realizaron correctamente
    public int registrarPreferenciaAlimentaria() {
        return 1;
    }
    
    public int modificarPreferenciaAlimentaria(){
        return 1;
    }
    
    public int eliminarPreferenciaAlimentaria(){
        return 1;
    }
    
    public int consultarPreferenciasAlimentarias(){
        return 1;
    }
    
    public int consultarPlanAlimentario(){
        return 1;
    }
    
    public int generarReportePlanAlimentarioPDF(){
        return 1;
    }
    
    public int generarReporteCitaPDF(){
        return 1;
    }
    //*/
        
        
}
