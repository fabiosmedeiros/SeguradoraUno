using SeguradoraUno.Domain.Interfaces.UoW;
using System.Web.Mvc;

namespace SeguradoraUno.Web.Controllers
{
    public class PessoaContatosController : Controller
    {
        #region "Attributes"

        private readonly IUnitOfWork _unitOfWork;

        #endregion


        #region "Constructor"

        public PessoaContatosController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        #endregion


        #region "Methods"

        // GET: Obtendo a lista de pessoas e contatos.
        public ActionResult Index()
        {
            var pessoaContatosDomain = this._unitOfWork.PessoaContatoRepository.GetPessoaContatos();

            return View(pessoaContatosDomain);
        }

        #endregion
    }
}