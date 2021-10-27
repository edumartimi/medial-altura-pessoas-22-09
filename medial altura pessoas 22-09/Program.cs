using System;
using System.Globalization;

namespace medial_altura_pessoas_22_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando a variável de entrada
            Console.WriteLine("Quantas pessoas serão medidas?");
            int n = int.Parse(Console.ReadLine());
            //Criando vetor com o número da variável de entrada
            double[] vect = new double[n];
            //Utilização do comando for para percorrer o vetor
            for (int i = 0; i < n; i++)
            {
                int numpessoa = i + 1;
                //Entrada dos elementos no vetor pelo usuário
                Console.WriteLine("A altura da pessoa " + numpessoa + " é de:");
                vect[i] = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);
            }
            //Variável soma       
            double sum = 0.0;
            //Utilização do for para percorrer o vetor
            for (int i = 0; i < n; i++)
            {
                //Somatoria dos elementos inseridos
                sum += vect[i]; 
            }
            double media = sum / vect.Length;
            Console.WriteLine("a media das alturas é :" + media);
        }
    }

}