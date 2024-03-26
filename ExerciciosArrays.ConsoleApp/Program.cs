namespace ExerciciosArrays.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valoresAleatorios = new int[] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };

            //Encontrar o Maior Valor da sequência.
            MaiorValor(valoresAleatorios);

            //Encontrar o Menor Valor da sequência 
            MenorValor(valoresAleatorios);

            //Encontrar o Valor Médio da sequência
            ValorMedio(valoresAleatorios);

            //Encontrar os 3 maiores valores da sequência
            TresMaioresValores(valoresAleatorios);

            //Encontrar os valores negativos da sequência
            ExibirValoresNegativos(valoresAleatorios);

            //Mostrar na Tela os valores da sequência
            ExibirValoresOrdenados(valoresAleatorios);

            //Remover um item da sequência
            int index = 4;              
            RemoveElementFromArray(valoresAleatorios, index);
        }

        static int MaiorValor(int[] valoresAleatorios)
        {
            Array.Copy(valoresAleatorios, valoresAleatorios; valoresAleatorios.Length);

            int maxValor = valoresAleatorios.Max();

            Console.WriteLine(maxValor);
            Console.ReadLine();

            return maxValor;
        }

        static int MenorValor(int[] valoresAleatorios)
        {
            int minValor = valoresAleatorios.Min();

            Console.WriteLine(minValor);
            Console.ReadLine();

            return minValor;
        }

        static int ValorMedio(int[] valoresAleatorios)
        {

            double media = Convert.ToDouble(valoresAleatorios.Average());            

            Console.WriteLine(media);
            Console.ReadLine();

            return Convert.ToInt32(media);
        }
        static void TresMaioresValores(int[] valoresAleatorios)
        {
            Array.Sort(valoresAleatorios);
            Array.Reverse(valoresAleatorios);

            var numeros = valoresAleatorios.Take(3);

            foreach (var valor in numeros)
            {
                Console.WriteLine(valor);
            }
        }
        static void ExibirValoresNegativos(int[] valoresAleatorios)
        {
            for (int i = 0; i < valoresAleatorios.Length; i++)
            {
                if (valoresAleatorios[i] < 0)
                {
                    Console.Write(valoresAleatorios[i] + " ");
                }
            }
        }
        static void ExibirValoresOrdenados(int[] valoresAleatorios)
        {
            Array.Sort(valoresAleatorios);

            var numeros = valoresAleatorios;

            foreach (int i in valoresAleatorios)
            {
                Console.Write(i + " ");
            }
        }
        static int[] RemoveElementFromArray(int[] array, int index)
        {

            array = array.Where((item, i) => i != index).ToArray();
            return array;
        }

        
    }
}
