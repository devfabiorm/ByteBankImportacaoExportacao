using ByteBankImportacaoExportacao.Modelos;
using System;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void UsandoStreamReader()
        {
            var caminhdoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(caminhdoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverterParaContaCorrente(linha);

                    Console.WriteLine(contaCorrente);
                }
            }

            Console.ReadLine();
        }

        static ContaCorrente ConverterParaContaCorrente(string linha)
        {
            var campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2];
            var nomeTitular = campos[3];

            var agenciaComoint = int.Parse(agencia);
            var numeroComoInt = int.Parse(numero);

            var saldoComoDouble = double.Parse(saldo);

            var cliente = new Cliente();
            cliente.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComoint, numeroComoInt);
            resultado.Depositar(saldoComoDouble);
            resultado.Titular = cliente;

            return resultado;
        }
    }
}
