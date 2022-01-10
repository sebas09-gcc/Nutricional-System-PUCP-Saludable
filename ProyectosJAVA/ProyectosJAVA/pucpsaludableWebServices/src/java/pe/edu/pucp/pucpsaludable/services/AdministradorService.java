/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.pucpsaludable.administrador.dao.ReglaDAO;
import pe.edu.pucp.pucpsaludable.administrador.dao.RolDAO;
import pe.edu.pucp.pucpsaludable.administrador.model.Regla;
import pe.edu.pucp.pucpsaludable.administrador.model.Rol;
import pe.edu.pucp.pucpsaludable.administrador.mysql.ReglaMySQL;
import pe.edu.pucp.pucpsaludable.administrador.mysql.RolMySQL;
import pe.edu.pucp.pucpsaludable.autenticacion.dao.UsuarioDAO;
import pe.edu.pucp.pucpsaludable.autenticacion.model.Usuario;
import pe.edu.pucp.pucpsaludable.autenticacion.mysql.UsuarioMySQL;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Alumno;
import pe.edu.pucp.pucpsaludable.especialista.model.Nutricionista;
/**
 *
 * @author angel
 */
@WebService(serviceName = "AdministradorService")
public class AdministradorService
{

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "noWebService")
    public void noWebService(Alumno al, Nutricionista nu)
    {
    }
    @WebMethod(operationName = "insertRule")
    public int insertRule(@WebParam(name = "rule") Regla rule)
    {
        ReglaDAO _dao = new ReglaMySQL();
        return _dao.insertar(rule);
    }

    @WebMethod(operationName = "modifyRule")
    public int modifyRule(@WebParam(name = "rule") Regla rule)
    {
        ReglaDAO _dao = new ReglaMySQL();
        return _dao.modificar(rule);
    }

    @WebMethod(operationName = "deleteRule")
    public int deleteRule(@WebParam(name = "rule") int ruleID)
    {
        ReglaDAO _dao = new ReglaMySQL();
        return _dao.eliminar(ruleID);
    }

    @WebMethod(operationName = "getRules")
    public ArrayList<Regla> getRules()
    {
        ReglaDAO _dao = new ReglaMySQL();
        return _dao.listarTodos();
    }

    @WebMethod(operationName = "insertRole")
    public int insertRole(@WebParam(name = "role") Rol role)
    {
        RolDAO _dao = new RolMySQL();
        return _dao.insertar(role);
    }

    @WebMethod(operationName = "modifyRole")
    public int modifyRole(@WebParam(name = "role") Rol role)
    {
        RolDAO _dao = new RolMySQL();
        return _dao.modificar(role);
    }

    @WebMethod(operationName = "deleteRole")
    public int deleteRole(@WebParam(name = "role") int roleID)
    {
        RolDAO _dao = new RolMySQL();
        return _dao.eliminar(roleID);
    }

    @WebMethod(operationName = "getRoles")
    public ArrayList<Rol> getRoles()
    {
        RolDAO _dao = new RolMySQL();
        return _dao.listarTodos();
    }
    @WebMethod(operationName = "getUsersByStatus")
    public ArrayList<Usuario> getUsersByStatus(@WebParam(name = "name") String name, @WebParam(name = "status") int status)
    {
        UsuarioDAO _dao = new UsuarioMySQL();
        return _dao.listarUsuariosPorEstado(name, status);
    }
    
    @WebMethod(operationName = "changeUserStatus")
    public int changeUserStatus(@WebParam(name = "id") int id, @WebParam(name = "status") int status)
    {
        UsuarioDAO _dao = new UsuarioMySQL();
        return _dao.cambiarEstadoUsuario(id, status);
    }
}
