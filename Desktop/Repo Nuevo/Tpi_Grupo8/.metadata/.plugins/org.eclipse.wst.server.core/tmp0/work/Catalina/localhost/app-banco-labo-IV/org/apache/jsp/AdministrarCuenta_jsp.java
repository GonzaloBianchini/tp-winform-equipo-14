/*
 * Generated by the Jasper component of Apache Tomcat
 * Version: Apache Tomcat/8.0.50
 * Generated at: 2024-11-12 02:02:58 UTC
 * Note: The last modified time of this file was set to
 *       the last modified time of the source file after
 *       generation to assist with modification tracking.
 */
package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import java.util.ArrayList;
import entidades.Cuenta;

public final class AdministrarCuenta_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent,
                 org.apache.jasper.runtime.JspSourceImports {

  private static final javax.servlet.jsp.JspFactory _jspxFactory =
          javax.servlet.jsp.JspFactory.getDefaultFactory();

  private static java.util.Map<java.lang.String,java.lang.Long> _jspx_dependants;

  static {
    _jspx_dependants = new java.util.HashMap<java.lang.String,java.lang.Long>(1);
    _jspx_dependants.put("/BarraMenuAdmin.jsp", Long.valueOf(1731017276352L));
  }

  private static final java.util.Set<java.lang.String> _jspx_imports_packages;

  private static final java.util.Set<java.lang.String> _jspx_imports_classes;

  static {
    _jspx_imports_packages = new java.util.HashSet<>();
    _jspx_imports_packages.add("javax.servlet");
    _jspx_imports_packages.add("javax.servlet.http");
    _jspx_imports_packages.add("javax.servlet.jsp");
    _jspx_imports_classes = new java.util.HashSet<>();
    _jspx_imports_classes.add("entidades.Cuenta");
    _jspx_imports_classes.add("java.util.ArrayList");
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
      out.write("\r\n");
      out.write("\r\n");
      out.write("<!DOCTYPE html>\r\n");
      out.write("<html lang=\"es\">\r\n");
      out.write("<head>\r\n");
      out.write("    <meta charset=\"UTF-8\">\r\n");
      out.write("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n");
      out.write("    <title>AdminCuentas</title>\r\n");
      out.write("    <link rel=\"stylesheet\" href=\"EstiloGrid.css\">\r\n");
      out.write("    <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.1/font/bootstrap-icons.css\">\r\n");
      out.write("    <style>\r\n");
      out.write("        body {\r\n");
      out.write("            font-family: Arial, Helvetica, sans-serif;\r\n");
      out.write("            margin: 0;\r\n");
      out.write("            background-color: #f4f4f4;\r\n");
      out.write("        }\r\n");
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
      out.write("            height: 60px;\r\n");
      out.write("        }\r\n");
      out.write("        .header h1 {\r\n");
      out.write("            margin: 0;\r\n");
      out.write("            font-size: 24px;\r\n");
      out.write("        }\r\n");
      out.write("        .user-info {\r\n");
      out.write("            font-size: 16px;\r\n");
      out.write("        }\r\n");
      out.write("        .table-container {\r\n");
      out.write("            margin-top: 70px;\r\n");
      out.write("            padding: 20px;\r\n");
      out.write("        }\r\n");
      out.write("        .search-input {\r\n");
      out.write("            padding: 8px;\r\n");
      out.write("            font-size: 14px;\r\n");
      out.write("            border: 1px solid #ccc;\r\n");
      out.write("            border-radius: 4px;\r\n");
      out.write("            outline: none;\r\n");
      out.write("            width: 200px;\r\n");
      out.write("        }\r\n");
      out.write("        .search-button {\r\n");
      out.write("            background-color: #4CAF50;\r\n");
      out.write("            color: white;\r\n");
      out.write("            padding: 8px 12px;\r\n");
      out.write("            border: none;\r\n");
      out.write("            border-radius: 4px;\r\n");
      out.write("            cursor: pointer;\r\n");
      out.write("            font-size: 14px;\r\n");
      out.write("        }\r\n");
      out.write("        .search-button:hover {\r\n");
      out.write("            background-color: #45a049;\r\n");
      out.write("        }\r\n");
      out.write("        .show-all-button {\r\n");
      out.write("            background-color: #4CAF50; /* Verde */\r\n");
      out.write("            color: white;\r\n");
      out.write("            padding: 8px 12px;\r\n");
      out.write("            border: none;\r\n");
      out.write("            border-radius: 4px;\r\n");
      out.write("            cursor: pointer;\r\n");
      out.write("            font-size: 14px;\r\n");
      out.write("            margin-bottom: 10px;\r\n");
      out.write("        }\r\n");
      out.write("        .show-all-button:hover {\r\n");
      out.write("            background-color: #45a049; /* Un tono más oscuro de verde */\r\n");
      out.write("        }\r\n");
      out.write("    </style>\r\n");
      out.write("</head>\r\n");
      out.write("<body>\r\n");
      out.write("  ");
      out.write("\r\n");
      out.write("<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">\r\n");
      out.write("<html>\r\n");
      out.write("\r\n");
      out.write("<head>\r\n");
      out.write("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=ISO-8859-1\">\r\n");
      out.write("<title>Insert title here</title>\r\n");
      out.write("<style>\r\n");
      out.write("        body{\r\n");
      out.write("            font-family: Arial, Helvetica, sans-serif;\r\n");
      out.write("        }\r\n");
      out.write("\r\n");
      out.write("        .header {\r\n");
      out.write("    background-color: #1464a5;\r\n");
      out.write("    color: white;\r\n");
      out.write("    display: flex;\r\n");
      out.write("    justify-content: space-between;\r\n");
      out.write("    align-items: center;\r\n");
      out.write("    padding: 10px 20px;\r\n");
      out.write("    width: 100%; \r\n");
      out.write("    position: fixed; \r\n");
      out.write("    top: 0;\r\n");
      out.write("    left: 0;\r\n");
      out.write("    z-index: 1000;\r\n");
      out.write("}\r\n");
      out.write("\r\n");
      out.write(".header img {\r\n");
      out.write("    height: 60px;  \r\n");
      out.write("}\r\n");
      out.write("\r\n");
      out.write(".header h1 {\r\n");
      out.write("    margin: 0;\r\n");
      out.write("    font-size: 24px;\r\n");
      out.write("}\r\n");
      out.write("\r\n");
      out.write(".header .menu {\r\n");
      out.write("    display: flex;\r\n");
      out.write("    gap: 1px; \r\n");
      out.write("}\r\n");
      out.write("\r\n");
      out.write(".header a {\r\n");
      out.write("    color: white;\r\n");
      out.write("    padding: 5px 8px; \r\n");
      out.write("    text-decoration: none;\r\n");
      out.write("    display: inline-block;\r\n");
      out.write("}\r\n");
      out.write("\r\n");
      out.write(".header a:hover {\r\n");
      out.write("    background-color: #0b4d94;\r\n");
      out.write("}\r\n");
      out.write("  </style>\r\n");
      out.write("</head>\r\n");
      out.write("<body>\r\n");
      out.write("<div class=\"header\">\r\n");
      out.write("        <img src=\"images/sinfondo.png\" alt=\"Logo\">\r\n");
      out.write("        <h1>ADMINISTRADOR</h1> \r\n");
      out.write("        <div class=\"menu\">\r\n");
      out.write("            <a href=\"AdministrarClientes.jsp\">Administrar Clientes</a>\r\n");
      out.write("            <a href=\"AdministrarCuenta.jsp\">Administrar Cuentas</a>\r\n");
      out.write("            <a href=\"AceptarPrestamo.jsp\">Ver solicitud Prestamo</a>\r\n");
      out.write("            <a href=\"Informes.jsp\">Informes</a>\r\n");
      out.write("            <a href=\"Agregar Cliente.jsp\">Agregar Cliente</a>\r\n");
      out.write("            <a href=\"Agregar Cuenta.jsp\">Agregar Cuenta</a>\r\n");
      out.write("        </div>\r\n");
      out.write("        <div class=\"user-info\">Usuario: <strong>acá va el usuario logueado</strong></div>\r\n");
      out.write("    </div>\r\n");
      out.write("</body>\r\n");
      out.write("</html>");
      out.write("\r\n");
      out.write("    \r\n");
      out.write("    <div class=\"table-container\">\r\n");
      out.write("       <form action=\"servletCuenta\" method=\"post\">\r\n");
      out.write("        \t<button class=\"show-all-button\" name=\"btnMostrarTodo\" type=\"submit\">\r\n");
      out.write("            \t<i class=\"bi bi-eye\"></i> Mostrar todo\r\n");
      out.write("        \t</button>\r\n");
      out.write("       </form> \r\n");
      out.write("       \r\n");
      out.write("        <div class=\"search-container\">\r\n");
      out.write("        <form action=\"servletCuenta\" method=\"post\" >\r\n");
      out.write("            <input type=\"text\" name=\"txtBuscarIdCliente\" class=\"search-input\" placeholder=\"Buscar por ID cliente\">\r\n");
      out.write("            <button class=\"search-button\" name=\"btnBuscarID\" >\r\n");
      out.write("                <i class=\"bi bi-search\"></i> Aplicar\r\n");
      out.write("            </button>\r\n");
      out.write("            </form>\r\n");
      out.write("            <form action=\"servletCuenta\" method=\"post\"  >\r\n");
      out.write("            <input type=\"text\" name=\"txtBuscarTipoCuenta\" class=\"search-input\" placeholder=\"Búsqueda por tipo de cuenta\">\r\n");
      out.write("            <button class=\"search-button\" name=\"btnBuscarTipoCuenta\" type=\"submit\" >\r\n");
      out.write("                <i class=\"bi bi-search\"></i> Aplicar\r\n");
      out.write("            </button>\r\n");
      out.write("            </form>\r\n");
      out.write("        </div>\r\n");
      out.write("<table id=\"miTabla\">\r\n");
      out.write("    <thead>\r\n");
      out.write("        <tr>\r\n");
      out.write("            <th>ID Cuenta</th>\r\n");
      out.write("            <th>Número de Cuenta</th>\r\n");
      out.write("            <th>CBU</th>\r\n");
      out.write("            <th>Saldo</th>\r\n");
      out.write("            <th>Cliente ID</th>\r\n");
      out.write("            <th>Tipo Cuenta ID</th>\r\n");
      out.write("            <th>Fecha Creación</th>\r\n");
      out.write("            <th>Opciones</th>\r\n");
      out.write("        </tr>\r\n");
      out.write("    </thead>\r\n");
      out.write("    <tbody>\r\n");
      out.write("      \r\n");
      out.write("        ");

            ArrayList<Cuenta> listadoCuenta = (ArrayList<Cuenta>) request.getAttribute("listadoCuenta");
            if (listadoCuenta != null && !listadoCuenta.isEmpty()) {
                for (Cuenta cuenta : listadoCuenta) {
        
      out.write("\r\n");
      out.write("        <tr>\r\n");
      out.write("            <td>");
      out.print( cuenta.getIdCuenta());
      out.write("</td>\r\n");
      out.write("            <td>");
      out.print( cuenta.getNroCuenta() );
      out.write("</td>\r\n");
      out.write("            <td>");
      out.print( cuenta.getCBU() );
      out.write("</td>\r\n");
      out.write("            <td>");
      out.print( cuenta.getSaldo() );
      out.write("</td>\r\n");
      out.write("            <td>");
      out.print( cuenta.getClienteId() );
      out.write("</td>\r\n");
      out.write("            <td>");
      out.print( cuenta.getTipoCuentaId() );
      out.write("</td>\r\n");
      out.write("            <td>");
      out.print( cuenta.getFechaCreacion() );
      out.write("</td>\r\n");
      out.write("            <td>\r\n");
      out.write("                <button onclick=\"window.location.href='EditarCuenta.jsp?id=");
      out.print( cuenta.getIdCuenta());
      out.write("'\">\r\n");
      out.write("                    <i class=\"bi bi-pencil\"></i> Editar\r\n");
      out.write("                </button>\r\n");
      out.write("                <button onclick=\"window.location.href='EliminarCuenta.jsp?id=");
      out.print( cuenta.getIdCuenta());
      out.write("'\">\r\n");
      out.write("                    <i class=\"bi bi-trash\"></i>\r\n");
      out.write("                </button>\r\n");
      out.write("            </td>\r\n");
      out.write("        </tr>\r\n");
      out.write("        ");
 
                }
            } else { 
        
      out.write("\r\n");
      out.write("        <tr>\r\n");
      out.write("            <td colspan=\"8\">No se encontraron cuentas.</td>\r\n");
      out.write("        </tr>\r\n");
      out.write("        ");
 } 
      out.write("\r\n");
      out.write("    </tbody>\r\n");
      out.write("</table>\r\n");
      out.write("        \r\n");
      out.write("        <div id=\"pagination\">\r\n");
      out.write("            <button onclick=\"previousPage()\">Anterior</button>\r\n");
      out.write("            <button onclick=\"nextPage()\">Siguiente</button>\r\n");
      out.write("        </div>\r\n");
      out.write("    </div>\r\n");
      out.write("</body>\r\n");
      out.write("\r\n");
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
