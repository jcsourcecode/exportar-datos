using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DClientes
    {
        //METODO MOSTRAR REGISTROS
        public DataTable MostrarRegistros()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection();
            try
            {
                //INSTANCIA A LA CADENA DE CONEXION
                connection.ConnectionString = DConexion.conexion;
                SqlCommand SqlCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "spmostrar_clientes",
                    CommandType = CommandType.StoredProcedure
                };

                //DECLARAMOS UN SQLDATAADAPTER PARA EJECUTAR LOS COMANDOS Y LLENAR EL DATATABLE
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dataTable);
            }
            catch (Exception)
            {
                dataTable = null;
            }
            return dataTable;
        }
    }
}
