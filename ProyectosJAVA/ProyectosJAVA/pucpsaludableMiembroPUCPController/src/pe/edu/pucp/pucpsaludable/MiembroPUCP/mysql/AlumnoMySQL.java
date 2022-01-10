/*
Autor: Marco Bossio Principe
Codigo: 20142886
Fecha: 28/09/2021
Hora: 10:35:19 PM
*/

package pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.config.DBManager;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.AlumnoDAO;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Alumno;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Especialidad;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Facultad;
import pe.edu.pucp.pucpsaludable.receta.model.Ingrediente;


public class AlumnoMySQL implements AlumnoDAO{
    
    //esto se importa siempre
    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    PreparedStatement ps; //
    CallableStatement cs;
    
    @Override
    public int insertar(Alumno alumno) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            //necesitamos un CALLABLE STATEMENT
            //se implementa para llamar procedimientos almacenados en SQL
            //callableStatement retorna un ResulSet o un boolean
            //SE USA {call ...} y ademas se pone ? por cada parametro sea de entrada o salida
            cs = con.prepareCall("{call INSERTAR_ALUMNO(?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            //preparamos el callable statement
            cs.registerOutParameter("_id_alumno", java.sql.Types.INTEGER);
            cs.setString("_codigoPUCP", alumno.getCodigoPUCP());
            cs.setString("_contrasena", alumno.getContrasena());
            cs.setString("_nombres", alumno.getNombres());
            cs.setString("_apellidos", alumno.getApellidos());
            cs.setString("_emailPUCP", alumno.getEmailPUCP());
            cs.setString("_telefonoMovil", alumno.getTelefonoMovil());
            cs.setDate("_fechaNacimiento",
                    new java.sql.Date(alumno.getFechaNacimiento().getTime()));
            cs.setString("_sexo", String.valueOf(alumno.getSexo()));
            cs.setInt("_fid_especialidad", alumno.getEspecialidad().getId_especialidad());            
            cs.setString("_nombreContacto", alumno.getNombreContacto());
            cs.setString("_parentezcoContacto", alumno.getParentezcoContacto());
            cs.setString("_numContacto", alumno.getNumContacto());
            cs.executeUpdate();
            
            //ahora, hemos obtenido el id autogenerado
            alumno.setId_usuario(cs.getInt("_id_alumno"));
            resultado = 1;
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return resultado; 
    }
    
    

