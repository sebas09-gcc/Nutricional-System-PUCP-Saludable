/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.Especialistas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.Especialistas.config.DBManager;

import pe.edu.pucp.pucpsaludable.Especialistas.dao.NutricionistaDAO;

import pe.edu.pucp.pucpsaludable.especialista.model.Nutricionista;


public class NutricionistaMySQL implements NutricionistaDAO {
    Connection con;
    Statement st;
    ResultSet rs;
    PreparedStatement ps;
    CallableStatement cs;
    
    @Override
    public int insertar(Nutricionista nutricionista){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            //necesitamos un CALLABLE STATEMENT
            //se implementa para llamar procedimientos almacenados en SQL
            //callableStatement retorna un ResulSet o un boolean
            //SE USA {call ...} y ademas se pone ? por cada parametro sea de entrada o salida
            cs = con.prepareCall("{call INSERTAR_NUTRICIONISTA(?,?,?,?,?,?,?,?,?,?)}");
            //preparamos el callable statement
            cs.registerOutParameter("_id_nutricionista", java.sql.Types.INTEGER);
            cs.setString("_codigoPUCP", nutricionista.getCodigoPUCP());
            cs.setString("_contrasena", nutricionista.getContrasena());
            cs.setString("_nombres", nutricionista.getNombres());
            cs.setString("_apellidos", nutricionista.getApellidos());
            cs.setString("_emailPUCP", nutricionista.getEmailPUCP());            
            cs.setDate("_fechaNacimiento", 
                    new java.sql.Date(nutricionista.getFechaNacimiento().getTime()));
            cs.setString("_sexo", String.valueOf(nutricionista.getSexo()));
            cs.setString("_telefonoLaboral", nutricionista.getTelefonoLaboral());
            cs.setString("_colegiatura", nutricionista.getColegiatura());
            cs.executeUpdate();
            
            //ahora, hemos obtenido el id autogenerado
            nutricionista.setId_usuario(cs.getInt("_id_nutricionista"));
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
    public int modificar(Nutricionista nutricionista){
        int resultado = 0;
        try{
            //registramos el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //establecemos la coneccion
            //para ello llamaremos a DBManager,java
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("{call "+
                    "MODIFICAR_NUTRICIONISTA(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            
            /*
            
                       
            DELIMITER $
            CREATE PROCEDURE `MODIFICAR_NUTRICIONISTA`(
                IN _id_usuario INT,
                IN _codigoPUCP VARCHAR(8),
                IN _contrasena VARCHAR(25),
                IN _nombres VARCHAR(40),                
                IN _apellidos VARCHAR(40),
                IN _emailPUCP VARCHAR(256),                             
                IN _emailPersonal VARCHAR(256),    
                IN _telefonoMovil VARCHAR(9),                 
                IN _fechaNacimiento DATE,    
                IN _fotoSrc BLOB,
                IN _sexo CHAR(1),
                IN _estado TINYINT,            
                
                IN _biografia TINYTEXT,
                IN _telefonoLaboral VARCHAR(9),                
                IN _direccionLaboral VARCHAR(100),   
            
                IN _colegiatura VARCHAR(45)
            )
            BEGIN
                UPDATE usuario
                    SET codigoPUCP = _codigoPUCP,
                    contrasena = _contrasena,
                    nombres= _nombres,
                    apellidos = _apellidos,
                    emailPUCP = _emailPUCP,
                    emailPersonal = _emailPersonal,
                    telefonoMovil = _telefonoMovil,
                    fechaNacimiento = _fechaNacimiento,
                    fotoSrc = _fotoSrc,
                    sexo = _sexo,
                    estado = _estado
                    WHERE id_usuario = _id_usuario;
                UPDATE especialista
                    SET biografia= _biografia,
                    telefonoLaboral= _telefonoLaboral,
                    direccionLaboral= _direccionLaboral                    
                    WHERE id_especialista = _id_usuario;
                UPDATE especialistaSalud
                    SET colegiatura = _colegiatura
                    WHERE id_especialistaSalud = _id_usuario;

            END$           
            */
            
            
            
            cs.setInt("_id_usuario", nutricionista.getId_usuario());
            
            cs.setString("_codigoPUCP", nutricionista.getCodigoPUCP());
            cs.setString("_contrasena", nutricionista.getContrasena());
            cs.setString("_nombres", nutricionista.getNombres());
            cs.setString("_apellidos", nutricionista.getApellidos());
            cs.setString("_emailPUCP", nutricionista.getEmailPUCP());
            cs.setString("_emailPersonal", nutricionista.getEmailPersonal());
            cs.setString("_telefonoMovil", nutricionista.getTelefonoMovil());            
            cs.setDate("_fechaNacimiento", 
                new java.sql.Date(nutricionista.getFechaNacimiento().getTime()));
            cs.setBytes("_fotoSrc", nutricionista.getFotoSrc());
            cs.setString("_sexo", String.valueOf(nutricionista.getSexo()));
            cs.setInt("_estado", 1);
                                    
            cs.setString("_biografia", nutricionista.getBiografia());
            cs.setString("_telefonoLaboral", nutricionista.getTelefonoLaboral());
            cs.setString("_direccionLaboral", nutricionista.getDireccionLaboral());
            
            cs.setString("_colegiatura", nutricionista.getColegiatura());  
            
            cs.executeUpdate();

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
    public int eliminar(int id_nutricionista){
        int resultado = 0;
        try{
            //registramos el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //establecemos la coneccion
            //para ello llamaremos a DBManager,java
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("{call "+
                    "ELIMINAR_NUTRICIONISTA(?)}");
            
            /*
            CREATE PROCEDURE `ELIMINAR_NUTRICIONISTA`(
                IN _id_nutricionista INT
            )
            BEGIN
                UPDATE usuario SET estado = 0 WHERE _id_nutricionista = id_usuario;
            END
            */            
            
            cs.setInt("_id_nutricionista", id_nutricionista);
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
    public ArrayList<Nutricionista> listarTodos() {
        
        int resultado = 0;
       
        ArrayList<Nutricionista> nutricionistas = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            
            cs = con.prepareCall("{call LISTAR_NUTRICIONISTA()}");
            
            /*
            CREATE PROCEDURE `LISTAR_NUTRICIONISTA`()
            BEGIN
                SELECT * FROM usuario u INNER JOIN especialista e ON
                u.id_usuario = e.id_especialista and u.estado = 1 INNER JOIN especialistaSalud es ON
                e.id_especialista = es.id_especialistaSalud INNER JOIN nutricionista n ON
                es.id_especialistaSalud = n.id_nutricionista;
            END
            */
                    
            
            //cargamos la instruccion a la conexion
            rs = cs.executeQuery();
            
            /*
                IN _id_usuario INT,
                IN _codigoPUCP VARCHAR(8),
                IN _contrasena VARCHAR(25),
                IN _nombres VARCHAR(40),                
                IN _apellidos VARCHAR(40),
                IN _emailPUCP VARCHAR(256),                             
                IN _emailPersonal VARCHAR(256),    
                IN _telefonoMovil VARCHAR(9),                 
                IN _fechaNacimiento DATE,    
                IN _fotoSrc BLOB,
                IN _sexo CHAR(1),
                IN _estado TINYINT,            
                
                IN _biografia TINYTEXT,
                IN _telefonoLaboral VARCHAR(9),                
                IN _direccionLaboral VARCHAR(100),   
            
                IN _colegiatura VARCHAR(45)
            
            */
            
            
            
            while(rs.next()){
                Nutricionista nut = new Nutricionista();
                
                nut.setId_usuario(rs.getInt("id_usuario"));
                nut.setCodigoPUCP(rs.getString("codigoPUCP"));
                nut.setContrasena(rs.getString("contrasena"));
                nut.setNombres(rs.getString("nombres"));
                nut.setApellidos(rs.getString("apellidos"));
                nut.setEmailPUCP(rs.getString("emailPUCP"));
                nut.setEmailPersonal(rs.getString("emailPersonal"));
                nut.setTelefonoMovil(rs.getString("telefonoMovil"));
                nut.setFechaNacimiento(rs.getDate("fechaNacimiento"));
                
                nut.setFotoSrc(rs.getBytes("fotoSrc"));
                
                nut.setSexo(rs.getString("sexo").charAt(0)); 
                nut.setEstado(rs.getInt("estado"));
                
                nut.setBiografia(rs.getString("biografia"));
                nut.setTelefonoLaboral(rs.getString("telefonoLaboral"));
                nut.setDireccionLaboral(rs.getString("direccionLaboral"));
                
                nut.setColegiatura(rs.getString("colegiatura"));
                

                
                nutricionistas.add(nut);
            }
            
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return nutricionistas;

    }

    @Override
    public ArrayList<Nutricionista> listarxId(int id) {
       int resultado = 0;
       
        ArrayList<Nutricionista> nutricionistas = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            
            cs = con.prepareCall("{call LISTAR_NUTRICIONISTA_POR_ID(?)}");
            cs.setInt("id_nutricionista",id);
            //cargamos la instruccion a la conexion
            rs = cs.executeQuery();
            while(rs.next()){
                Nutricionista nut = new Nutricionista();
                
                nut.setId_usuario(rs.getInt("id_usuario"));
                nut.setCodigoPUCP(rs.getString("codigoPUCP"));
                nut.setContrasena(rs.getString("contrasena"));
                nut.setNombres(rs.getString("nombres"));
                nut.setApellidos(rs.getString("apellidos"));
                nut.setEmailPUCP(rs.getString("emailPUCP"));
                nut.setEmailPersonal(rs.getString("emailPersonal"));
                nut.setTelefonoMovil(rs.getString("telefonoMovil"));
                nut.setFechaNacimiento(rs.getDate("fechaNacimiento"));
                
                nut.setFotoSrc(rs.getBytes("fotoSrc"));
                
                nut.setSexo(rs.getString("sexo").charAt(0)); 
                nut.setEstado(rs.getInt("estado"));
                
                nut.setBiografia(rs.getString("biografia"));
                nut.setTelefonoLaboral(rs.getString("telefonoLaboral"));
                nut.setDireccionLaboral(rs.getString("direccionLaboral"));
                
                nut.setColegiatura(rs.getString("colegiatura"));
                

                
                nutricionistas.add(nut);
            }
            
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return nutricionistas;
    }
    
}
