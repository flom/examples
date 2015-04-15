using System.Collections.Generic;
using System.Web.Http;
using UnityExample.Logic;

namespace UnityExample.Controllers
{
  public class ValuesController : ApiController
  {
    private IBusinessLogic logic;

    public ValuesController(IBusinessLogic logic)
    {
      this.logic = logic;
    }

    // GET api/values
    public IEnumerable<string> Get()
    {
      return logic.Foo();
    }

    // GET api/values/5
    public string Get(int id)
    {
      return "value";
    }

    // POST api/values
    public void Post([FromBody]string value)
    {
    }

    // PUT api/values/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    public void Delete(int id)
    {
    }
  }
}
