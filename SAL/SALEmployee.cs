using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SAL
{
    public class SALEmployee : ISALEntity
    {
        public List<DTOEmployee> Employees { get; set; }

        private SALService Servicio { get; set; }

        public SALEmployee(SALService servicio)
        {
            Servicio = servicio;
        }

        void ISALEntity.DeleteEntity()
        {
            throw new NotImplementedException();
        }

        int ISALEntity.InsertEntity()
        {
            throw new NotImplementedException();
        }

        public List<DTOEmployee> SearchEntity()
        {
            HttpResponseMessage response = Servicio.Cliente.GetAsync("Employees").Result;
            var respuesta = response.Content.ReadAsStringAsync().Result;
            Employees = JsonConvert.DeserializeObject<List<DTOEmployee>>(respuesta);
            return Employees;
        }

        void ISALEntity.UpdateEntity()
        {
            throw new NotImplementedException();
        }

    }
}
