using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NClientes
    {
        //METODO MOSTRAR REGISTROS DEL CLIENTE, QUE LLAMA AL METODO MOSTRAR CLIENTES DE LA CAPA DATOS
        public static DataTable MostrarRegistros()
        {
            return new DClientes().MostrarRegistros();
        }
    }
}
