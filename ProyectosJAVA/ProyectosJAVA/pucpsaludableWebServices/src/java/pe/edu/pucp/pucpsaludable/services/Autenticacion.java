package pe.edu.pucp.pucpsaludable.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.pucpsaludable.Especialistas.dao.NutricionistaDAO;
import pe.edu.pucp.pucpsaludable.Especialistas.mysql.NutricionistaMySQL;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.AlumnoDAO;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.EspecialidadDAO;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql.AlumnoMySQL;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql.EspecialidadMySQL;
import pe.edu.pucp.pucpsaludable.autenticacion.dao.SesionActivaDAO;
import pe.edu.pucp.pucpsaludable.autenticacion.dao.UsuarioDAO;
import pe.edu.pucp.pucpsaludable.autenticacion.model.SesionActiva;
import pe.edu.pucp.pucpsaludable.autenticacion.mysql.SesionActivaMySQL;
import pe.edu.pucp.pucpsaludable.autenticacion.mysql.UsuarioMySQL;
import pe.edu.pucp.pucpsaludable.especialista.model.Nutricionista;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Alumno;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Especialidad;
import pe.edu.pucp.pucpsaludable.receta.model.Ingrediente;
import pe.edu.pucp.pucpsaludable.recetas.dao.IngredienteDAO;
import pe.edu.pucp.pucpsaludable.recetas.mysql.IngredienteMySQL;

@WebService(serviceName = "authentication")
public class Autenticacion
{
    @WebMethod(operationName = "getSpecialties")
    public ArrayList<Especialidad>  getSpecialties()
    {
        EspecialidadDAO _dao = new EspecialidadMySQL();
        return _dao.listarTodos();
    }

    @WebMethod(operationName = "verifySession")
    public String [] verifySession(@WebParam(name = "sessionID") int sessionID)
    {
        SesionActivaDAO _dao = new SesionActivaMySQL();
        return _dao.verificar(sessionID);
    }
    @WebMethod(operationName = "signIn")
    public String [] signIn(@WebParam(name = "username") String usuario,
            @WebParam(name = "password") String contrasena,
            @WebParam(name = "description") String descripcion)
    {
        SesionActivaDAO _dao = new SesionActivaMySQL();
        return _dao.iniciarSesion(usuario, contrasena, descripcion);
    }
    @WebMethod(operationName = "signOut")
    public void signOut(@WebParam(name = "activeSessionID") int idSesionActiva)
    {
        SesionActivaDAO _dao = new SesionActivaMySQL();
        _dao.eliminar(idSesionActiva);
    }
    @WebMethod(operationName = "sessionsList")
    public ArrayList<SesionActiva> sessionsList(@WebParam(name = "userID") int idUsuario)
    {
        SesionActivaDAO _dao = new SesionActivaMySQL();
        return _dao.listarPorID(idUsuario);
    }
    @WebMethod(operationName = "registerAsStudent")
    public int registerAsStudent(@WebParam(name = "student") Alumno alumno)
    {
        AlumnoDAO _dao = new AlumnoMySQL();
        return _dao.insertar(alumno);
    }
    @WebMethod(operationName = "registerAsNutricionist")
    public int registerAsNutricionist(@WebParam(name = "nutricionist") Nutricionista nutricionista)
    {
        NutricionistaDAO _dao = new NutricionistaMySQL();
        return _dao.insertar(nutricionista);
    }
    @WebMethod(operationName = "verifyRegisteredUser")
    public int verifyRegisteredUser(@WebParam(name = "code") String codigoPUCP)
    {
        UsuarioDAO _dao = new UsuarioMySQL();
        return _dao.verificarRegistro(codigoPUCP);
    }
    @WebMethod(operationName = "changePassword")
    public int changePassword(@WebParam(name = "uid") int uid, @WebParam(name = "password") String contrasena)
    {
        UsuarioDAO _dao = new UsuarioMySQL();
        return _dao.cambiarContrasena(uid, contrasena);
    }

}
