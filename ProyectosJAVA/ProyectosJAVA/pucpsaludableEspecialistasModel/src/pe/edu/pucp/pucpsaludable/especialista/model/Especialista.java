/*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
*/
package pe.edu.pucp.pucpsaludable.especialista.model;

import java.util.Date;
import pe.edu.pucp.pucpsaludable.autenticacion.model.Usuario;


public abstract class Especialista extends Usuario {

    private String biografia;
    private String telefonoLaboral; //obligatorio
    private String direccionLaboral; //obligatorio

    public Especialista() {}

    public Especialista(String codigoPUCP, String contrasena, String nombres, String apellidos, 
            String emailPUCP, Date fechaNacimiento, char sexo,
            String telefonoLaboral, String direccionLaboral) {
        super(codigoPUCP, contrasena, nombres, apellidos, emailPUCP, fechaNacimiento, sexo);
        
        this.telefonoLaboral = telefonoLaboral;
        this.direccionLaboral = direccionLaboral;
    }

    public String getBiografia() {
        return biografia;
    }

    public void setBiografia(String biografia) {
        this.biografia = biografia;
    }

    public String getTelefonoLaboral() {
        return telefonoLaboral;
    }

    public void setTelefonoLaboral(String telefonoLaboral) {
        this.telefonoLaboral = telefonoLaboral;
    }

    public String getDireccionLaboral() {
        return direccionLaboral;
    }

    public void setDireccionLaboral(String direccionLaboral) {
        this.direccionLaboral = direccionLaboral;
    }
    
    
}
