using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Models
{
    class LancamentoServicosDAO
    {
        /// <summary>
        /// Utilizado para leitura do arquivo de texto.
        /// </summary>
        StreamWriter stwArquivo;

        /// <summary>
        /// Caminho do arquivo de texto.
        /// </summary>
        string strCaminhoArquivo = Directory.GetCurrentDirectory() + "\\arqLancamentos.txt";

        /// <summary>
        /// Separador dos campos vindos do arquivo de texto.
        /// </summary>
        const string SEPARADOR = "|";
       
        /// <summary>
        /// Verifica se o arquivo texto existe, senão o cria.
        /// </summary>
        /// <param name="pArquivo">Arquivo texto.</param>
        private void VerificaArquivoExiste(string pArquivo)
        {
            if (File.Exists(pArquivo)) 
            { 
                stwArquivo = File.AppendText(pArquivo);
            }
            else
            {
                stwArquivo = File.CreateText(pArquivo);
            }                
        }

        /// <summary>
        /// Deleta o arquivo de texto
        /// </summary>
        public void LimparArquivoLancamentos()
        {
            File.Delete(strCaminhoArquivo);
        }

        /// <summary>
        /// Adiciona uma linha nova ao arquivo texto.
        /// </summary>
        /// <param name="pLinha">String contendo a linha a ser adicionada.</param>
        /// /// <param name="pNomeArquivo">String contendo o nome do arquivo de texto.</param>
        public void AdicionarLinhaLancamento(string pLinha, string pNomeArquivo)
        {
            if(pNomeArquivo == "")
            {
                VerificaArquivoExiste(strCaminhoArquivo);
            }
            else
            {
                VerificaArquivoExiste(Directory.GetCurrentDirectory()+pNomeArquivo);
            }            
            stwArquivo.WriteLine(pLinha);
            stwArquivo.Close();
        }

        /// <summary>
        /// Lee o arquivo texto extraindo suas linhas.
        /// </summary>
        /// <returns>Retorna as linhas do arquivo texto.</returns>
        public IEnumerable<string> GetLancamentos()
        {
            if (!File.Exists(strCaminhoArquivo))
            {
                File.CreateText(strCaminhoArquivo);
            };
            return File.ReadLines(strCaminhoArquivo);
        }

    }
}
