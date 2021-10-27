using System;
using System.Globalization;

namespace medial_altura_pessoas_22_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedindo para o usuario colocar qual a quantidade de pessoas para fazer a media
            Console.WriteLine("Quantas pessoas serão medidas?");
            int n = int.Parse(Console.ReadLine());
            //Criando um array e dando de base o número da variável de entrada
            double[] vect = new double[n];
            //percorrendo o array e associando cada numero colocado pelo usuario a um espaço nele
            for (int i = 0; i < n; i++)
            {
                int numpessoa = i + 1;
                Console.WriteLine("A altura da pessoa " + numpessoa + " é de:");
                vect[i] = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);
            }
            //criando uma variavel para somar os valores de dentro do array  
            double sum = 0.0;
            //Utilizando for para percorrer o array
            for (int i = 0; i < n; i++)
            {
                //Somando os elementos
                sum += vect[i]; 
            }
            //fazendo a media e exibindo ela para o usuario
            double media = sum / vect.Length;
            Console.WriteLine("a media das alturas é :" + media);
        }
    }

}