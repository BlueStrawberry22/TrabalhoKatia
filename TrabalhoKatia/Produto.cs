using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoKatia
{
    internal class Produto
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string DataValidade { get; set; }
        public string Preco { get; set; }
        public string QtdEstoque { get; set; }


        public Produto(string codigo, string descricao, string datavalidade, string preco, string qtdestoque)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.DataValidade = datavalidade;  
            this.Preco = preco;
            this.QtdEstoque = qtdestoque;
        }

    }
}
