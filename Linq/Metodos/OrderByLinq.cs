﻿using Linq.Classes;
using Linq.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Metodos
{
    public class OrderByLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("ORDER_BY");

            List<Estudante> estudantes = Estudante.ObterEstudantes();

            #region Linq

            Titulo.ExibirSub("LINQ");
            var ordenarLinq = estudantes
                            .OrderBy(x => x.Sexo)
                            .ThenByDescending(x => x.Materias.Count)
                            .ThenBy(x => x.Nome);

            foreach (var item in ordenarLinq)
                Console.WriteLine($"{item.Nome} \t {item.Sexo} \t {item.Materias.Count}");

            #endregion

            #region Sql

            Titulo.ExibirSub("SQL");
            var ordenarSql = (from e in estudantes
                      orderby e.Sexo, e.Materias.Count descending
                      select e).ThenBy(x => x.Nome);

            foreach (var item in ordenarSql)
                Console.WriteLine($"{item.Nome} \t {item.Sexo} \t {item.Materias.Count}");

            #endregion
        }
    }
}