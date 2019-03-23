using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.UI
{
    //[Controller]
    //public class TesteController
    public class Teste : Controller
    {
        //[Route("teste/ping")] c/ o0 UseMvcWithDefaultRoute isso não é necessário
        public string  Ping()  => "Pong";
    }
}
