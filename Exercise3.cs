using System;

namespace arrays {
    class ExerciseThree {
        public static void Three(string[] args)
        {
            Console.WriteLine("Exercício 3.\nLeia 10 elementos e armazene em um array A.");
            Console.WriteLine("Em seguida, solicite pelo teclado um número qualquer e pesquise no array se o número existe.");
            Console.WriteLine("Caso, seja verdade imprima a mensagem: “O número existe no array”");
            Console.WriteLine("caso contrário “Número inexistente”.\n");

            const int arraysLenght = 10;

            var a = new double[arraysLenght];

            for (int i = 0; i < arraysLenght; i++) {
                var validNumber = false;
                while (!validNumber) {
                    Console.WriteLine($"Informe o {i + 1}º número da lista");
                    try {
                        a[i] = Double.Parse(Console.ReadLine());
                        validNumber = true;
                    }
                    catch (System.Exception) {
                        Console.WriteLine("Por favor informe um valor válido");
                    }
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Informe o número que deseja consultar: ");
            double request = 0;
            try {
                request = Double.Parse(Console.ReadLine());
            }
            catch (System.Exception) {
                Console.WriteLine("Por favor informe um número válido.");
            }
            int index = Array.IndexOf(a, request);

            if (index != -1) {
                Console.WriteLine("O número existe no array");
            }
            else Console.WriteLine("Número inexistente");

            Console.ReadLine();
        }
    }
}