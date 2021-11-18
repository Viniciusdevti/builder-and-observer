using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Service
{
    public class GeradorBoletoPdf : IAcaoGeraBoleto
    {
        public void Executa(Boleto boleto)
        {
            Console.WriteLine("Pdf gerado com sucesso");
            Console.WriteLine($"Valor : R$ {boleto.ValorTotal}");
            Console.WriteLine($"Emitido em: {boleto.DataEmissao}");
            Console.WriteLine($"Data vencimento: {boleto.DataVencimento}");
        }
    }
}
