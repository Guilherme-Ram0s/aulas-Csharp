﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;
        
        public string Area()
        {
            return $"a area do retangulo é {Largura * Altura}";
        }
        public string Perimetro()
        {
            return $"o perimetro do retangulo { 2 *(Largura +  Altura) }";
        }
    }
}
