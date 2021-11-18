using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Builder
{
    public interface IBoletoBuilder
    {
        void BuildDataVencimento();
        void BuildDataEmissao();
        void BuildCnpjBeneficiario(string cnpj);
        void BuildValorTotal(double valorTotal);
        void BuildValorTaxa();
        Boleto BuildBoleto();

    }
}
