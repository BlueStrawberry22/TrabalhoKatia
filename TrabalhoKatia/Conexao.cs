using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoKatia
{
    internal class Conexao
    {
        public void BancoDados(string parametro)
        {
            MySqlConnection conecta = new MySqlConnection("server=dominio;User=root;database=bd_cadastro; password=");
            try
            {
                MySqlCommand comando = new MySqlCommand(parametro, conecta);
                conecta.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
                conecta.Close();
            }
            finally
            {
                conecta.Close();
            }

        }
    }
}
