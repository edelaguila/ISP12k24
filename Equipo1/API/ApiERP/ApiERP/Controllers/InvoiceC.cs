using Microsoft.AspNetCore.Mvc;

using ApiERP.Models.Templates;
using ApiERP.Models;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceC : ControllerBase
    {
        ProveedorSentence prv = new ProveedorSentence();
        // GET: api/<InvController>
        [HttpGet]
        public IEnumerable<InvoiceP> Get()
        {
            return prv.getAllInvoices().ToList();
        }

        // GET api/<InvController>/5
        [HttpGet("{id}")]
        public InvoiceP Get(string id)
        {
            return prv.getInvoiceP(id);
        }

        // POST api/<InvController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<InvController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InvController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
