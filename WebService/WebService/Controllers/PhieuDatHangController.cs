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
    public class PhieuDatHangController : ApiController
    {
        GenericRepository<PHIEUDATHANG> service = new GenericRepository<PHIEUDATHANG>();
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/phieudathang")]
        [HttpGet]
        // GET api/values
        public IHttpActionResult GetAll()
        {
            List<PhieuDatHangVM> result = new List<PhieuDatHangVM>();
            service.GetAll().ToList().ForEach(ct =>
            {
                result.Add(ConvertData.ConvertPhieuDatHang(ct));
            });

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/phieudathang/{id}")]
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            var ctpdt = ConvertData.ConvertPhieuDatHang(service.GetById(id));
            if (ctpdt == null)
            {
                return NotFound();
            }

            return Ok(ctpdt);
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/phieudathang")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] PHIEUDATHANG ctpdt)
        {
            if (service.GetById(ctpdt.MAPDH) != null)
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
        [Route("api/phieudathang/{id}")]
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