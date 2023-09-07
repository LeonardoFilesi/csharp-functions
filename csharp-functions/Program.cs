namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------CREA LE SEGUENTI FUNZIONI-----------------------------------------------

            // 1): preso un array di numeri interi, stampane il contenutoin questa forma "[elemento1, elemento2, elemento3, ...]"
            void PrintArray1(int[] array1)
            {
                Console.Write("[");

                for (int i = 0; i < array1.Length; i++)
                {
                    if (i < array1.Length - 1)
                    {
                        Console.Write(array1[i] + ", ");
                    }
                    else
                    {
                        Console.Write(array1[i]);
                    }
                }

                Console.WriteLine("]");

            }

            //2): stabilito un parametro numero intero, rstituire il quadrato del numero

            int Squared2(int number2)
            {
                int SquaredNum2 = number2 * number2;
                Console.WriteLine(SquaredNum2);

                return SquaredNum2;
            }

            //3): Stabilito un array di numeri interi, restituire un nuovo (non lo stesso) array con gli stessi numeri elevati al quadrato

            int[] SquaredArray3(int[] array3)
            {
                int[] array3Copy = (int[])array3.Clone();
                for (int i = 0; i < array3Copy.Length; i++)
                {
                    array3Copy[i] = array3[i] * array3[i];
                }
                return array3Copy;
            }

            //4): Stabilito un array di numeri interi, restituire la somma totale dei numeri dell'array

             int SumOneElementsArray4(int[] array4)
            {
                int SumArray4 = 0;
            
                foreach (int number4 in array4)
                {
                    SumArray4 += number4;
                }

                return SumArray4;
            }

            //----------------------------------------USA LE FUNZIONI CREATE---------------------------------------------

            int[] definitiveArray = { 2, 6, 7, 5, 3, 9 };

            // ESERCIZIO 1): stampare in console (come se fossero un array "[x, y, z, ...]" i numeri dell'array

            PrintArray1(definitiveArray);

            //ESERCIZIO 2): stampare in console l'array definitivo e un altro array definitivo, ma elevato al quadrato

            int[] definitiveArrayCopy = (int[])definitiveArray.Clone();

            foreach (int definitiveNumberCopy in definitiveArrayCopy)
            {
                Squared2(definitiveNumberCopy);
            }

            PrintArray1(definitiveArrayCopy);

            //ESERCIZIO 2.1): 

            SquaredArray3(definitiveArrayCopy);

            //ESERCIZIO 3): stampare la somma di tutti i numeri

            SumOneElementsArray4(definitiveArray);

            //ESERCIZIO 4):stanoare la somma di tutti i numeri elevati al quadrato

            SumOneElementsArray4(definitiveArrayCopy);

        }
    }
}