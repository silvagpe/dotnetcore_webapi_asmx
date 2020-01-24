

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcoreWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var list = new List<string>();
            list.Add("Teste 1");
            list.Add("Teste 2");
            list.Add(DateTime.Now.ToString());
            list.Add(DateTime.Now.ToString());

            return list.ToArray();
        }
    }
}