﻿using Linq.Classes;
using Linq.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Metodos
{
    public class SelectManyLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("SELECTMANY");

            var estudantes = Estudante.ObterEstudantes();

            Titulo.ExibirSub("Select");

            IEnumerable<List<string>> materias = estudantes.Select(x => x.Materias);

            foreach (var item in materias)
                foreach(var m in item)
                    Console.WriteLine(m);

            Titulo.ExibirSub("SelectMany");

            IEnumerable<string> materiasDistinct = estudantes.SelectMany(x => x.Materias).Distinct();

            foreach (var item in materiasDistinct)
                Console.WriteLine(item);
        }
    }
}