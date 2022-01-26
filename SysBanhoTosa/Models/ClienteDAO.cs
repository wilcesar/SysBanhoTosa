using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SysBanhoTosa.Models.Classes;

namespace SysBanhoTosa.Models
{
    class ClienteDAO
    {
        StreamWriter stwArquivo;
        const string CAMINHO_ARQUIVO = "E:\\Projetos\\SysBanhoTosa\\SysBanhoTosa\\Tables\\arqClientes.txt";
        const string SEPARADOR = "|";
        private void VerificaArquivoExiste()
        {
            if (File.Exists(CAMINHO_ARQUIVO))            
                stwArquivo = File.AppendText(CAMINHO_ARQUIVO);
                                     
            else            
                stwArquivo = File.CreateText(CAMINHO_ARQUIVO);
        }            
        public void LimparArquivoClientes()
        {
            File.Delete(CAMINHO_ARQUIVO);                            
        }
        public void AdicionarLinhaCliente( string plinha)
        {
            VerificaArquivoExiste();
            stwArquivo.WriteLine(plinha);
            stwArquivo.Close();
        }
        public IEnumerable<string> GetClientes()
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
