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
        string strCaminhoArquivo = Directory.GetCurrentDirectory()+"\\arqClientes.txt";
        const string SEPARADOR = "|";
        private void VerificaArquivoExiste()
        {
            if (File.Exists(strCaminhoArquivo))            
                stwArquivo = File.AppendText(strCaminhoArquivo);
                                     
            else            
                stwArquivo = File.CreateText(strCaminhoArquivo);
        }            
        public void LimparArquivoClientes()
        {
            File.Delete(strCaminhoArquivo);                            
        }
        public void AdicionarLinhaCliente( string plinha)
        {
            VerificaArquivoExiste();
            stwArquivo.WriteLine(plinha);
            stwArquivo.Close();
        }
        public IEnumerable<string> GetClientes()
        {
            if (!File.Exists(strCaminhoArquivo))
            {
                File.CreateText(strCaminhoArquivo);
            };    
            return File.ReadLines(strCaminhoArquivo);
            
        }
    }
}
