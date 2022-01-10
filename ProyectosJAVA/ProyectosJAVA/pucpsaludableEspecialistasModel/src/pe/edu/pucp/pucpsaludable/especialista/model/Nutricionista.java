/*
Autor: Marco Bossio Principe
Codigo: 20142886
Fecha: 08/10/2021
Hora: 12:17:34 PM
*/

package pe.edu.pucp.pucpsaludable.especialista.model;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.PlanAlimentario;

public class Nutricionista extends EspecialistaSalud{
    
    private ArrayList<PlanAlimentario> planesAlimentarios;

    public Nutricionista() {
        this.planesAlimentarios = new ArrayList<>();
    }

    public Nutricionista(String codigoPUCP, String contrasena, String nombres, String apellidos,
            String emailPUCP, Date fechaNacimiento, char sexo, 
            String telefonoLaboral, String direccionLaboral, 
            String colegiatura) {
        super(codigoPUCP, contrasena, nombres, apellidos, emailPUCP, fechaNacimiento, 
                sexo, telefonoLaboral, direccionLaboral, colegiatura);
    }

    public ArrayList<PlanAlimentario> getPlanesAlimentarios() {
        return planesAlimentarios;
    }

    public void setPlanesAlimentarios(ArrayList<PlanAlimentario> planesAlimentarios) {
        this.planesAlimentarios = planesAlimentarios;
    }     
    
}
