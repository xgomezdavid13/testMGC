using BAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: api/Employee
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                BALEmployeeBuilder buEmployeeBuilder = new BALEmployeeBuilder();
                Object employees = buEmployeeBuilder.CalculateSalaryEmployee(id);
                return Ok(employees);
            }
            catch (NullReferenceException ex)
            {
                // TODO: task exception app control. 
                return Ok(JsonConvert.SerializeObject(string.Empty));
            }
            catch (Exception ex)
            {
                // TODO: task exception control.
                return Ok(JsonConvert.SerializeObject(string.Empty));
            }

        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}