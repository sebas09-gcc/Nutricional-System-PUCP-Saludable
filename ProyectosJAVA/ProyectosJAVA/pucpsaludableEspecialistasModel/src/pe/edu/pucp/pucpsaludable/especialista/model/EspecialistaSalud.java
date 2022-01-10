/*
Autor: Marco Bossio Principe
Codigo: 20142886
Fecha: 08/10/2021
Hora: 12:17:16 PM
*/

package pe.edu.pucp.pucpsaludable.especialista.model;

import java.util.ArrayList;
import java.util.Date;


public abstract class EspecialistaSalud extends Especialista{

    private String colegiatura;

    
    

    public EspecialistaSalud() {
      
    }

    public EspecialistaSalud(String codigoPUCP, String contrasena, String nombres, String apellidos, 
            String emailPUCP, Date fechaNacimiento, char sexo, 
            String telefonoLaboral, String direccionLaboral, String colegiatura) {
        
        super(codigoPUCP, contrasena, nombres, apellidos, emailPUCP, fechaNacimiento, 
                sexo, telefonoLaboral, direccionLaboral);

        this.colegiatura = colegiatura;
    }

    public String getColegiatura() {
        return colegiatura;
    }

    public void setColegiatura(String colegiatura) {
        this.colegiatura = colegiatura;
    }  
      
    
    
}
