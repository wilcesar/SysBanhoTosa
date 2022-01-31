using SysBanhoTosa.Models;
using SysBanhoTosa.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Controllers
{
    class PetController
    {
        /// <summary>
        /// Separador dos campos vindos do arquivo de texto.
        /// </summary>
        const string SEPARADOR = "|";

        /// <summary>
        /// Objeto de acesso a dados de pet.
        /// </summary>
        PetDAO objPetDAO = new PetDAO();

        /// <summary>
        /// Controller de clientes.
        /// </summary>
        ClienteController objClienteController = new ClienteController();

        /// <summary>
        /// Valida o cadastro do pet foi alimentado corretamente.
        /// </summary>
        /// <param name="pPet">Objeto contendo o pet.</param>
        /// <returns>True se os campos obrigatórios foram preenchidos corretamente.</returns>
        public Boolean ValidaPet(Pet pPet)
        {
            if (pPet.Nome == "")
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
        /// <param name="pPet">Objeto contendo o pet</param>
        /// <returns>Linha pronta para ser salva.</returns>
        private string GetLinhaObj(Pet pPet)
        {
            return pPet.Id + SEPARADOR +
                pPet.Nome + SEPARADOR +
                pPet.Especie + SEPARADOR +
                pPet.Raca+SEPARADOR+
                pPet.Tutor.Id+SEPARADOR+
                pPet.Situacao+SEPARADOR;
        }

        /// <summary>
        /// Gera lista dos pets que tem no arquivo texto.
        /// </summary>
        /// <param name="pSomenteAtivos"> Se true trás somente os ativos.</param>
        /// <returns>Lista de objetos contendo os pets.</returns>
        public List<Pet> GetPets(bool pSomenteAtivos)
        {
            List<Pet> lstPets = new List<Pet>();
            var objPetsArquivo = objPetDAO.GetPets();
            foreach (string strLinha in objPetsArquivo)
            {
                string[] strArrayArquivo = strLinha.Split('|');
                if ((pSomenteAtivos && (strArrayArquivo[5] == "ATIVO")) || !pSomenteAtivos)
                {
                    Pet objPet = new Pet();
                    objPet.Id = int.Parse(strArrayArquivo[0]);
                    objPet.Nome = strArrayArquivo[1];
                    objPet.Especie = strArrayArquivo[2];
                    objPet.Raca = strArrayArquivo[3];
                    objPet.Situacao = strArrayArquivo[5];

                    Cliente objCliente = new Cliente();
                    objCliente.Id = int.Parse(strArrayArquivo[4]);

                    objPet.Tutor = objCliente;

                    lstPets.Add(objPet);
                }
            }

            return lstPets;
        }

        /// <summary>
        /// Atualiza a lista de pets e cadastra o pet novo.
        /// </summary>
        /// <param name="pPet">Objeto com o novo pet.</param>
        /// <param name="pListPets">Lista de pets desatualizada.</param>
        public void AtualizarPet(Pet pPet, List<Pet> pListPets)
        {
            if (pPet.Id == 0)
            {
                pListPets.Add(pPet);
            }
            else
            {
                for (int intI = 0; intI <= pListPets.Count; intI++)
                {
                    if (pListPets[intI].Id == pPet.Id)
                    {
                        pListPets[intI] = pPet;
                        break;
                    }
                }
            }
            int intContador = 1;
            objPetDAO.LimparArquivoPets();
            foreach (Pet objPet in pListPets)
            {
                string strPet = intContador.ToString() + SEPARADOR +
                objPet.Nome + SEPARADOR +
                objPet.Especie + SEPARADOR +
                objPet.Raca + SEPARADOR +
                objPet.Tutor.Id+SEPARADOR+
                objPet.Situacao + SEPARADOR;

                objPetDAO.AdicionarLinhaPet(strPet);

                intContador++;
            }
        }

        /// <summary>
        /// Retorna determinado pet a partir do código.
        /// </summary>
        /// <param name="pId">Código do pet.</param>
        /// <returns>Objeto contendo o pet.</returns>
        public Pet GetPetById(int pId)
        {
            Pet objPet = new Pet();
            var objPetsArquivo = objPetDAO.GetPets();
            foreach (string strLinha in objPetsArquivo)
            {
                string[] strArrayArquivo = strLinha.Split('|');
                if (pId == int.Parse(strArrayArquivo[0]))
                {

                    objPet.Id = int.Parse(strArrayArquivo[0]);
                    objPet.Nome = strArrayArquivo[1];
                    objPet.Especie = strArrayArquivo[2];
                    objPet.Raca = strArrayArquivo[3];
                    objPet.Tutor = objClienteController.GetClienteById(int.Parse(strArrayArquivo[4]));                    
                    objPet.Situacao = strArrayArquivo[5];
                    break;
                }
            }
            return objPet;
        }
        /// <summary>
        /// Retorna determinados pets a partir do código do seu tutor.
        /// </summary>
        /// <param name="pClienteId">Código do cliente/tutor.</param>
        /// <returns>Lista de objetos contendo os pets.</returns>
        public List<Pet> GetPetsByCliente(int pClienteId)
        {
            List<Pet> lstPets = new List<Pet>();
            var objPetsArquivo = objPetDAO.GetPets();
            foreach (string strLinha in objPetsArquivo)
            {
                string[] strArrayArquivo = strLinha.Split('|');
                if (pClienteId == int.Parse(strArrayArquivo[4]))
                {
                    Pet objPet = new Pet();
                    objPet.Id = int.Parse(strArrayArquivo[0]);
                    objPet.Nome = strArrayArquivo[1];
                    objPet.Especie = strArrayArquivo[2];
                    objPet.Raca = strArrayArquivo[3];
                    objPet.Tutor = objClienteController.GetClienteById(int.Parse(strArrayArquivo[4]));
                    objPet.Situacao = strArrayArquivo[5];
                    lstPets.Add(objPet);
                }
            }
            return lstPets;
        }
    }
}
