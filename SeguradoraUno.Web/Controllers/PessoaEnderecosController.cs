using SeguradoraUno.Domain.Interfaces.UoW;
using System.Web.Mvc;

namespace SeguradoraUno.Web.Controllers
{
    public class PessoaEnderecosController : Controller
    {
        #region "Attributes"

        private readonly IUnitOfWork _unitOfWork;

        #endregion


        #region "Constructor"

        public PessoaEnderecosController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        #endregion


        #region "Methods"
                
        // GET: Obtendo a lista de pessoas e endereços.
        public ActionResult Index()
        {
            var pessoaEnderecosDomain = this._unitOfWork.PessoaEnderecos.GetPessoaEnderecos();

            return View(pessoaEnderecosDomain);
        }

        #endregion
    }
}