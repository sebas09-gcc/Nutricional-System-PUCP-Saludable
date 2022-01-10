/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.services;

import java.awt.Image;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Locale;
import java.util.TimeZone;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.config.DBManager;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.PlanAlimentarioDAO;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql.PlanAlimentarioMySQL;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.PlanAlimentario;
import pe.edu.pucp.pucpsaludable.receta.model.Ingrediente;
import pe.edu.pucp.pucpsaludable.receta.model.PresetReceta;
import pe.edu.pucp.pucpsaludable.receta.model.Receta;
import pe.edu.pucp.pucpsaludable.recetas.dao.IngredienteDAO;
import pe.edu.pucp.pucpsaludable.recetas.dao.PresetRecetaDAO;
import pe.edu.pucp.pucpsaludable.recetas.dao.RecetaDAO;
import pe.edu.pucp.pucpsaludable.recetas.mysql.IngredienteMySQL;
import pe.edu.pucp.pucpsaludable.recetas.mysql.PresetRecetaMySQL;
import pe.edu.pucp.pucpsaludable.recetas.mysql.RecetaMySQL;
import pe.edu.pucp.pucpsaludable.servlets.ListaDeCompras;

/**
 *
 * @author Nico
 */
@WebService(serviceName = "PlanAlimentario")
public class PlanAlimentarioService {
    // esto es para el plan alimentario
    //obtener plan
    @WebMethod(operationName = "planAlimentarioAlumno")
    public ArrayList<PlanAlimentario> listarPorUnAlumno(@WebParam(name = "id") int id){
        PlanAlimentarioDAO _dao = new PlanAlimentarioMySQL();
        return _dao.listarPorUnAlumno(id);
    }
    
    @WebMethod(operationName = "planAlimentarioAlumnoPreset")
    public ArrayList<PresetReceta> listarPorUnAlumnoPreset(@WebParam(name = "id")int id){
        PlanAlimentarioDAO _dao = new PlanAlimentarioMySQL();
        return _dao.listarPorUnAlumnoPreset(id);
    }
    //obtener ingredientes de un preset
    @WebMethod(operationName = "ingredientesPreset")
    public ArrayList<Ingrediente> listarXPresetRecta(@WebParam(name = "id")int id){
        IngredienteDAO _dao = new IngredienteMySQL();
        return _dao.listarXPresetRecta(id);
    }
    
    @WebMethod(operationName = "recetaPorPresetID")
    public Receta obtenerRecetaXIDPreset(@WebParam(name = "id")int id){
        RecetaDAO _dao = new RecetaMySQL();
        return _dao.obtenerRecetaXIDPreset(id);
    }
    
    @WebMethod(operationName = "presetsPorTipoC")
    public ArrayList<PresetReceta> listarPorTipoComida(@WebParam(name = "tipo")int tipo){
        PresetRecetaDAO _dao = new PresetRecetaMySQL();
        return _dao.listarPorTipoComida(tipo);
    }
    
    
    @WebMethod(operationName = "generarIngredientesCompra")
    public byte[] generarReporteIngredientes(@WebParam(name = "id") int id)
    {
        byte[] reporteBytes = null;
        try{
                 Locale.setDefault(new Locale("es","PE"));
            TimeZone.setDefault(TimeZone.getTimeZone("GMT-5"));
            JasperReport reporte = 
                    (JasperReport) JRLoader.loadObject(ListaDeCompras.class.getResource(
                            "/pe/edu/pucp/pucpsaludable/reportes/ReporteTotal.jasper"));
            String rutaSubreporteReceta = 
                ListaDeCompras.class.getResource("/pe/edu/pucp/pucpsaludable/reportes/ReporteReceta.jasper").getPath();
            String rutaImagenFondo = 
                ListaDeCompras.class.getResource("/pe/edu/pucp/pucpsaludable/img/background.jpg").getPath();
            String rutaIcono = 
                ListaDeCompras.class.getResource("/pe/edu/pucp/pucpsaludable/img/HM.jpg").getPath();
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            HashMap hm = new HashMap();
            hm.put("IdAlumno",String.valueOf(id));
            Image imagenFondo = (new ImageIcon(rutaImagenFondo)).getImage();
            Image imagenIcono = (new ImageIcon(rutaIcono)).getImage();
            hm.put("pImagenFondo", imagenFondo);
            hm.put("pImagenIcono", imagenIcono);
            hm.put("rutaReporteReceta",rutaSubreporteReceta);
            JasperPrint jp = JasperFillManager.fillReport(reporte,hm,con);
            con.close();
            reporteBytes = JasperExportManager.exportReportToPdf(jp);
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        return reporteBytes;
    }
    @WebMethod(operationName = "eliminarPlanAlimAlumno")
    public int eliminarPlanAlimentarioxAlumno(@WebParam(name = "id")int id){
        PlanAlimentarioDAO _dao = new PlanAlimentarioMySQL();
        return _dao.eliminarPlanAlimentarioxAlumno(id);
    }
    
    @WebMethod(operationName = "modificarPlanAlumno")
    public int modificarPlanAlumno(@WebParam(name = "planesAlimentario")ArrayList<PlanAlimentario> planesAlimentario){
        PlanAlimentarioDAO _dao = new PlanAlimentarioMySQL();
        return _dao.modificarPlanAlumno(planesAlimentario);
    }
    
    @WebMethod(operationName = "generarNuevoPlanAlumno")
    public ArrayList<PresetReceta> generarPlanAlumno(@WebParam(name = "idAlumno")int idAlumno){
        PlanAlimentarioDAO _dao = new PlanAlimentarioMySQL();
        ArrayList<PresetReceta> lp = new ArrayList<PresetReceta>();
        for (int i = 0; i < 5; i++)
        {
            lp.addAll(_dao.generarPlan(idAlumno, 7, i));
        }
        return lp;
    }

    @WebMethod(operationName = "insertarNuevoPlan")
    public int insertarNuevoPlan(@WebParam(name = "plan") ArrayList<PlanAlimentario> plan){
        PlanAlimentarioDAO _dao = new PlanAlimentarioMySQL();
        return _dao.insertarPlanAlumno(plan);
    }
}
