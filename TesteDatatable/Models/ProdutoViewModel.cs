using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteDatatable.Models
{
    public class ProdutoViewModel
    {
        public int id { get; set; }
        public List<ProdutoModel> produtos { get; set; }
    }
}