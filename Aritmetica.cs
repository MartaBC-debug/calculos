﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas
    /// </summary>
    internal static class Aritmetica
    {
        /// <summary>
        /// Operação soma
        /// </summary>
        /// <returns>Retorna a soma de dois números</returns>
        public static int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação de subtração
        /// </summary>
        /// <returns>Retorna o resultado da substração de dois números</returns>
        public static int Subtrair(int x, int y) 
        {
            return x - y;
        }
        /// <summary>
        /// Operação de multiplicação
        /// </summary>
        /// <returns>Retorna o resultado da multiplicação de dois números.</returns>
        public static int Multiplicar(int x, int y)
            { return x * y; 
        }
    }
}