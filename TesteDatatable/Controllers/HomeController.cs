using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteDatatable.Models;

namespace TesteDatatable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProdutoViewModel prods = new ProdutoViewModel();

            prods.produtos = GetProdutos();

            return View(prods);
        }

        [HttpPost]
        public ActionResult Index(ProdutoViewModel prods)
        {

            return View();
        }

        public List<ProdutoModel> GetProdutos()
        {
            List<ProdutoModel> produtos = new List<ProdutoModel>();
            ProdutoModel p1 = new ProdutoModel
            {
                Codigo = 1,
                Nome = "Computador"
            };
            ProdutoModel p2 = new ProdutoModel
            {
                Codigo = 2,
                Nome = "Teclado"
            };
            ProdutoModel p3 = new ProdutoModel
            {
                Codigo = 3,
                Nome = "Mouse"
            };
            ProdutoModel p4 = new ProdutoModel
            {
                Codigo = 4,
                Nome = "Monitor"
            };
            ProdutoModel p5 = new ProdutoModel
            {
                Codigo = 5,
                Nome = "Headset"
            };
            ProdutoModel p6 = new ProdutoModel
            {
                Codigo = 6,
                Nome = "Placa de Video"
            };
            ProdutoModel p7 = new ProdutoModel
            {
                Codigo = 7,
                Nome = "Caneta"
            };
            ProdutoModel p8 = new ProdutoModel
            {
                Codigo = 8,
                Nome = "pendrive"
            };
            ProdutoModel p9 = new ProdutoModel
            {
                Codigo = 9,
                Nome = "relogio"
            };
            ProdutoModel p10 = new ProdutoModel
            {
                Codigo = 10,
                Nome = "cooler"
            };
            ProdutoModel p11 = new ProdutoModel
            {
                Codigo = 11,
                Nome = "SSD"
            };
            ProdutoModel p12 = new ProdutoModel
            {
                Codigo = 12,
                Nome = "memoria"
            };

            produtos.Add(p1);
            produtos.Add(p2);
            produtos.Add(p3);
            produtos.Add(p4);
            produtos.Add(p5);
            produtos.Add(p6);
            produtos.Add(p7);
            produtos.Add(p8);
            produtos.Add(p9);
            produtos.Add(p10);
            produtos.Add(p11);
            produtos.Add(p12);

            return produtos;
        }

        
    }
}