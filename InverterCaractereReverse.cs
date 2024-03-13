using System;

class Program
{
    static string InverteString(string inputString)
    {
        // Converte a string para um array de caracteres
        char[] caracteres = inputString.ToCharArray();

        // Obtém o comprimento da string
        int tamanho = caracteres.Length;

        // Inverte os caracteres usando um loop
        for (int i = 0; i < tamanho / 2; i++)
        {
            // Troca os caracteres simetricamente em relação ao meio
            char temp = caracteres[i];
            caracteres[i] = caracteres[tamanho - i - 1];
            caracteres[tamanho - i - 1] = temp;
        }

        // Converte o array de caracteres de volta para uma string
        string stringInvertida = new string(caracteres);

        return stringInvertida;
    }

    static void Main()
    {
        Console.Write("Digite uma string para inverter: ");
        string stringOriginal = Console.ReadLine();

        string stringInvertida = InverteString(stringOriginal);

        Console.WriteLine($"A string invertida é: {stringInvertida}");
    }
}
