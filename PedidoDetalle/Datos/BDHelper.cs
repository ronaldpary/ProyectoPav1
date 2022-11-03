using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
public class BDHelper
{
    enum ResultadoTransaccion
    {
        exito, fracaso
    }
    enum tipoConexion
    {
        simple,transaccion
    }

    private SqlConnection miConexion = new SqlConnection();
    private SqlCommand miCmd = new SqlCommand();
    private SqlTransaction miTransaccion = null;
    private ResultadoTransaccion miEstado = ResultadoTransaccion.exito;
    private tipoConexion miTipo = tipoConexion.simple;

    private string string_conexion = @"Data Source=DESKTOP-1G6OTJV\SQLEXPRESS;Initial Catalog=Almacen;Integrated Security=True";

    //"Data Source=maquis;Initial Catalog=Pedidos;User ID=avisuales1;password=avisuales1";

    private static BDHelper instance; //Unica instancia de la clase
    public static BDHelper getBDHelper()
    {
        if (instance == null)
            instance = new BDHelper();
        return instance;
    }

    public DataTable ConsultaSQL(string strSql)
    {
        //  Se utiliza para sentencias SQL del tipo Select
        //  La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();
        try
        {
            conexion.ConnectionString = string_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            //  El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos

            tabla.Load(cmd.ExecuteReader());
            //  La función retorna el objeto datatable con 0, 1 o mas registros
            return tabla;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if ((conexion.State == ConnectionState.Open))
            {
                conexion.Close();
            }

            // Dispose() libera los recursos asociados a la conexón
            conexion.Dispose();
        }

    }

    public DataTable ConsultaSqlConParametros(string strSql, List<string> sqlParam)
    {
        //  Se utiliza para sentencias SQL del tipo Select
        //  La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();
        try
        {
            conexion.ConnectionString = string_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            //  El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos

            var indice = 0;
            foreach (var param in sqlParam)
            {
                if (param != null)
                {
                    var n_param = "param" + Convert.ToString(indice + 1);
                    cmd.Parameters.AddWithValue(n_param, param);
                }
                indice++;
            }

            tabla.Load(cmd.ExecuteReader());
            //  La función retorna el objeto datatable con 0, 1 o mas registros
            return tabla;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if ((conexion.State == ConnectionState.Open))
            {
                conexion.Close();
            }

            // Dispose() libera los recursos asociados a la conexón
            conexion.Dispose();
        }

    }
    public void EjecutarSQL(string strSql)
    {
        //  Se utiliza para sentencias SQL del tipo Insert, Update, Delete
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        try
        {
            conexion.ConnectionString = string_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if ((conexion.State == ConnectionState.Open))
            {
                conexion.Close();
            }

            // Dispose() libera los recursos asociados a la conexón
            conexion.Dispose();
        }

    }
    public void EjecutarSQLConTransaccion(string strSql)
    {
        //  Se utiliza para sentencias SQL del tipo Insert, Update, Delete con transaccion.
        try
        {
            miCmd.CommandType = CommandType.Text;
            miCmd.CommandText = strSql;
            miCmd.ExecuteNonQuery();
        }
        catch 
        {
            miEstado = ResultadoTransaccion.fracaso;
        }
    }
    public void conectarConTransaccion()
    {
        miTipo = tipoConexion.transaccion;
        miEstado = ResultadoTransaccion.exito;
        miConexion.ConnectionString = string_conexion;
        miConexion.Open();
        miTransaccion = miConexion.BeginTransaction();
        miCmd.Transaction = miTransaccion;
        miCmd.Connection = miConexion;
    }
    public bool desconectar()
    {
        if (miTipo == tipoConexion.transaccion)
        {
            if (miEstado == ResultadoTransaccion.exito)
            {
                miTransaccion.Commit();
                MessageBox.Show("La trasacción resultó con éxito...");
            }
            else
            {
                miTransaccion.Rollback();
                MessageBox.Show("La trasacción no pudo realizarce...");
            }
            miTipo = tipoConexion.simple;
        }

        if ((miConexion.State == ConnectionState.Open))
        {
            miConexion.Close();
        }

        // Dispose() libera los recursos asociados a la conexón
        miConexion.Dispose();
        if (miEstado.Equals(ResultadoTransaccion.exito))
            return true;
        else
            return false;

    }
    public object ConsultaSQLScalar(string strSql)
    {
        miCmd.CommandType = CommandType.Text;
        miCmd.CommandText = strSql;
        return miCmd.ExecuteScalar();
    }
}