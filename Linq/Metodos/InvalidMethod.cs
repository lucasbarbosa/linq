﻿using Linq.Classes;
using Linq.Interfaces;

namespace Linq.Metodos
{
    public class InvalidMethod : ITestLinq
    {
        public void Executar()
        {
            Titulo.Exibir("MÉTODO INVÁLIDO");
        }
    }
}