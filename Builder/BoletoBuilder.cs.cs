using ConsoleApp1.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Builder
{
    public class BoletoBuilder : IBoletoBuilder
    {

        private readonly Boleto boleto;

        public BoletoBuilder()
        {
            this.boleto = new Boleto();
        }

        public Boleto BuildBoleto()
        {
            GeradorBoletoPdf gerarBoletoPdf = new GeradorBoletoPdf();
            gerarBoletoPdf.Executa(this.boleto);
            return  this.boleto;
        }

        public void BuildCnpjBeneficiario(string cnpj) => boleto.CnpjBeneficiario = cnpj;

        public void BuildDataEmissao() => boleto.DataEmissao = DateTime.Now;
        public void BuildDataVencimento() => boleto.DataVencimento = DateTime.Now.Date.AddDays(5);

        public void BuildValorTaxa() => boleto.ValorTaxa = 3;

        public void BuildValorTotal(double valorTotal) => boleto.ValorTotal = valorTotal + boleto.ValorTaxa;
    }
}
