using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024];
                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }
            }            

            Console.ReadLine();
        }

        private static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.UTF8;

            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);
        }
    }
}
