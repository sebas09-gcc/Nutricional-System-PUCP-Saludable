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
import java.util.Date;
import pe.edu.pucp.pucpsaludable.autenticacion.model.Usuario;
public class Administrador extends Usuario
{
    private String clavePrivada;
    public Administrador()
    {
    }

    public Administrador(String codigoPUCP, String contrasena, String nombres, String apellidos, 
            String emailPUCP, Date fechaNacimiento, char sexo,
            String clavePrivada)
    {
        super(codigoPUCP, contrasena, nombres, apellidos, emailPUCP, fechaNacimiento, sexo);
        this.clavePrivada = clavePrivada;
    }
    /**
     * @return the clavePrivada
     */
    public String getClavePrivada()
    {
        return clavePrivada;
    }

    /**
     * @param clavePrivada the clavePrivada to set
     */
    public void setClavePrivada(String clavePrivada)
    {
        this.clavePrivada = clavePrivada;
    }
}
