using backend_lab.Handlers;
using backend_lab_C24721.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_lab_C24721.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly PaisesHandler _paisesHander;

        public PaisesController()
        {
            _paisesHander = new PaisesHandler();
        }
        [HttpGet]
        public List<PaisModel> Get()
        {
            var paises = _paisesHander.ObtenerPaises();
            return paises;
        }
    }
}
