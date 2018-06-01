using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheController
{
    public class Cache
    {
        public static DataTable TODOS_LOS_ESTADOS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDEstado, Estado FROM Estados;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable TODOS_LOS_EJEMPLARES()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDEjemplar, a.IDLibro, b.Titulo, N_Ejemplar, Ubicacion, Fecha_Ingreso, Fecha_Salida, c.Estado, Estado_Libro ");
            Consulta.Append("FROM ejemplares a, Libros b, Estados c WHERE b.IDLibro=a.IDLibro AND c.IDEstado=a.IDEstado;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable TODOS_LOS_LIBROS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT a.IDLibro, a.Titulo, a.Fecha_Lanzamiento, a.Paginas, a.Contenidos, ");
            Consulta.Append("a.IDEditorial, b.Nombre AS 'Editorial', a.IDCategoria, c.Categoria, a.IDAutor, d.Nombre AS 'Autor', a.Edicion, a.Portada ");
            Consulta.Append("FROM libros a, Editoriales b, Categorias c, Autores d ");
            Consulta.Append("WHERE b.IDEditorial=a.IDEditorial AND c.IDCategoria=a.IDCategoria AND d.IDAutor=a.IDAutor;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable TODAS_LAS_CATEGORIAS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDCategoria, Categoria, Estandares FROM Categorias ORDER BY Categoria ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable TODOS_LOS_AUTORES()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDAutor, Nombre, Fecha_Nacimiento, Residencia FROM Autores ORDER BY Nombre ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable TODAS_LAS_EDITORIALES()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDEditorial, Nombre, Direccion, Telefono FROM Editoriales ORDER BY Nombre ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable PERMISOS_ASIGNADOS(String pIDRol)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT b.IDPermiso, a.IDOpcion, a.Opcion, b.Mostrar, a.Clasificacion");
            Consulta.Append(" FROM opciones a, permisos b");
            Consulta.Append("  WHERE b.IDRol = " + pIDRol + " AND b.IDOpcion = a.IDOpcion");
            Consulta.Append(" ORDER BY Clasificacion, Opcion; ");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable TODOS_LOS_USUARIOS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT a.IDUsuario, a.Usuario, a.IDEmpleado, concat(b.Nombres, ' ', b.Apellidos) AS Nombre, c.Rol, a.IDRol FROM Usuarios a, Empleados b,Roles c WHERE a.IDEmpleado=b.IDEmpleado AND a.IDRol=c.IDRol ORDER BY Nombre ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable TODOS_LOS_LECTORES()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDLector, Usuario, Nombres, Apellidos, FechaNacimiento, Genero, MaxPrestamo, Credibilidad, MaxTiempoPrestamo, Fecha_Inicio, Foto FROM Lectores ORDER BY Apellidos ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable TODOS_LOS_EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDEmpleado, Apellidos, Nombres, FechaNacimiento, Genero, Foto FROM empleados ORDER BY Apellidos ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable TODOS_LOS_ROLES()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDRol, Rol FROM roles  ORDER BY Rol ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable VALIDAR_USUARIO(String pUsuario, String pCredencial)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT a.IDUsuario,a.Usuario, a.Credencial, a.IDEmpleado,CONCAT(b.Nombres,' ',b.Apellidos) as 'Empleado' ,a.IDRol,c.Rol FROM usuarios a, empleados b, roles c WHERE a.IDEmpleado=b.IDEmpleado AND a.IDRol=c.IDRol AND a.Usuario='"+pUsuario+"' AND a.Credencial=SHA1('"+pCredencial+"');");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
    }
}
