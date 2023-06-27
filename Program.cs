// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static bool EsCapicua(int numero)
    {
        // Verificar si el número es capicúa
        if (numero.ToString() == ReverseString(numero.ToString()))
        {
            return true;
        }

        // Obtener los descendientes hasta el número de 2 cifras
        while (numero >= 100)
        {
            string digitos = numero.ToString();
            int siguiente = 0;
            for (int i = 0; i < digitos.Length - 1; i += 2)
            {
                siguiente += int.Parse(digitos[i].ToString()) + int.Parse(digitos[i + 1].ToString());
            }
            if (siguiente.ToString() == ReverseString(siguiente.ToString()))
            {
                return true;
            }
            numero = siguiente;
        }

        return false;
    }

    public static string ReverseString(string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(EsCapicua(11211230));
        // Salida: False

        Console.WriteLine(EsCapicua(13001120));
        // Salida: True

        Console.WriteLine(EsCapicua(23336014));
        // Salida: True

        Console.WriteLine(EsCapicua(11));
        // Salida: True
    }
}
