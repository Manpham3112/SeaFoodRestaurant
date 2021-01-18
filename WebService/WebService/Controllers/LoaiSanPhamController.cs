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
    public class LoaiSanPhamController : ApiController
    {

        GenericRepository<LOAISP> service = new GenericRepository<LOAISP>();
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/loaisanpham")]
        [HttpGet]
        // GET api/values
        public IHttpActionResult GetAll()
        {
            List<LoaiSanPhamVM> result = new List<LoaiSanPhamVM>();
            service.GetAll().ToList().ForEach(loaiSP =>
            {
                result.Add(ConvertData.ConvertLoaiSP(loaiSP));
            });

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/loaisanpham/{id}")]
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            var ctpdt = ConvertData.ConvertLoaiSP(service.GetById(id));
            if (ctpdt == null)
            {
                return NotFound();
            }

            return Ok(ctpdt);
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/loaisanpham")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] LOAISP loaisp)
        {
            if (service.GetById(loaisp.MALSP) != null)
            {
                service.Insert(loaisp);
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
        [Route("api/loaisanpham/{id}")]
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