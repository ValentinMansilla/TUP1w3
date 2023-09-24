using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
{

}
namespace Transporte.Acceso_Datos
{
    
    public class DBhelper
    {
        private SqlConnection cnn;

        public DBhelper()
        {
            cnn = new SqlConnection(@"");
        }
    }
}
