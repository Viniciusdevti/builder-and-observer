using ConsoleApp1.Builder;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            BoletoBuilder boletoBuilder = new BoletoBuilder();

            boletoBuilder.BuildCnpjBeneficiario("00.000.000/00001-00");
            boletoBuilder.BuildDataEmissao();
            boletoBuilder.BuildDataVencimento();
            boletoBuilder.BuildValorTaxa();
            boletoBuilder.BuildValorTotal(500);
            boletoBuilder.BuildBoleto();

            Console.ReadLine();

        }
    }
}
