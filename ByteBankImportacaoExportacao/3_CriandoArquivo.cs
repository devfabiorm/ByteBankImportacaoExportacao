using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,78945,4785.50,Gustavo Santos";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
