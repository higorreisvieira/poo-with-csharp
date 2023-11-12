using System;
using System.Drawing;
using System.Formats.Asn1;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace resol_exercicios1_estrutura_sequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 01
            // Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos.

            int value1, value2;

            Console.WriteLine("Valor 1: ");
            value1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Valor 2: ");
            value2 = Convert.ToInt16(Console.ReadLine());

            int sum = value1 + value2;
            Console.WriteLine("SOMA = " +sum);
            Console.ReadLine();

            // Exercício 02
            // Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais.
            // Exemplos:
            // Fórmula da área: area = π.raio2
            // Considere o valor de π = 3.14159

            double pi = 3.14159; // é o número pi
            double area = 0; // area do círculo

            Console.WriteLine("Informa o valor da área: ");

            // Lê a área do círculo do usuário
            area = Convert.ToDouble(Console.ReadLine());

            // Calcula o raio usando a fórmula correta: r = sqrt(A/pi)
            double raio = Math.Sqrt(area);

            Console.WriteLine("O raio do círculo é: " + raio);

            // Exercício 03
            // Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
            // de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            int a, b, c, d;

            Console.WriteLine("A: ");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("B: ");            
            b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("C: ");
            c = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("D: ");
            d = Convert.ToInt16(Console.ReadLine());

            int dif = a * b - c * d; // dif = diferença

            Console.WriteLine("DIFERENÇA: " + dif);

            // Exercício 04
            // Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.
            // A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

            int ht; // ht = horas trabalhadas
            int vph; // vph = valor por hora trabalhada
            double sal; // sal = salário

            Console.WriteLine("Informe as horas trabalhadas pelo colaborador: ");
            ht = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe o valor por hora trabalhada: ");
            vph = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informa o salário do colaborador: ");
            sal = Convert.ToDouble(Console.ReadLine());

            double total = (ht * vph) + sal;
             
            Console.WriteLine("O número é de " + ht + " e o salário total de " + total);

            // minha solução ficou um pouco diferente do que o professor publicou, então irei alterar este exercício para uma resolução mais similar ao que foi pedido.

            // Exercício 05
            // Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.
            // Calcule e mostre o valor a ser pago.

            int codpc1;
            int numpc1;
            double valpc1;
            // variáveis para a peça 2
            int codpc2;
            int numpc2;
            double valpc2;

            Console.WriteLine("Código da peça 1: ");
            codpc1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Número da peça 1: ");
            numpc1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Valor da peça 1: ");
            valpc1 = Convert.ToDouble(Console.ReadLine());

            // peça 2

            Console.WriteLine("Código da peça 2: ");
            codpc2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Número da peça 2: ");
            numpc2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Valor da peça 2: ");
            valpc2 = Convert.ToDouble(Console.ReadLine());

            double valorTotal = (valpc1 + valpc2) * 3;

            Console.WriteLine(valorTotal);
            // não está 100, precisa melhorar a lógica no cálculo também.
        }
    }
}