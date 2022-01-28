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
        string strCaminhoArquivo = Directory.GetCurrentDirectory() + "\\arqServicos.txt";
        const string SEPARADOR = "|";
        private void VerificaArquivoExiste()
        {
            if (File.Exists(strCaminhoArquivo))
                stwArquivo = File.AppendText(strCaminhoArquivo);

            else
                stwArquivo = File.CreateText(strCaminhoArquivo);
        }
        public void LimparArquivoServicos()
        {
            File.Delete(strCaminhoArquivo);
        }
        public void AdicionarLinhaServico(string plinha)
        {
            VerificaArquivoExiste();
            stwArquivo.WriteLine(plinha);
            stwArquivo.Close();
        }
        public IEnumerable<string> GetServicos()
        {
            if (!File.Exists(strCaminhoArquivo))
            {
                File.CreateText(strCaminhoArquivo);
            };
            return File.ReadLines(strCaminhoArquivo);
        }
    }
}
