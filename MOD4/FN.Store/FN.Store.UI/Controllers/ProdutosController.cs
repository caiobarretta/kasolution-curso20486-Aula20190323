using FN.Store.UI.Data;
using FN.Store.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.UI.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly StoreDataContext _ctx;

        public ProdutosController(IConfiguration config) => _ctx = new StoreDataContext(config);

        public ViewResult Index()
        {
            var data = _ctx.Produtos.ToList();
            return View(data);
        }
    }
}
