/*
 * Generated by the Jasper component of Apache Tomcat
 * Version: Apache Tomcat/8.0.50
 * Generated at: 2024-11-04 23:03:06 UTC
 * Note: The last modified time of this file was set to
 *       the last modified time of the source file after
 *       generation to assist with modification tracking.
 */
package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class SolicitarPrestamo_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent,
                 org.apache.jasper.runtime.JspSourceImports {

  private static final javax.servlet.jsp.JspFactory _jspxFactory =
          javax.servlet.jsp.JspFactory.getDefaultFactory();

  private static java.util.Map<java.lang.String,java.lang.Long> _jspx_dependants;

  static {
    _jspx_dependants = new java.util.HashMap<java.lang.String,java.lang.Long>(1);
    _jspx_dependants.put("/MenuCliente.jsp", Long.valueOf(1730760938759L));
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
      out.write("<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">\r\n");
      out.write("<html>\r\n");
      out.write("<head>\r\n");
      out.write("\r\n");
      out.write("<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">\r\n");
      out.write("<html>\r\n");
      out.write("<head>\r\n");
      out.write("    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=ISO-8859-1\">\r\n");
      out.write("    <title>Insert title here</title>\r\n");
      out.write("    <style>\r\n");
      out.write("        \r\n");
      out.write("      /*  .menu-bar {\r\n");
      out.write("           background-color: #4CAF50;\r\n");
      out.write("            overflow: hidden;\r\n");
      out.write("        }\r\n");
      out.write("        .menu-bar a {\r\n");
      out.write("            float: left;\r\n");
      out.write("            display: block;\r\n");
      out.write("            color: white;\r\n");
      out.write("            text-align: center;\r\n");
      out.write("            padding: 14px 16px;\r\n");
      out.write("            text-decoration: none;\r\n");
      out.write("        }\r\n");
      out.write("        .menu-bar a:hover {\r\n");
      out.write("            background-color: #ddd;\r\n");
      out.write("            color: black;\r\n");
      out.write("        }*/\r\n");
      out.write("        .menu-bar {\r\n");
      out.write("            background-color: #1464a5;\r\n");
      out.write("            overflow: hidden;\r\n");
      out.write("            text-align: center;\r\n");
      out.write("            font-family: Arial, Helvetica, sans-serif;\r\n");
      out.write("        }\r\n");
      out.write("        .menu-bar a {\r\n");
      out.write("            color: white;\r\n");
      out.write("            padding: 14px 20px;\r\n");
      out.write("            text-decoration: none;\r\n");
      out.write("            display: inline-block;\r\n");
      out.write("        }\r\n");
      out.write("        .menu-bar a:hover {\r\n");
      out.write("            background-color: #1b2025;\r\n");
      out.write("        }\r\n");
      out.write("        .menu-image {\r\n");
      out.write("\r\n");
      out.write("            padding-top: 10px;\r\n");
      out.write("            height: 100px; /* Tamaño de la imagen /\r\n");
      out.write("\r\n");
      out.write("\r\n");
      out.write("            margin-right: 10px;\r\n");
      out.write("            box-shadow: 0 0 10px rgba(0, 0, 0, 0.5); / Borde esfumado /\r\n");
      out.write("            border-radius: 5px; / Suaviza las esquinas */\r\n");
      out.write("        }\r\n");
      out.write("        \r\n");
      out.write("    </style>\r\n");
      out.write("</head>\r\n");
      out.write("<body>\r\n");
      out.write("\r\n");
      out.write("    \r\n");
      out.write("    <div class=\"menu-bar\">\r\n");
      out.write("        <img src=\"SLOGAN.png\" alt=\"Logo\"   class=\"menu-image\" ></a>\r\n");
      out.write("        <a href=\"home.jsp\">Eleccion Cuentas</a>\r\n");
      out.write("        <a href=\"CuentaElegida.jsp\">Ver Cuenta</a>\r\n");
      out.write("        <a href=\"services.jsp\">Solicitud Prestamo</a>\r\n");
      out.write("        <a href=\"contact.jsp\">Transacciones</a>\r\n");
      out.write("        <a href=\"contact.jsp\">Realizar pago de Cuotas</a>\r\n");
      out.write("        <a href=\"contact.jsp\">Cambiar Contrasenia</a> \r\n");
      out.write("        <a href=\"contact.jsp\">Datos Personales</a> \r\n");
      out.write("        <a href=\"contact.jsp\">Historial de movimientos</a> \r\n");
      out.write("    </div>\r\n");
      out.write("</body>\r\n");
      out.write("</html>\r\n");
      out.write("\r\n");
      out.write("    <meta charset=\"UTF-8\">\r\n");
      out.write("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n");
      out.write("    <title>Editar</title>\r\n");
      out.write("    <style>\r\n");
      out.write("        \r\n");
      out.write("\r\n");
      out.write("\r\n");
      out.write("    \r\n");
      out.write("        /* Estilos para el formulario */\r\n");
      out.write("        .form-container {\r\n");
      out.write("            max-width: 700px;\r\n");
      out.write("            margin:  auto;\r\n");
      out.write("            padding: 20px;\r\n");
      out.write("            border: 1px solid #ddd;\r\n");
      out.write("            border-radius: 5px;\r\n");
      out.write("            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);\r\n");
      out.write("            font-family: Arial, Helvetica, sans-serif;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .header {\r\n");
      out.write("            text-align: center;\r\n");
      out.write("            margin-bottom: 20px;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .form-group-pair {\r\n");
      out.write("            display: flex;\r\n");
      out.write("            gap: 20px;\r\n");
      out.write("            margin-bottom: 15px;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .form-group {\r\n");
      out.write("            position: relative;\r\n");
      out.write("            flex: 1;\r\n");
      out.write("            background-color: #f5f5f5;\r\n");
      out.write("            border: 1px solid #ddd;\r\n");
      out.write("            padding: 10px;\r\n");
      out.write("            border-radius: 4px;\r\n");
      out.write("           \r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .form-label {\r\n");
      out.write("            position: absolute;\r\n");
      out.write("            top: 6px;\r\n");
      out.write("            left: 10px;\r\n");
      out.write("            font-size: 12px;\r\n");
      out.write("            color: #666;\r\n");
      out.write("            pointer-events: none;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .form-input {\r\n");
      out.write("            width: 100%;\r\n");
      out.write("            padding: 20px 10px 6px;\r\n");
      out.write("            font-size: 16px;\r\n");
      out.write("            border: none;\r\n");
      out.write("            background-color: transparent;\r\n");
      out.write("            outline: none;\r\n");
      out.write("            box-sizing: border-box;\r\n");
      out.write("            color: #666;\r\n");
      out.write("           \r\n");
      out.write("          \r\n");
      out.write("      \r\n");
      out.write("           \r\n");
      out.write("           \r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .submit-btn {\r\n");
      out.write("            \r\n");
      out.write("            width: 100%;\r\n");
      out.write("            padding: 10px;\r\n");
      out.write("            background-color: #1464a5;\r\n");
      out.write("            color: white;\r\n");
      out.write("            border: none;\r\n");
      out.write("            border-radius: 5px;\r\n");
      out.write("            cursor: pointer;\r\n");
      out.write("            font-size: 16px;\r\n");
      out.write("            margin-bottom: 15px;\r\n");
      out.write("        }\r\n");
      out.write("        .submit-btn:hover {\r\n");
      out.write("            background-color: #246da8;\r\n");
      out.write("           \r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        /* Estilo para la flecha del select */\r\n");
      out.write("        .form-group select {\r\n");
      out.write("            appearance: none;\r\n");
      out.write("            -webkit-appearance: none;\r\n");
      out.write("            -moz-appearance: none;\r\n");
      out.write("            padding-right: 20px;\r\n");
      out.write("\r\n");
      out.write("            \r\n");
      out.write("        }\r\n");
      out.write("        .form-group {\r\n");
      out.write("            flex: 1; /* Las columnas ocupan el mismo espacio */\r\n");
      out.write("            margin-right: 10px; /* Espacio entre columnas */\r\n");
      out.write("        }\r\n");
      out.write("        .form-group-pair {\r\n");
      out.write("            display: flex; /* Usar flexbox para dos columnas */\r\n");
      out.write("            justify-content: space-between; /* Espaciado entre columnas */\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .form-group::after {\r\n");
      out.write("            content: '^';\r\n");
      out.write("            position: absolute;\r\n");
      out.write("            right: 10px;\r\n");
      out.write("            top: 50%;\r\n");
      out.write("            color: #007bff;\r\n");
      out.write("            pointer-events: none;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("     \r\n");
      out.write("        .form-group:not(:has(select))::after {\r\n");
      out.write("            content: ''; /* Esto elimina el contenido, es decir, la flecha */\r\n");
      out.write("        }\r\n");
      out.write("        .form-group.email-group {\r\n");
      out.write("            margin-bottom: 20px; /* Ajusta este valor para más o menos espacio */\r\n");
      out.write("        }\r\n");
      out.write("        .menu-image {\r\n");
      out.write("            \r\n");
      out.write("            padding-top: 10px;\r\n");
      out.write("            height: 150px; /* Tamaño de la imagen */\r\n");
      out.write("    \r\n");
      out.write("            \r\n");
      out.write("            margin-right: 10px;\r\n");
      out.write("            box-shadow: 0 0 10px rgba(0, 0, 0, 0.5); /* Borde esfumado */\r\n");
      out.write("            border-radius: 5px; /* Suaviza las esquinas */\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("    </style>\r\n");
      out.write("</head>\r\n");
      out.write("<body>\r\n");
      out.write("    <div class=\"form-container\">\r\n");
      out.write("        <div class=\"header\">\r\n");
      out.write("            <h1>Solicitud de Prestamo</h1>\r\n");
      out.write("        </div>\r\n");
      out.write("\r\n");
      out.write("        <!-- Campos en dos columnas -->\r\n");
      out.write("        <form action=\"submitForm\" method=\"post\">\r\n");
      out.write("        <div class=\"form-group-pair\">\r\n");
      out.write("            <div class=\"form-group\">\r\n");
      out.write("                <input type=\"text\" id=\"montoPrestamo\" placeholder=\"Ingrese el monto que desea\" class=\"form-input\"  >\r\n");
      out.write("            </div>\r\n");
      out.write("            <div class=\"form-group\">\r\n");
      out.write("                <input type=\"text\" id=\"tipoCuotas\" placeholder=\"Ingrese la cantidad de cuotas que desea(3-6-12)\" class=\"form-input\" >\r\n");
      out.write("            </div>\r\n");
      out.write("        </div>\r\n");
      out.write("        \r\n");
      out.write("        <!-- Boton de envio -->\r\n");
      out.write("        <input type=\"submit\" class=\"submit-btn\" value=\"Solicitar Prestamo\"> </input>\r\n");
      out.write("       </form> \r\n");
      out.write("    </div>\r\n");
      out.write("</body>\r\n");
      out.write("</html>");
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
