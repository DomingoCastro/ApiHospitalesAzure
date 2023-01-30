using ApiHospitalesAzure.Models;
using ApiHospitalesAzure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiHospitalesAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private RepositoryHospital repo;
        public HospitalController(RepositoryHospital repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public ActionResult<List<Hospital>> GetHospitales()
        {
           return this.repo.GetHospitales();
        }
        [HttpGet("{id}")]
        public ActionResult<Hospital> FindHospital(int id)
        {
            return this.repo.FindHospital(id);
        }
    }
}
