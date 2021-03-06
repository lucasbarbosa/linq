﻿using Linq.Classes;
using Linq.Interfaces;
using System;
using System.Linq;

namespace Linq.Metodos
{
    public class TakeLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("TAKE");

            #region Listas

            string[] paises1 = { "BR", "JP", "AU", "AL", "EUA", "URU", "FRN", "CBA" };
            string[] paises2 = { "EUA", "URU", "FRN", "BR", "JP", "AU", "AL", "CBA" };

            #endregion

            #region Take

            Titulo.ExibirSub("TAKE LINQ");
            var takeLinq = paises1.Take(3);

            foreach (var item in takeLinq)
                Console.WriteLine(item);

            Titulo.ExibirSub("TAKE SQL");
            var takeSql = (from p in paises1
                          select p).Take(3);

            foreach (var item in takeSql)
                Console.WriteLine(item);

            #endregion

            #region Take.Reverse

            Titulo.ExibirSub("TAKE.REVERSE LINQ");
            var takeReverse = paises1.Take(3).Reverse().ToList();

            foreach (var item in takeReverse)
                Console.WriteLine(item);

            #endregion

            #region TakeWhile

            Titulo.ExibirSub("TAKE_WHILE");
            var takeWhile = paises1.TakeWhile(x => x.Length == 2);

            foreach (var item in takeWhile)
                Console.WriteLine(item);

            #endregion

            #region Skip

            Titulo.ExibirSub("SKIP");
            var skip = paises1.Skip(3);

            foreach (var item in skip)
                Console.WriteLine(item);

            #endregion

            #region SkipWhile

            Titulo.ExibirSub("SKIP_WHILE");
            var skipWhile = paises2.SkipWhile(x => x.Length > 2);

            foreach (var item in skipWhile)
                Console.WriteLine(item);

            #endregion
        }
    }
}