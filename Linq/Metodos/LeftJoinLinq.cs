﻿using Linq.Classes;
using Linq.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Metodos
{
    public class LeftJoinLinq : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("LEFT_JOIN");

            List<Vendedor> vendedores = Vendedor.ObterTodos().ToList();

            #region Linq

            Titulo.ExibirSub("LINQ");

            var vendedoresRegiaoLinq = vendedores
                            .GroupJoin(Regiao.ObterTodos(),
                                    v => v.RegiaoId,
                                    r => r.Id,
                                    (ve, re) => new
                                    {
                                        ve,
                                        re
                                    })
                                    .SelectMany(x => x.re.DefaultIfEmpty(),
                                    (vendedor,regiao) => new
                                    {
                                        Nome = $"{vendedor.ve.PrimeiroNome} {vendedor.ve.UltimoNome}",
                                        RegiaoNome = (regiao == null) ? "Sem região" : regiao.Nome
                                    });

            foreach (var item in vendedoresRegiaoLinq)
                Console.WriteLine($"{item.Nome} \t {item.RegiaoNome}");

            #endregion

            #region Sql

            Titulo.ExibirSub("SQL");

            var vendedoresRegiaoSql = from v in vendedores
                           join r in Regiao.ObterTodos()
                           on v.RegiaoId equals r.Id into vGrupo
                           from r in vGrupo.DefaultIfEmpty()
                           select new
                           {
                               Nome = $"{v.PrimeiroNome} {v.UltimoNome}",
                               RegiaoNome = (r == null) ? "Sem região" : r.Nome
                           };
            
            foreach (var item in vendedoresRegiaoSql)
                Console.WriteLine($"{item.Nome} \t {item.RegiaoNome}");

            #endregion
        }
    }
}