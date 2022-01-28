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
        /// <summary>
        /// Separador dos campos vindos do arquivo de texto.
        /// </summary>
        const string SEPARADOR = "|";

        /// <summary>
        /// Objeto de acesso a dados de cliente.
        /// </summary>
        ClienteDAO objClienteDAO = new ClienteDAO();

        /// <summary>
        /// Valida o cadastro do cliente.
        /// </summary>
        /// <param name="pCliente">Objeto do cliente.</param>
        /// <returns>True se os campos obrigatórios foram preenchidos corretamente.</returns>
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

        /// <summary>
        /// Gera a linha para ser salva no arquivo texto.
        /// </summary>
        /// <param name="pCliente">Objeto contendo o cliente.</param>
        /// <returns>Linha pronta para ser salva.</returns>
        /// <summary>
        private string GetLinhaObj(Cliente pCliente)
        {
            return pCliente.Id + SEPARADOR +
                pCliente.Nome + SEPARADOR +
                pCliente.Email + SEPARADOR +
                pCliente.Telefone + SEPARADOR +
                pCliente.Endereco.Logradouro + SEPARADOR +
                pCliente.Endereco.Numero + SEPARADOR +
                pCliente.Endereco.Bairro + SEPARADOR +
                pCliente.Endereco.Complemento + SEPARADOR +
                pCliente.Endereco.Cep + SEPARADOR +
                pCliente.Endereco.Cidade + SEPARADOR +
                pCliente.Endereco.Uf + SEPARADOR;
        }
        /// <summary>
        /// Gera lista dos clientes que tem no arquivo texto.
        /// </summary>
        /// <returns>Lista de objetos contendo os clientes.</returns>
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

        /// <summary>
        /// Retorna determinado cliente a partir do código.
        /// </summary>
        /// <param name="pId">Código do cliente.</param>
        /// <returns>Objeto contendo o cliente.</returns>
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

        /// <summary>
        /// Atualiza a lista de clientes e cadastra o cliente novo.
        /// </summary>
        /// <param name="pCliente">Objeto com o novo cliente.</param>
        /// <param name="pListClientes">Lista de clientes desatualizada.</param>
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
        
    }
}
