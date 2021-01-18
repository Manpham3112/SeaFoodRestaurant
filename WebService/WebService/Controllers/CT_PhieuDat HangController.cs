using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService.GenericRepositories;
using WebService.model;
using WebService.Utils;
using WebService.ViewModel;

namespace WebService.Controllers
{
    public class ValuesController : ApiController
    {
        GenericRepository<CT_PHIEUDATHANG> service = new GenericRepository<CT_PHIEUDATHANG>();

        [Route("api/chitietphieudathang")]
        [HttpGet]
        // GET api/values
        public IHttpActionResult GetAll()
        {
            List<CT_PhieuDatHangVM> result = new List<CT_PhieuDatHangVM>();
            service.GetAll().ToList().ForEach(ct =>
            {
                result.Add(ConvertData.ConvertCT_PhieuDatHang(ct));
            });

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [Route("api/chitietphieudathang/{id}")]
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            var ctpdt = ConvertData.ConvertCT_PhieuDatHang(service.GetById(id));
            if (ctpdt == null)
            {
                return NotFound();
            }

            return Ok(ctpdt);
        }

        [Route("api/chitietphieudathang")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] CT_PHIEUDATHANG ctpdt)
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

        [Route("api/chitietphieudathang/{id}")]
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
