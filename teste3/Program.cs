using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

class Programa
{
    static string MostraQuadrado(long numero)
    {
        return $"O quadrado do número {numero} é {numero * numero}!";
    }
    static void RecebeNumero()
    {
        try
        {

            Console.WriteLine("Digite um número inteiro não-nulo ou digite SAIR para parar:  ");
            string? digito = Console.ReadLine();
            bool valido = int.TryParse(digito, out int numero);
            if (digito.ToLower() == "sair")
            {
                continua = false;
                return;
            }

            if (!valido || numero == 0)
            {
                throw new Exception("Número inválido! Tente novamente com um número não-nulo!");
            }

            Console.WriteLine(MostraQuadrado(numero));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static bool continua = true;
    static void Main(String[] args)
    {
        do
        {
            RecebeNumero();
        }
        while (continua);

        Console.WriteLine("Programa Encerrado!!!");
        Console.ReadKey();
        Environment.Exit(0);
    }
}