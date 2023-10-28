using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEmpleado
    {
        private Database db = new Database();
        public DEmpleado() { }

        public String Registrar(EEmpleado empleado)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                String insert = String.Format("INSERT INTO Empleado(Dni, Nombre, Puesto, Sueldo) VALUES('{0}', '{1}', '{2}', {3})",
                    empleado.Dni, empleado.Nombre, empleado.Puesto, empleado.Sueldo);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Insertado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }

        public String Modificar(EEmpleado empleado)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                String update = String.Format("UPDATE Empleado SET Dni='{0}', Nombre='{1}', Puesto='{2}', Sueldo={3}" +
                    " WHERE Id={4}", empleado.Dni, empleado.Nombre, empleado.Puesto, empleado.Sueldo, empleado.Id);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }

        public String Eliminar(int id)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                String delete = String.Format("DELETE FROM Empleado WHERE Id={0}", id);
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }

        public List<EEmpleado> ListarTodo()
        {
            try
            {
                List<EEmpleado> empleados = new List<EEmpleado>();
                EEmpleado empleado = null;
                SqlConnection con = db.ConectaDb();
                String list = "SELECT * FROM Empleado";
                SqlCommand cmd = new SqlCommand(list, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    empleado = new EEmpleado();
                    empleado.Id = (int)reader["Id"];
                    empleado.Dni = (String)reader["Dni"];
                    empleado.Nombre = (String)reader["Nombre"];
                    empleado.Puesto = (String)reader["Puesto"];
                    empleado.Sueldo = (Decimal)reader["Sueldo"];
                    empleados.Add(empleado);
                }
                reader.Close();
                return empleados;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDb();
            }
        }

        public List<EEmpleado> ListarOrdenadoPorSueldo()
        {
            try
            {
                List<EEmpleado> empleados = new List<EEmpleado>();
                EEmpleado empleado = null;
                SqlConnection con = db.ConectaDb();
                String list = "SELECT * FROM Empleado ORDER BY Sueldo ASC";
                SqlCommand cmd = new SqlCommand(list, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    empleado = new EEmpleado();
                    empleado.Id = (int)reader["Id"];
                    empleado.Dni = (String)reader["Dni"];
                    empleado.Nombre = (String)reader["Nombre"];
                    empleado.Puesto = (String)reader["Puesto"];
                    empleado.Sueldo = (Decimal)reader["Sueldo"];
                    empleados.Add(empleado);
                }
                reader.Close();
                return empleados;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
    }
}
