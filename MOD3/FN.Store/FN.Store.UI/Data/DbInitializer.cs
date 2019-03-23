﻿using FN.Store.UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.UI.Data
{
    public static class DbInitializer
    {
        public  static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(
                    new Produto() { Codigo = 1, DataCadastro = DateTime.Now, Nome = "Picanha", Preco = 80.5M, Tipo = "Alimento" },
                    new Produto() { Codigo = 2, DataCadastro = DateTime.Now, Nome = "Danone", Preco = 9.5M, Tipo = "Alimento" },
                    new Produto() { Codigo = 3, DataCadastro = DateTime.Now, Nome = "Fralda Pampers", Preco = 50.5M, Tipo = "Higiene" },
                    new Produto() { Codigo = 4, DataCadastro = DateTime.Now, Nome = "Pasta de Dente", Preco = 10.99M, Tipo = "Higiene" }
                );
        }
    }
}
