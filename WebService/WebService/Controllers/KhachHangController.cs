using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebService.GenericRepositories;
using WebService.model;
using WebService.Utils;
using WebService.ViewModel;

namespace WebService.Controllers
{
    public class KhachHangController: ApiController
    {
        GenericRepository<KHACHHANG> service = new GenericRepository<KHACHHANG>();
        [Route("api/khachhang")]
        [HttpGet]
        // GET api/values
        public IHttpActionResult GetAll()
        {
            List<KhachHangVM> result = new List<KhachHangVM>();
            service.GetAll().ToList().ForEach(ct =>
            {
                result.Add(ConvertData.ConvertKhachHang(ct));
            });

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [Route("api/khachhang/{id}")]
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            var ctpdt = ConvertData.ConvertKhachHang(service.GetById(id));
            if (ctpdt == null)
            {
                return NotFound();
            }

            return Ok(ctpdt);
        }
        [Route("api/khachhang")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] KHACHHANG ctpdt)
        {
            if (service.GetById(ctpdt.MAKH) == null)
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

        [Route("api/khachhang/{id}")]
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