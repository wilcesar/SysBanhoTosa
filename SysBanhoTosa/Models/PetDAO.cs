using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Models
{
    class PetDAO
    {
        /// <summary>
        /// Utilizado para leitura do arquivo de texto
        /// </summary>
        StreamWriter stwArquivo;

        /// <summary>
        /// Caminho do arquivo de texto.
        /// </summary>
        string strCaminhoArquivo = Directory.GetCurrentDirectory() + "\\arqPets.txt";

        /// <summary>
        /// Separador dos campos vindos do arquivo de texto.
        /// </summary>
        const string SEPARADOR = "|";

        /// <summary>
        /// Verifica se o arquivo texto existe, senão o cria. 
        /// </summary>
        private void VerificaArquivoExiste()
        {
            if (File.Exists(strCaminhoArquivo))
            {
                stwArquivo = File.AppendText(strCaminhoArquivo);
            }
            else
            {
                stwArquivo = File.CreateText(strCaminhoArquivo);
            }
        }

        /// <summary>
        /// Deleta o arquivo de texto.
        /// </summary>
        public void LimparArquivoPets()
        {
            File.Delete(strCaminhoArquivo);
        }

        /// <summary>
        /// Adiciona uma linha nova ao arquivo texto.
        /// </summary>
        /// <param name="pLinha">String contendo a linha a ser adicionada.</param>
        public void AdicionarLinhaPet(string pLinha)
        {
            VerificaArquivoExiste();
            stwArquivo.WriteLine(pLinha);
            stwArquivo.Close();
        }

        /// <summary>
        /// Lee o arquivo texto extraindo suas linhas.
        /// </summary>
        /// <returns>Retorna as linhas do arquivo texto.</returns>
        public IEnumerable<string> GetPets()
        {
            if (!File.Exists(strCaminhoArquivo))
            {
                File.CreateText(strCaminhoArquivo);
            };
            return File.ReadLines(strCaminhoArquivo);
        }
    }
}
