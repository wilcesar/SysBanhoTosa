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
        const string SEPARADOR = "|";
        PetDAO objPetDAO = new PetDAO();
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
                pPet.Tutor.Id;
        }
        public List<Pet> GetPets()
        {
            List<Pet> lstPets = new List<Pet>();
            int intI = 0;
            foreach (string strLinha in objPetDAO.GetPets())
            {
                string[] strArrayArquivo = strLinha.Split('|');

                Pet objPets = new Pet();
                objPets.Id = int.Parse(strArrayArquivo[0]);
                objPets.Nome = strArrayArquivo[1];
                objPets.Especie = strArrayArquivo[2];
                objPets.Raca = strArrayArquivo[3];

                Cliente objCliente = new Cliente();
                objCliente.Id = int.Parse(strArrayArquivo[4]);

                objPets.Tutor = objCliente;

                lstPets.Add(objPets);

                intI++;
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
                objPet.Tutor.Id+SEPARADOR;

                objPetDAO.AdicionarLinhaPet(strPet);

                intContador++;
            }
        }
    }
}
