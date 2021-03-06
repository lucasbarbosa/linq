﻿using Linq.Classes;
using Linq.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Metodos
{
    public class IEnumerableLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("IENUMERABLE");

            List<Vendedor> vendedores = Vendedor.ObterTodos().ToList();

            var consultaSql = from v in vendedores
                           where v.Sexo == "M"
                           select v;

            var consultaLinq = (from v in vendedores
                              where v.Sexo == "M"
                              select v).ToList();

            vendedores.Add(new Vendedor() {
                Id = 8,
                PrimeiroNome = "Joselito",
                UltimoNome = "Santos",
                Sexo = "M",
                VendasSemestrais = 700
            });

            Titulo.ExibirSub("Consuta SQL");
            foreach (var item in consultaSql)
                Console.WriteLine(item.PrimeiroNome);

            Titulo.ExibirSub("Consuta LINQ");
            foreach (var item in consultaLinq)
                Console.WriteLine(item.PrimeiroNome);
        }
    }
}