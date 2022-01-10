/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.servlets;

import java.awt.Image;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.HashMap;
import java.util.Locale;
import java.util.TimeZone;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.config.DBManager;

/**
 *
 * @author sebaf
 */
public class ListaDeCompras extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
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
            int i=1;
            hm.put("IdAlumno",String.valueOf(i));
            Image imagenFondo = (new ImageIcon(rutaImagenFondo)).getImage();
            Image imagenIcono = (new ImageIcon(rutaIcono)).getImage();
            hm.put("pImagenFondo", imagenFondo);
            hm.put("pImagenIcono", imagenIcono);
            hm.put("rutaReporteReceta",rutaSubreporteReceta);
            JasperPrint jp = JasperFillManager.fillReport(reporte,hm,con);
            
            con.close();
            JasperExportManager.exportReportToPdfStream(jp, response.getOutputStream());
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
