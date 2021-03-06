﻿using Linq.Classes;
using Linq.Interfaces;

namespace Linq
{
    public class Program
    {
        private static ITestLinq linq;

        static void Main(string[] args)
        {
            string exercicio = Tela.Iniciar();
            linq = ExerciciosFactory.Method(exercicio);
            linq.Executar();
            Tela.Finalizar();
        }
    }
}