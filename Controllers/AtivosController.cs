using System.Web.Mvc;
using testeVariacaoAtivo.Services.Interface;

namespace testeVariacaoAtivo.Controllers
{
    public class AtivosController : Controller
    {
        private readonly IAtivoService _service;

        public AtivosController(IAtivoService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BuscarAtivoPetra()
        {
            return Json(_service.BuscarAtivoPetra());
        }
    }
}