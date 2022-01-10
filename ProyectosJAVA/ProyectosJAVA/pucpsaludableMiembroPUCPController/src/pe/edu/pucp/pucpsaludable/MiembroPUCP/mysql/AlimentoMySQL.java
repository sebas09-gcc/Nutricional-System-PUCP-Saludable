/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.config.DBManager;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.AlimentoDAO;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Alimento;

/**
 *
 * @author sebas
 */
public class AlimentoMySQL implements AlimentoDAO{
    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    PreparedStatement ps; //
    CallableStatement cs;
    
    @Override
    public int insertar(Alimento alim) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call AGREGAR_ALIMENTO_A_ALUMNO(?,?,?)}");
            
            
            
            cs.setInt("_fid_alumno", alim.getFid_alumno());
            cs.setInt("_fid_ingrediente", alim.getFid_ingrediente());
            cs.setInt("_preferencia", alim.getPreferencia());
                        
            cs.executeUpdate();
            resultado = 1;
        
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;  
    }

    @Override
    public ArrayList<Alimento> listarTodo() {
        ArrayList<Alimento> alims = new ArrayList<>();
        try{
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("{call LISTAR_ALIMENTO()}");
            cs.executeUpdate();

            rs = cs.executeQuery();      
            //devolverá toda la tabla
            //necesitamos colocarnos en linea por linea
            while(rs.next()){
                Alimento al = new Alimento(); //debe existir el constructo vacio de Area
                al.setFid_alumno(rs.getInt("fid_alumno")); //se coloca el nombre de la columna
                al.setFid_ingrediente(rs.getInt("fid_ingrediente")); //se coloca el nombre de la columna
                al.setPreferencia(rs.getInt("preferencia")); //se coloca el nombre de la columna
                alims.add(al);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ps.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return alims;
    }
    
    @Override
    public ArrayList<Alimento> listarAlimentoPreferidoPorAlumno(int id_alumno) {
        ArrayList<Alimento> alims = new ArrayList<>();
        try{
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("{call LISTAR_ALIMENTO_PREFERIDO_POR_ALUMNO(?)}");
            cs.setInt("_fid_alumno", id_alumno);
            cs.executeUpdate();

            rs = cs.executeQuery();      
            //devolverá toda la tabla
            //necesitamos colocarnos en linea por linea
            while(rs.next()){
                Alimento al = new Alimento(); //debe existir el constructo vacio de Area
                al.setFid_alumno(rs.getInt("fid_alumno")); //se coloca el nombre de la columna
                al.setFid_ingrediente(rs.getInt("fid_ingrediente")); //se coloca el nombre de la columna
                al.setPreferencia(rs.getInt("preferencia")); //se coloca el nombre de la columna
                alims.add(al);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ps.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return alims;
    }
    
    
    @Override
    public ArrayList<Alimento> listarAlimentoAlergiaPorAlumno(int id_alumno) {
        ArrayList<Alimento> alims = new ArrayList<>();
        try{
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("{call LISTAR_ALIMENTO_ALERGIA_POR_ALUMNO(?)}");
            cs.setInt("_fid_alumno", id_alumno);
            cs.executeUpdate();

            rs = cs.executeQuery();      
            //devolverá toda la tabla
            //necesitamos colocarnos en linea por linea
            while(rs.next()){
                Alimento al = new Alimento(); //debe existir el constructo vacio de Area
                al.setFid_alumno(rs.getInt("fid_alumno")); //se coloca el nombre de la columna
                al.setFid_ingrediente(rs.getInt("fid_ingrediente")); //se coloca el nombre de la columna
                al.setPreferencia(rs.getInt("preferencia")); //se coloca el nombre de la columna
                alims.add(al);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ps.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return alims;
    }
    
    @Override
    public ArrayList<Alimento> filtrarAlimentoPorPreferencia(int id_alumno,int pref) {
        ArrayList<Alimento> alims = new ArrayList<>();
        try{
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("{call FILTRAR_ALIMENTO_POR_PREFERENCIA(?,?)}");
            cs.setInt("_fid_alumno", id_alumno);
            cs.setInt("_preferencia", pref);
            cs.executeUpdate();

            rs = cs.executeQuery();      
            //devolverá toda la tabla
            //necesitamos colocarnos en linea por linea
            while(rs.next()){
                Alimento al = new Alimento(); //debe existir el constructo vacio de Area
                al.setFid_alumno(rs.getInt("fid_alumno")); //se coloca el nombre de la columna
                al.setFid_ingrediente(rs.getInt("fid_ingrediente")); //se coloca el nombre de la columna
                al.setPreferencia(rs.getInt("preferencia")); //se coloca el nombre de la columna
                alims.add(al);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ps.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return alims;
    }

    @Override
    public int eliminar(int id_alum,int id_ingr) {
        int resultado = 0;
        try{
            //registramos el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //establecemos la coneccion
            //para ello llamaremos a DBManager,java
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("{call "+
                    "ELIMINAR_ALIMENTO_ALUMNO_INGR(?,?)}");
            
            /*
            CREATE PROCEDURE ELIMINAR_ALUMNO(
                IN _id_alumno INT
            )
            BEGIN
                UPDATE usuario SET estado = 0 WHERE _id_alumno = id_usuario;
            END
            */
            
            cs.setInt("_fid_alumno", id_alum);
            cs.setInt("_fid_ingrediente", id_ingr);
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
    public int modificar(Alimento alim) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_ALIMENTO(?,?,?)}");
            
            cs.setInt("_fid_alumno", alim.getFid_alumno());
            cs.setInt("_fid_ingrediente", alim.getFid_ingrediente());
            cs.setInt("_preferencia", alim.getPreferencia());
                        
            cs.executeUpdate();
            resultado = 1;
        
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }

    @Override
    public Alimento adquirirAlimento(int id_al, int id_ingre) {
        Alimento alim = new Alimento();
        alim.setFid_alumno(-1);
        alim.setFid_ingrediente(-1);
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ADQUIRIR_ALIMENTO(?,?)}");
            
            cs.setInt("_fid_alumno", id_al);
            cs.setInt("_fid_ingrediente", id_ingre);
                        
            rs = cs.executeQuery();
            while(rs.next()){
                //Cita cit = new Cita();
                
                //sacar campos con set
                //c.setId_usuario(rs.getInt("id_usuario"));
                //INSERT INTO horariohabitual(fid_alumno,despertarse,acostarse,desayuno,mediaManana,comida,merienda,cena)
                alim.setFid_alumno(id_al);
                alim.setFid_alumno(rs.getInt("fid_alumno")); //se coloca el nombre de la columna
                alim.setFid_ingrediente(rs.getInt("fid_ingrediente")); //se coloca el nombre de la columna
                alim.setPreferencia(rs.getInt("preferencia")); //se coloca el nombre de la columna
            }
            //resultado = 1;
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return alim;
    }

    
    
}
