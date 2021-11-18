using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Boleto
    {

        public double ValorTotal { get; set; }
        public double ValorTaxa { get; set; }
        public string CnpjBeneficiario { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataEmissao { get; set; }
    }
}
