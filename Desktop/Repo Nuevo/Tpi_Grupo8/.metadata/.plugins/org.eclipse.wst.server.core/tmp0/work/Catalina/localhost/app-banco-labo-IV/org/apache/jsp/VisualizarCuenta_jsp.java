/*
 * Generated by the Jasper component of Apache Tomcat
 * Version: Apache Tomcat/8.0.50
 * Generated at: 2024-11-06 05:36:31 UTC
 * Note: The last modified time of this file was set to
 *       the last modified time of the source file after
 *       generation to assist with modification tracking.
 */
package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class VisualizarCuenta_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent,
                 org.apache.jasper.runtime.JspSourceImports {

  private static final javax.servlet.jsp.JspFactory _jspxFactory =
          javax.servlet.jsp.JspFactory.getDefaultFactory();

  private static java.util.Map<java.lang.String,java.lang.Long> _jspx_dependants;

  static {
    _jspx_dependants = new java.util.HashMap<java.lang.String,java.lang.Long>(1);
    _jspx_dependants.put("/MenuCliente.jsp", Long.valueOf(1730871211139L));
  }

  private static final java.util.Set<java.lang.String> _jspx_imports_packages;

  private static final java.util.Set<java.lang.String> _jspx_imports_classes;

  static {
    _jspx_imports_packages = new java.util.HashSet<>();
    _jspx_imports_packages.add("javax.servlet");
    _jspx_imports_packages.add("javax.servlet.http");
    _jspx_imports_packages.add("javax.servlet.jsp");
    _jspx_imports_classes = null;
  }

  private volatile javax.el.ExpressionFactory _el_expressionfactory;
  private volatile org.apache.tomcat.InstanceManager _jsp_instancemanager;

  public java.util.Map<java.lang.String,java.lang.Long> getDependants() {
    return _jspx_dependants;
  }

  public java.util.Set<java.lang.String> getPackageImports() {
    return _jspx_imports_packages;
  }

  public java.util.Set<java.lang.String> getClassImports() {
    return _jspx_imports_classes;
  }

  public javax.el.ExpressionFactory _jsp_getExpressionFactory() {
    if (_el_expressionfactory == null) {
      synchronized (this) {
        if (_el_expressionfactory == null) {
          _el_expressionfactory = _jspxFactory.getJspApplicationContext(getServletConfig().getServletContext()).getExpressionFactory();
        }
      }
    }
    return _el_expressionfactory;
  }

  public org.apache.tomcat.InstanceManager _jsp_getInstanceManager() {
    if (_jsp_instancemanager == null) {
      synchronized (this) {
        if (_jsp_instancemanager == null) {
          _jsp_instancemanager = org.apache.jasper.runtime.InstanceManagerFactory.getInstanceManager(getServletConfig());
        }
      }
    }
    return _jsp_instancemanager;
  }

  public void _jspInit() {
  }

  public void _jspDestroy() {
  }

  public void _jspService(final javax.servlet.http.HttpServletRequest request, final javax.servlet.http.HttpServletResponse response)
        throws java.io.IOException, javax.servlet.ServletException {

final java.lang.String _jspx_method = request.getMethod();
if (!"GET".equals(_jspx_method) && !"POST".equals(_jspx_method) && !"HEAD".equals(_jspx_method) && !javax.servlet.DispatcherType.ERROR.equals(request.getDispatcherType())) {
response.sendError(HttpServletResponse.SC_METHOD_NOT_ALLOWED, "JSPs only permit GET POST or HEAD");
return;
}

    final javax.servlet.jsp.PageContext pageContext;
    javax.servlet.http.HttpSession session = null;
    final javax.servlet.ServletContext application;
    final javax.servlet.ServletConfig config;
    javax.servlet.jsp.JspWriter out = null;
    final java.lang.Object page = this;
    javax.servlet.jsp.JspWriter _jspx_out = null;
    javax.servlet.jsp.PageContext _jspx_page_context = null;


    try {
      response.setContentType("text/html; charset=ISO-8859-1");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;

      out.write("\r\n");
      out.write("<!DOCTYPE html>\r\n");
      out.write("<html>\r\n");
      out.write("<head>\r\n");
      out.write("    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=ISO-8859-1\">\r\n");
      out.write("    <title>Cuenta Actual</title>\r\n");
      out.write("    <style>\r\n");
      out.write("        body {\r\n");
      out.write("            font-family: 'Roboto', sans-serif;\r\n");
      out.write("            color: #ff6633;\r\n");
      out.write("            margin: 0;\r\n");
      out.write("            padding: 0;\r\n");
      out.write("            display: flex;\r\n");
      out.write("            flex-direction: column;\r\n");
      out.write("            align-items: center;\r\n");
      out.write("            justify-content: center;\r\n");
      out.write("            width: 100%;\r\n");
      out.write("            background-color: #ecf0f1;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .header {\r\n");
      out.write("            background-color: #1464a5;\r\n");
      out.write("            color: white;\r\n");
      out.write("            display: flex;\r\n");
      out.write("            align-items: center;\r\n");
      out.write("            padding: 10px 20px;\r\n");
      out.write("            width: 100%;\r\n");
      out.write("            position: fixed;\r\n");
      out.write("            top: 0;\r\n");
      out.write("            left: 0;\r\n");
      out.write("            z-index: 1000;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .header img {\r\n");
      out.write("            height: 60px;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .header h1 {\r\n");
      out.write("            margin: 0;\r\n");
      out.write("            flex-grow: 1;\r\n");
      out.write("            text-align: center;\r\n");
      out.write("            font-size: 24px;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .user-info {\r\n");
      out.write("            font-size: 16px;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .contenedor {\r\n");
      out.write("            background-color: #ffffff;\r\n");
      out.write("            padding: 20px;\r\n");
      out.write("            max-width: 500px;\r\n");
      out.write("            width: 90%;\r\n");
      out.write("            text-align: left;\r\n");
      out.write("            border-radius: 8px;\r\n");
      out.write("            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);\r\n");
      out.write("            margin-top: 100px; /* Ajustado para evitar solapamiento con el encabezado */\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .titulo {\r\n");
      out.write("            color: #2980b9;\r\n");
      out.write("            font-size: 2rem;\r\n");
      out.write("            font-weight: 600;\r\n");
      out.write("            margin-bottom: 10px;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .seccion {\r\n");
      out.write("            margin: 15px 0;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .seccion h2 {\r\n");
      out.write("            color: #2980b9;\r\n");
      out.write("            font-size: 1.5rem;\r\n");
      out.write("            font-weight: 500;\r\n");
      out.write("            margin-bottom: 5px;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .seccion p {\r\n");
      out.write("            color: #7f8c8d;\r\n");
      out.write("            font-size: 1.25rem;\r\n");
      out.write("            margin: 5px 0;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .saldo {\r\n");
      out.write("            font-size: 2rem;\r\n");
      out.write("            font-weight: bold;\r\n");
      out.write("            color: #27ae60;\r\n");
      out.write("        }\r\n");
      out.write("    </style>\r\n");
      out.write("</head>\r\n");
      out.write("<body>\r\n");
      out.write("   ");
      out.write("\r\n");
      out.write("<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">\r\n");
      out.write("<html>\r\n");
      out.write("<head>\r\n");
      out.write("    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=ISO-8859-1\">\r\n");
      out.write("    <title>Insert title here</title>\r\n");
      out.write("    <style>\r\n");
      out.write("        .header {\r\n");
      out.write("            background-color: #1464a5;\r\n");
      out.write("            color: white;\r\n");
      out.write("            display: flex;\r\n");
      out.write("            justify-content: space-between;\r\n");
      out.write("            align-items: center;\r\n");
      out.write("            padding: 10px 20px;\r\n");
      out.write("            width: 100%;\r\n");
      out.write("            position: fixed;\r\n");
      out.write("            top: 0;\r\n");
      out.write("            left: 0;\r\n");
      out.write("            z-index: 1000;\r\n");
      out.write("        }\r\n");
      out.write("        .header img {\r\n");
      out.write("            height: 60px;  \r\n");
      out.write("        }\r\n");
      out.write("        .header .menu {\r\n");
      out.write("            display: flex;\r\n");
      out.write("            gap: 10px; \r\n");
      out.write("        }\r\n");
      out.write("        .header a {\r\n");
      out.write("            color: white;\r\n");
      out.write("            padding: 14px 20px; \r\n");
      out.write("            text-decoration: none;\r\n");
      out.write("            display: inline-block;\r\n");
      out.write("        }\r\n");
      out.write("        .header a:hover {\r\n");
      out.write("            background-color: #1b2025;\r\n");
      out.write("        }\r\n");
      out.write("    </style>\r\n");
      out.write("</head>\r\n");
      out.write("<body>\r\n");
      out.write("    <div class=\"header\">\r\n");
      out.write("        <img src=\"SLOGAN.png\" alt=\"Logo\">\r\n");
      out.write("        <div class=\"menu\">\r\n");
      out.write("            <a href=\"OpcionesCuenta.jsp\">Eleccion Cuentas</a>\r\n");
      out.write("            <a href=\"CuentaElegida.jsp\">Ver Cuenta</a>\r\n");
      out.write("            <a href=\"SolicitudPrestamo.jsp\">Solicitud Prestamo</a>\r\n");
      out.write("            <a href=\"Transferencias.jsp\">Transacciones</a>\r\n");
      out.write("            <a href=\"contact.jsp\">Realizar pago de Cuotas</a>\r\n");
      out.write("            <a href=\"EditarPassword.jsp\">Cambiar Contrasenia</a> \r\n");
      out.write("            <a href=\"contact.jsp\">Datos Personales</a> \r\n");
      out.write("            <a href=\"contact.jsp\">Historial de movimientos</a> \r\n");
      out.write("        </div>\r\n");
      out.write("        <div class=\"user-info\">Usuario: <strong>acá va el usuario Cliente</strong></div>\r\n");
      out.write("    </div>\r\n");
      out.write("</body>\r\n");
      out.write("</html>\r\n");
      out.write("\r\n");
      out.write("   \r\n");
      out.write("\r\n");
      out.write("    <div class=\"contenedor\">\r\n");
      out.write("        <div class=\"titulo\">Cuenta (CBU de la cuenta)</div>\r\n");
      out.write("\r\n");
      out.write("        <div class=\"seccion\">\r\n");
      out.write("            <h2>Saldo</h2>\r\n");
      out.write("            <p class=\"saldo\">Valor Saldo</p>\r\n");
      out.write("        </div>\r\n");
      out.write("\r\n");
      out.write("        <div class=\"seccion\">\r\n");
      out.write("            <h2>Tipo de cuenta</h2>\r\n");
      out.write("            <p>(Tipo de cuenta)</p>\r\n");
      out.write("        </div>\r\n");
      out.write("    </div>\r\n");
      out.write("</body>\r\n");
      out.write("</html>\r\n");
    } catch (java.lang.Throwable t) {
      if (!(t instanceof javax.servlet.jsp.SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          try {
            if (response.isCommitted()) {
              out.flush();
            } else {
              out.clearBuffer();
            }
          } catch (java.io.IOException e) {}
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
