using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoKatia
{
    internal class Alimenticio:Produto
    {
        public string medida { get; set; }
        public string tipo { get; set; }

        public Alimenticio(string medida, string tipo, string codigo, string descricao, string datavalidade, string preco, string qtdestoque) : base(codigo, descricao, datavalidade, preco, qtdestoque)
        {
            this.medida = medida;
            this.tipo = tipo;
        }
    }
}