    @Override
    public int modificar(Alumno alumno) {
        
        int resultado = 0;
        try{
            //registramos el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //establecemos la coneccion
            //para ello llamaremos a DBManager,java
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("{call "+
                    "MODIFICAR_ALUMNO(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_usuario", alumno.getId_usuario());
            cs.setString("_codigoPUCP", alumno.getCodigoPUCP());
            cs.setString("_contrasena", alumno.getContrasena());
            cs.setString("_nombres", alumno.getNombres());
            cs.setString("_apellidos", alumno.getApellidos());
            cs.setString("_emailPUCP", alumno.getEmailPUCP());
            cs.setString("_emailPersonal", alumno.getEmailPersonal());
            cs.setString("_telefonoMovil", alumno.getTelefonoMovil());            
            cs.setDate("_fechaNacimiento",new java.sql.Date(alumno.getFechaNacimiento().getTime()));
            cs.setString("_sexo", String.valueOf(alumno.getSexo()));
            cs.setInt("_estado", alumno.getEstado());
            cs.setBytes("_fotoSrc", alumno.getFotoSrc());
            
            cs.setInt("_fid_especialidad", alumno.getEspecialidad().getId_especialidad());            
            cs.setDouble("_creditosAprobados",alumno.getCreditosAprobados());
            cs.setInt("_matriculado", alumno.getMatriculado());
            cs.setString("_nombreContacto", alumno.getNombreContacto());
            cs.setString("_parentezcoContacto", alumno.getParentezcoContacto());
            cs.setString("_numContacto", alumno.getNumContacto());
            
            cs.executeUpdate();
            

            
            //EJECUTAMOS EL PREPARED STATEMENT 
            resultado = 1;
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return resultado;       
        
        
        
        
    }

    @Override
    public int eliminar(int idAlumno) {
        
        int resultado = 0;
        try{
            //registramos el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //establecemos la coneccion
            //para ello llamaremos a DBManager,java
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("{call "+
                    "ELIMINAR_ALUMNO(?)}");
            
            /*
            CREATE PROCEDURE ELIMINAR_ALUMNO(
                IN _id_alumno INT
            )
            BEGIN
                UPDATE usuario SET estado = 0 WHERE _id_alumno = id_usuario;
            END
            */
            
            
            cs.setInt("_id_alumno", idAlumno);
            resultado = cs.executeUpdate();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return resultado;  
    }

    @Override
    public ArrayList<Alumno> listarTodos() {

        int resultado = 0;
        String instruccion;
        ArrayList<Alumno> listaAlumnos = new ArrayList<>();
        
        try{
        
            //establecemos la coneccion
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
                        
            //***************obtener el id persona autogenerado y asignarlo a alumno
            
            //OBTENEMOS EL ID GENERADO PARA AGREGARLO
            
            /*
            CREATE PROCEDURE `LISTAR_ALUMNO`()
            BEGIN
                SELECT * FROM usuario u INNER JOIN alumno a ON
                u.id_usuario = a.id_alumno AND u.estado = 1 INNER JOIN especialidad e ON 
                a.fid_especialidad = e.id_especialidad INNER JOIN facultad f ON
                f.id_facultad = e.fid_facultad;
            END
            */
            
            //cargamos la instruccion a la conexion
            cs = con.prepareCall("{call LISTAR_ALUMNO()}");
            rs = cs.executeQuery();
            
            while(rs.next()){
                Alumno a = new Alumno();
                
                a.setId_usuario(rs.getInt("id_usuario"));
                a.setCodigoPUCP(rs.getString("codigoPUCP"));
                a.setContrasena(rs.getString("contrasena"));
                a.setNombres(rs.getString("nombres"));
                a.setApellidos(rs.getString("apellidos"));
                a.setEmailPUCP(rs.getString("emailPUCP"));
                a.setFechaNacimiento(rs.getDate("fechaNacimiento"));
                a.setSexo(rs.getString("sexo").charAt(0));    
                a.setEstado(rs.getInt("estado"));
                
                a.setMatriculado(rs.getInt("matriculado"));
                a.setNombreContacto(rs.getString("nombreContacto"));
                a.setParentezcoContacto(rs.getString("parentezcoContacto"));
                a.setNumContacto(rs.getString("numContacto"));

                a.setCreditosAprobados(rs.getDouble("creditosAprobados"));
                a.setEmailPersonal(rs.getString("emailPersonal"));                

                Especialidad e = new Especialidad(); //debe existir el constructo vacio de Area
                e.setId_especialidad(rs.getInt("id_especialidad")); //se coloca el nombre de la columna
                e.setNombreEspecialidad(rs.getString("nombreEspecialidad")); //se coloca el nombre de la columna
                e.setDescripcionEspecialidad(rs.getString("descripcionEspecialidad")); //se coloca el nombre de la columna
                
                Facultad f = new Facultad(); //debe existir el constructo vacio de Area
                f.setId_facultad(rs.getInt("id_facultad")); //se coloca el nombre de la columna
                f.setNombreFacultad(rs.getString("nombreFacultad")); //se coloca el nombre de la columna
                f.setDescripcionFacultad(rs.getString("descripcionFacultad")); //se coloca el nombre de la columna
                
                e.setFacultad(f);                
                a.setEspecialidad(e);
                
                listaAlumnos.add(a);
                
            }
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return listaAlumnos;  
    }

    @Override
    public int AgregarAlimento(Alumno alumno, Ingrediente ingrediente, boolean preferencia) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call AGREGAR_ALIMENTO_A_ALUMNO(?,?,?)}");
            //insertar los datos en las variables            
            cs.setInt("_fid_alumno", alumno.getId_usuario());
            cs.setInt("_fid_ingrediente", ingrediente.getIdIngrediente());
            cs.setBoolean("_preferencia", preferencia);
            cs.executeUpdate();
            //ahora, hemos obtenido el id autogenerado
            
            resultado = 1;
            
           
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{ps.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return resultado;
    }

    @Override
    public ArrayList<Alumno> listarPorNombreCodigo(String nombre) {
        ArrayList<Alumno> listaAlumnos = new ArrayList<>();
        try{
        
            //establecemos la coneccion
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
                        

           
            //cargamos la instruccion a la conexion
            cs = con.prepareCall("{call LISTAR_ALUMNO_X_NOMBRECODIGO(?)}");
            cs.setString("_nombre",nombre);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Alumno a = new Alumno();
                
                a.setId_usuario(rs.getInt("id_usuario"));
                a.setCodigoPUCP(rs.getString("codigoPUCP"));
                a.setContrasena(rs.getString("contrasena"));
                a.setNombres(rs.getString("nombres"));
                a.setApellidos(rs.getString("apellidos"));
                a.setEmailPUCP(rs.getString("emailPUCP"));
                a.setFechaNacimiento(rs.getDate("fechaNacimiento"));
                a.setSexo(rs.getString("sexo").charAt(0));    
                a.setEstado(rs.getInt("estado"));
                a.setFotoSrc(rs.getBytes("fotoSrc"));
                a.setMatriculado(rs.getInt("matriculado"));
                a.setNombreContacto(rs.getString("nombreContacto"));
                a.setParentezcoContacto(rs.getString("parentezcoContacto"));
                a.setNumContacto(rs.getString("numContacto"));
                a.setCreditosAprobados(rs.getDouble("creditosAprobados"));
                a.setEmailPersonal(rs.getString("emailPersonal"));
                

                Especialidad e = new Especialidad(); //debe existir el constructo vacio de Area
                e.setId_especialidad(rs.getInt("id_especialidad")); //se coloca el nombre de la columna
                e.setNombreEspecialidad(rs.getString("nombreEspecialidad")); //se coloca el nombre de la columna
                e.setDescripcionEspecialidad(rs.getString("descripcionEspecialidad")); //se coloca el nombre de la columna
                
                Facultad f = new Facultad(); //debe existir el constructo vacio de Area
                f.setId_facultad(rs.getInt("id_facultad")); //se coloca el nombre de la columna
                f.setNombreFacultad(rs.getString("nombreFacultad")); //se coloca el nombre de la columna
                f.setDescripcionFacultad(rs.getString("descripcionFacultad")); //se coloca el nombre de la columna
                
                e.setFacultad(f);                
                a.setEspecialidad(e);
                
                listaAlumnos.add(a);
                
            }
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return listaAlumnos;
    }

    @Override
    public ArrayList<Alumno> listarPorId(int id) {
        ArrayList<Alumno> listaAlumnos = new ArrayList<>();
        try{
        
            //establecemos la coneccion
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
                        

           
            //cargamos la instruccion a la conexion
            cs = con.prepareCall("{call LISTAR_ALUMNO_X_ID(?)}");
            cs.setInt("_id",id);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Alumno a = new Alumno();
                
                a.setId_usuario(rs.getInt("id_usuario"));
                a.setCodigoPUCP(rs.getString("codigoPUCP"));
                a.setContrasena(rs.getString("contrasena"));
                a.setNombres(rs.getString("nombres"));
                a.setApellidos(rs.getString("apellidos"));
                a.setEmailPUCP(rs.getString("emailPUCP"));
                a.setEmailPersonal(rs.getString("emailPersonal"));
                a.setFechaNacimiento(rs.getDate("fechaNacimiento"));
                a.setSexo(rs.getString("sexo").charAt(0));    
                a.setEstado(rs.getInt("estado"));
                a.setFotoSrc(rs.getBytes("fotoSrc"));
                a.setCreditosAprobados(rs.getDouble("creditosAprobados"));
                a.setMatriculado(rs.getInt("matriculado"));
                a.setNombreContacto(rs.getString("nombreContacto"));
                a.setParentezcoContacto(rs.getString("parentezcoContacto"));
                a.setNumContacto(rs.getString("numContacto"));
                

                Especialidad e = new Especialidad(); //debe existir el constructo vacio de Area
                e.setId_especialidad(rs.getInt("id_especialidad")); //se coloca el nombre de la columna
                e.setNombreEspecialidad(rs.getString("nombreEspecialidad")); //se coloca el nombre de la columna
                e.setDescripcionEspecialidad(rs.getString("descripcionEspecialidad")); //se coloca el nombre de la columna
                
                Facultad f = new Facultad(); //debe existir el constructo vacio de Area
                f.setId_facultad(rs.getInt("id_facultad")); //se coloca el nombre de la columna
                f.setNombreFacultad(rs.getString("nombreFacultad")); //se coloca el nombre de la columna
                f.setDescripcionFacultad(rs.getString("descripcionFacultad")); //se coloca el nombre de la columna
                
                e.setFacultad(f);                
                a.setEspecialidad(e);
                
                listaAlumnos.add(a);
                
            }
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return listaAlumnos;
    }


}
