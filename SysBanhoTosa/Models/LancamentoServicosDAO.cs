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
        /// Utilizado para leitura do arquivo de texto
        /// </summary>
        StreamWriter stwArquivo;

        /// <summary>
        /// Caminho do arquivo de texto
        /// </summary>
        const string CAMINHO_ARQUIVO = "E:\\Projetos\\SysBanhoTosa\\SysBanhoTosa\\Tables\\arqLancamentos.txt";

        /// <summary>
        /// Separador dos campos vindos do arquivo de texto
        /// </summary>
        const string SEPARADOR = "|";

        /// <summary>
        /// Verifica se o arquivo texto existe, senão o cria 
        /// </summary>
        private void VerificaArquivoExiste()
        {
            if (File.Exists(CAMINHO_ARQUIVO)) 
            { 
                stwArquivo = File.AppendText(CAMINHO_ARQUIVO);
            }
            else
            {
                stwArquivo = File.CreateText(CAMINHO_ARQUIVO);
            }                
        }

        /// <summary>
        /// Deleta o arquivo de texto
        /// </summary>
        public void LimparArquivoLancamentos()
        {
            File.Delete(CAMINHO_ARQUIVO);
        }

        /// <summary>
        /// Adiciona uma linha nova ao arquivo texto
        /// </summary>
        /// <param name="pLinha">String contendo a linha a ser adicionada</param>
        public void AdicionarLinhaLancamento(string pLinha)
        {
            VerificaArquivoExiste();
            stwArquivo.WriteLine(pLinha);
            stwArquivo.Close();
        }

        /// <summary>
        /// Lee o arquivo texto extraindo suas linhas
        /// </summary>
        /// <returns>Retorna as linhas do arquivo texto</returns>
        public IEnumerable<string> GetLancamentos()
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
