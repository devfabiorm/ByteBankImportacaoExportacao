﻿using ByteBankImportacaoExportacao.Modelos;
using System;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            UsandoStreamWriter();
            Console.WriteLine("Finalizando...");
            Console.ReadLine();
        }
    }
}
