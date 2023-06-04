using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Projesi
{
    public class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-0IB4R2ME;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
    }
    }
}
