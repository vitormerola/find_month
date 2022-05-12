using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

class Programa
{
    static string ImprimeMes(int numero)
    {
        string[] arr = new string[] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
        return $"O mês correspondente ao número {numero} é {arr[numero - 1]}!";
    }
    static void RecebeNumero()
    {
        try
        {

            Console.WriteLine("Digite um número para saber a qual mês ele corresponde ou digite SAIR para parar:  ");
            string? digito = Console.ReadLine();
            bool valido = int.TryParse(digito, out int numero);
            if (digito.ToLower() == "sair")
            {
                continua = false;
                return;
            }

            if (!(valido && (numero >= 1 && numero <= 12)))
            {
                throw new Exception("Mês inválido! Tente novamente com um número entre 1 e 12!!!!");
            }

            Console.WriteLine(ImprimeMes(numero));
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