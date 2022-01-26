using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Models
{
    class ServicoDAO
    {
        StreamWriter stwArquivo;
        const string CAMINHO_ARQUIVO = "E:\\Projetos\\SysBanhoTosa\\SysBanhoTosa\\Tables\\arqServicos.txt";
        const string SEPARADOR = "|";
        private void VerificaArquivoExiste()
        {
            if (File.Exists(CAMINHO_ARQUIVO))
                stwArquivo = File.AppendText(CAMINHO_ARQUIVO);

            else
                stwArquivo = File.CreateText(CAMINHO_ARQUIVO);
        }
        public void LimparArquivoServicos()
        {
            File.Delete(CAMINHO_ARQUIVO);
        }
        public void AdicionarLinhaServico(string plinha)
        {
            VerificaArquivoExiste();
            stwArquivo.WriteLine(plinha);
            stwArquivo.Close();
        }
        public IEnumerable<string> GetServicos()
        {
            if (File.Exists(CAMINHO_ARQUIVO))
            {
                return File.ReadLines(CAMINHO_ARQUIVO);
            }
            else
            {
                return null;
            }
        }
    }
}
