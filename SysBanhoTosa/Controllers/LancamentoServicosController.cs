using SysBanhoTosa.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Controllers
{
    class LancamentoServicosController
    {
        
        const string SEPARADOR = "|";        
        ClienteController objClienteController = new ClienteController();
        ServicoController objServicoController = new ServicoController();
        PetController objPetController = new PetController();

        /// <summary>
        /// Realiza o lançamento do serviço prestado
        /// </summary>
        /// <param name="pLancamento"></param>
        public void SalvarLancamento(Lancamento pLancamento)
        {

        }
        
    }
}
