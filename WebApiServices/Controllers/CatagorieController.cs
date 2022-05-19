using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiServices.Dtos;

namespace WebApiServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatagorieController : ControllerBase
    {
        private readonly ICatagorieService _catagorieService;

        public CatagorieController(ICatagorieService catagorieService)
        {
            _catagorieService = catagorieService;
        }


        // GET: api/Catagorie
        [HttpGet]
        public IEnumerable<CatagorieDto> Get()
        {
            return _catagorieService.GetAll().Select(x => new CatagorieDto()
            {
                Description = x.Description,
                CatagoryId = x.CategoryId,
                CatagoryName = x.CategoryName
            }).AsEnumerable();
        }
        // GET: api/Catagorie/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Catagorie
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Catagorie/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Catagorie/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
