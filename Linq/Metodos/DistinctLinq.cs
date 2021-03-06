﻿using Linq.Classes;
using Linq.Interfaces;
using System;
using System.Linq;

namespace Linq.Metodos
{
    public class DistinctLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("DISTINCT");

            string[] paises = { "BR", "br", "eua", "uk", "UK", "BR" };

            #region Distinct

            Titulo.ExibirSub("Padrão");

            var paisesDistinct = paises.Distinct();

            foreach (var item in paisesDistinct)
                Console.WriteLine(item);

            #endregion

            #region OrdinalIgnoreCase

            Titulo.ExibirSub("OrdinalIgnoreCase");

            var paisesIgnore = paises.Distinct(StringComparer.OrdinalIgnoreCase);

            foreach (var item in paisesIgnore)
                Console.WriteLine(item);

            #endregion

            #region DistinctComplexo

            Titulo.ExibirSub("Vendedores");

            // Todo: Distinct para tipo complexo
            var vendedoresDistinct = Vendedor.ObterTodos()
                                        .Select(x => new {
                                            Id = x.Id,
                                            PrimeiroNome = x.PrimeiroNome,
                                            UltimoNome = x.UltimoNome,
                                            VendasSemestrais = x.VendasSemestrais,
                                            Sexo = x.Sexo,
                                            RegiaoId = x.RegiaoId
                                        })
                                        .Distinct();

            foreach (var item in vendedoresDistinct)
                Console.WriteLine(item.Id);

            #endregion
        }
    }
}