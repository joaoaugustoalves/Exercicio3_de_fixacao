﻿using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double notafiscal;
            double desconto = 0;

            Console.WriteLine();

            Console.WriteLine("Por favor informe o nome do produto conforme o cadastro: ");
            string produto = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Por favor informe a quantidade adquirida: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Por favor informe o preço unitário do(a) {produto} selecionado(a) ($): ");
            float valor = float.Parse(Console.ReadLine());

            double total = quantidade * valor;

            if (produto == "") {Console.WriteLine("Dados Inválidos");}
            
            if (quantidade == 0) {Console.WriteLine("Dados Inválidos");}
            
            if (valor == 0) {Console.WriteLine("Dados Inválidos");}

            else if (quantidade <= 5) { desconto = total * 0.02; }

            else if (quantidade > 5 && quantidade <= 10) { desconto = total * 0.03; }

            else { desconto = total * 0.05; };

            
            notafiscal = total - desconto;

            Console.WriteLine();

            Console.WriteLine($"O total sem o desconto é de: ${total.ToString("N2")}");
            Console.WriteLine();
            Console.WriteLine($"O desconto dado será de: ${desconto.ToString("N2")}");
            Console.WriteLine();
            Console.WriteLine($"Logo o total a pagar será de: ${notafiscal.ToString("N2")}");

        }
    }
}
