using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebService.GenericRepositories;
using WebService.model;
using WebService.Utils;
using WebService.ViewModel;
using System.Web.Http.Cors;

namespace WebService.Controllers
{
    public class SanPhamController: ApiController
    {
        GenericRepository<SANPHAM> service = new GenericRepository<SANPHAM>();
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/sanpham")]
        [HttpGet]
        // GET api/values
        public IHttpActionResult GetAll()
        {
            List<SanPhamVM> result = new List<SanPhamVM>();
            service.GetAll().ToList().ForEach(ct =>
            {
                result.Add(ConvertData.ConvertSanPham(ct));
            });

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [Route("api/sanpham/{id}")]
        [HttpGet]
        public IHttpActionResult Get(string id)     
        {
            var ctpdt = ConvertData.ConvertSanPham(service.GetById(id));
            if (ctpdt == null)
            {
                return NotFound();
            }

            return Ok(ctpdt);
        }
        [Route("api/sanpham")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] SANPHAM ctpdt)
        {
            if (service.GetById(ctpdt.MASP) != null)
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

        [Route("api/sanpham/{id}")]
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