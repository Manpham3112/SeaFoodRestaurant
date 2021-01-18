using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using WebService.GenericRepositories;
using WebService.model;
using WebService.Utils;
using WebService.ViewModel;

namespace WebService.Controllers
{
    public class DichVuController: ApiController
    {
        GenericRepository<DICHVU> service = new GenericRepository<DICHVU>();
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/dichvu")]
        [HttpGet]
        // GET api/values
        public IHttpActionResult GetAll()
        {
            List<DichVuVM> result = new List<DichVuVM>();
            service.GetAll().ToList().ForEach(ct =>
            {
                result.Add(ConvertData.ConvertDichVu(ct));
            });

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/dichvu/{id}")]
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            var ctpdt = ConvertData.ConvertDichVu(service.GetById(id));
            if (ctpdt == null)
            {
                return NotFound();
            }

            return Ok(ctpdt);
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/dichvu")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] DICHVU ctpdt)
        {
            if (service.GetById(ctpdt.MADV) != null)
            {
                service.Insert(ctpdt);
                service.Save();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/dichvu/{id}")]
        [HttpDelete]
        public IHttpActionResult Delete(string id)
        {
            if (service.GetById(id) != null)
            {
                service.Delete(id);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}