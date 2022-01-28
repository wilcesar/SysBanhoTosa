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
        PetDAO objPetDAO = new PetDAO();
        ClienteController objClienteController = new ClienteController();

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
        private string GetLinhaObj(Pet pPet)
        {
            return pPet.Id + SEPARADOR +
                pPet.Nome + SEPARADOR +
                pPet.Especie + SEPARADOR +
                pPet.Raca+SEPARADOR+
                pPet.Tutor.Id+SEPARADOR+
                pPet.Situacao+SEPARADOR;
        }
        public List<Pet> GetPets()
        {
            List<Pet> lstPets = new List<Pet>();

            foreach (string strLinha in objPetDAO.GetPets())
            {
                string[] strArrayArquivo = strLinha.Split('|');

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

            return lstPets;
        }
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
        public Pet GetPetById(int pId)
        {
            Pet objPet = new Pet();
            foreach (string strLinha in objPetDAO.GetPets())
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
    }
}
