using SysBanhoTosa.Models;
using SysBanhoTosa.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Controllers
{
    class ClienteController
    {
        const string SEPARADOR = "|";
        ClienteDAO objClienteDAO = new ClienteDAO();

        public Boolean ValidaCliente(Cliente pCliente)
        {
            if (pCliente.Nome == "")
            {
                return false;
            }
            else if (pCliente.Telefone == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private string GetLinhaObj(Cliente pClinete)
        {
            return pClinete.Id + SEPARADOR +
                pClinete.Nome + SEPARADOR +
                pClinete.Email + SEPARADOR +
                pClinete.Telefone + SEPARADOR +
                pClinete.Endereco.Logradouro + SEPARADOR +
                pClinete.Endereco.Numero + SEPARADOR +
                pClinete.Endereco.Bairro + SEPARADOR +
                pClinete.Endereco.Complemento + SEPARADOR +
                pClinete.Endereco.Cep + SEPARADOR +
                pClinete.Endereco.Cidade + SEPARADOR +
                pClinete.Endereco.Uf + SEPARADOR;
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> lstClientes = new List<Cliente>();
            foreach (string strLinha in objClienteDAO.GetClientes())
            {
                string[] strArrayArquivo = strLinha.Split('|');

                Cliente objCliente = new Cliente();
                objCliente.Id = int.Parse(strArrayArquivo[0]);
                objCliente.Nome = strArrayArquivo[1];
                objCliente.Email = strArrayArquivo[2];
                objCliente.Telefone = strArrayArquivo[3];
                objCliente.Situacao = strArrayArquivo[11];

                Endereco objEndereco = new Endereco();
                objEndereco.Logradouro = strArrayArquivo[4];
                objEndereco.Numero = strArrayArquivo[5];
                objEndereco.Bairro = strArrayArquivo[6];
                objEndereco.Complemento = strArrayArquivo[7];
                objEndereco.Cep = strArrayArquivo[8];
                objEndereco.Cidade = strArrayArquivo[9];
                objEndereco.Uf = strArrayArquivo[10];

                objCliente.Endereco = objEndereco;

                lstClientes.Add(objCliente);

            }
            

            return lstClientes;            
        }
        public Cliente GetClienteById(int pId)
        {
            Cliente objCliente = new Cliente();
            foreach (string strLinha in objClienteDAO.GetClientes())
            {
                string[] strArrayArquivo = strLinha.Split('|');
                if (pId == int.Parse(strArrayArquivo[0]))
                {
                    
                    objCliente.Id = int.Parse(strArrayArquivo[0]);
                    objCliente.Nome = strArrayArquivo[1];
                    objCliente.Email = strArrayArquivo[2];
                    objCliente.Telefone = strArrayArquivo[3];

                    Endereco objEndereco = new Endereco();
                    objEndereco.Logradouro = strArrayArquivo[4];
                    objEndereco.Numero = strArrayArquivo[5];
                    objEndereco.Bairro = strArrayArquivo[6];
                    objEndereco.Complemento = strArrayArquivo[7];
                    objEndereco.Cep = strArrayArquivo[8];
                    objEndereco.Cidade = strArrayArquivo[9];
                    objEndereco.Uf = strArrayArquivo[10];

                    objCliente.Endereco = objEndereco;
                    break;
                }
            }
            return objCliente;
        }

        public void AtualizarCliente(Cliente pCliente, List<Cliente> pListClientes)
        {
            if (pCliente.Id == 0)
            {
                pListClientes.Add(pCliente);
            }
            else
            {
                for (int intI = 0; intI <= pListClientes.Count; intI++)
                {
                    if (pListClientes[intI].Id == pCliente.Id)
                    {
                        pListClientes[intI] = pCliente;
                        break;
                    }
                }
            }

            int intContador = 1;
            objClienteDAO.LimparArquivoClientes();
            foreach (Cliente objCliente in pListClientes)
            {
                string strCliente = intContador.ToString() + SEPARADOR +
                objCliente.Nome + SEPARADOR +
                objCliente.Email + SEPARADOR +
                objCliente.Telefone + SEPARADOR +
                objCliente.Endereco.Logradouro + SEPARADOR +
                objCliente.Endereco.Numero + SEPARADOR +
                objCliente.Endereco.Bairro + SEPARADOR +
                objCliente.Endereco.Complemento + SEPARADOR +
                objCliente.Endereco.Cep + SEPARADOR +
                objCliente.Endereco.Cidade + SEPARADOR +
                objCliente.Endereco.Uf + SEPARADOR+
                objCliente.Situacao + SEPARADOR;

                objClienteDAO.AdicionarLinhaCliente(strCliente);

                intContador++;
            }
        }
        public void ExcluirCliente(Cliente pCliente)
        {
            objClienteDAO.LimparArquivoClientes();
            foreach (Cliente objCliente in GetClientes())
            {
                if (objCliente.Id != pCliente.Id)
                {
                    objClienteDAO.AdicionarLinhaCliente(GetLinhaObj(objCliente));
                }
            }

        }
    }
}
