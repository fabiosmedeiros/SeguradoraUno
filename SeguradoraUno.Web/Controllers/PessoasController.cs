using SeguradoraUno.Domain.Interfaces.UoW;
using System.Web.Mvc;

namespace SeguradoraUno.Web.Controllers
{
    public class PessoasController : Controller
    {
        #region "Attributes"

        private readonly IUnitOfWork _unitOfWork;

        #endregion


        #region "Constructor"

        public PessoasController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        #endregion


        #region "Actions"

        // GET: Obtendo a lista de pessoas cadastradas.
        public ActionResult Index()
        {
            var pessoasDomain = this._unitOfWork.Pessoas.GetAll();

            return View(pessoasDomain);
        }
        #endregion
    }
}