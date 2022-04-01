using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _0projeto_web.Models;

namespace _0projeto_web.Controllers
{
    public class ClientesController : Controller
    {
        [Route("/cliente/cadastrar")]
        public IActionResult CadastrarCliente()
        {
            return View();
        }
    }
}
