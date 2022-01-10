/*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
*/

package pe.edu.pucp.pucpsaludable.mantenimiento.model;
import pe.edu.pucp.pucpsaludable.autenticacion.model.Usuario;

public class Administrador extends Usuario{

    // Esta es una clase preexistente, que se encargara de asignar roles
    
    public Administrador(){}
    
    // Métodos

    // Retorna true en caso de éxito o false en caso de error
    public boolean asignarRol(){
        return true;
    }
    // Retorna true en caso de éxito o false en caso de error
    public boolean modificarRol(){
        return true;
    }
    // Retorna true en caso de éxito o false en caso de error
    public boolean eliminarRol(){
        return true;
    }
    // Retorna una cadena con el rol de un usuario
    public String consultarRol(){
        return "";
    }
        
}
