using ApiHospitalesAzure.Data;
using ApiHospitalesAzure.Models;

namespace ApiHospitalesAzure.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;
        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }
        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in context.Hospitales
                           select datos;
            return consulta.ToList();
        }
        public Hospital FindHospital(int id)
        {
            var consulta = from datos in context.Hospitales
                           where datos.IdHospital == id
                           select datos;
            return consulta.FirstOrDefault();
        }
    }
}
