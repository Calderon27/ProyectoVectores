﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVectores.clases
{
    public class NumLetras
    {
        private static string[] unidades = new string[]{"cero","uno", "dos", "tres","cuatro",
        "cinco","seis","siete","ocho","nueve","diez","once","doce","trece","catorce","quince",
        "dieciseis","diecisite","dieciocho","diecinueve"};
        private static string[] decenas = new string[]{"diez","veinte", "treinta", "cuarenta",
        "cincuenta","sesenta","setenta","ochenta","noventa"};
        private static string[] centenas = new string[]{"cien","docientos", "trecientos","cuatrocientos",
        "quinientos","seiscientos","setecientos","ochenta","novecientos"};

        public static string getLetras(int num)
        {
            string aux = "";
            if (num < 20)
                aux = unidades[num];

            return aux;

            
        }

    }
}
