// See https://aka.ms/new-console-template for more information
using System;

namespace SorteoChance
{
    class Program
    {
        /// <summary>
        /// Función que calcula el premio obtenido por el jugador según el número apostado y el resultado del sorteo.
        /// Se evalúan las condiciones de mayor a menor premio para que, al cumplirse la condición más alta, se retorne de inmediato.
        /// </summary>
        /// <param name="apuesta">Monto apostado (por cada $1 apostado se multiplica la recompensa)</param>
        /// <param name="num">Número elegido por el jugador (se espera que sea de 4 dígitos)</param>
        /// <param name="resultado">Número resultado del sorteo (también de 4 dígitos)</param>
        /// <returns>El valor del premio obtenido o 0 si no se cumple ninguna condición</returns>
        static int CalcularPremio(int apuesta, int num, int resultado)
        {
            // 1. Verificamos si el número apostado es EXACTAMENTE igual al resultado.
            //    En este caso, el premio es de $4500 por cada $1 apostado.
            if (num == resultado)
            {
                return apuesta * 4500;
            }
            // 2. Si no es exacto, se verifica si los dígitos son los mismos pero en DESORDEN.
            //    Para ello, usamos la función auxiliar EsPermutacion.
            //    Nota: El caso exacto ya fue evaluado, por lo que aquí no se vuelve a premiar doble.
            else if (EsPermutacion(num, resultado))
            {
                return apuesta * 200;
            }
            // 3. Verificamos si se aciertan las ÚLTIMAS 3 cifras en el mismo orden.
            else if (num % 1000 == resultado % 1000)
            {
                return apuesta * 400;
            }
            // 4. Verificamos si se aciertan las ÚLTIMAS 2 cifras en el mismo orden.
            else if (num % 100 == resultado % 100)
            {
                return apuesta * 50;
            }
            // 5. Verificamos si se acierta la ÚLTIMA cifra.
            else if (num % 10 == resultado % 10)
            {
                return apuesta * 5;
            }
            // 6. Si ninguna condición se cumple, el premio es 0.
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Función auxiliar que determina si dos números son permutaciones de sus dígitos.
        /// Se convierten ambos números a cadenas de 4 dígitos (rellenando con ceros si es necesario), 
        /// se ordenan sus caracteres y se comparan.
        /// </summary>
        /// <param name="num">Número elegido por el jugador</param>
        /// <param name="resultado">Número resultado del sorteo</param>
        /// <returns>True si ambos números tienen los mismos dígitos (aunque en distinto orden); false en caso contrario</returns>
        static bool EsPermutacion(int num, int resultado)
        {
            // Convertir ambos números a cadena con formato "D4" para asegurar 4 dígitos (incluyendo ceros a la izquierda)
            string s1 = num.ToString("D4");
            string s2 = resultado.ToString("D4");

            // Convertir las cadenas a arreglos de caracteres
            char[] a1 = s1.ToCharArray();
            char[] a2 = s2.ToCharArray();

            // Ordenar ambos arreglos de caracteres
            Array.Sort(a1);
            Array.Sort(a2);

            // Convertir los arreglos ordenados nuevamente a cadenas
            string sorted1 = new string(a1);
            string sorted2 = new string(a2);

            // Si las cadenas ordenadas son iguales, los números tienen los mismos dígitos
            return sorted1 == sorted2;
        }

        /// <summary>
        /// Función Main: Punto de entrada de la aplicación.
        /// Se declara como 'static void Main(string[] args)' ya que es el estándar en C# para aplicaciones de consola.
        /// La palabra clave 'static' indica que el método pertenece a la clase y no requiere instanciarla, y 'void' significa que no retorna valor.
        /// </summary>
        static void Main(string[] args)
        {
            // Declaramos el monto de la apuesta (en este ejercicio se apuesta $1000)
            int apuesta = 1000;
            
            // Se realizan varios ejemplos para probar las distintas condiciones:

            // Ejemplo 1: Número exacto (todas las cifras en orden)
            int numElegido = 1234;
            int resultadoSorteo = 1234;
            int premio = CalcularPremio(apuesta, numElegido, resultadoSorteo);
            Console.WriteLine("Ejemplo 1 - Número exacto: El premio obtenido es: $" + premio);

            // Ejemplo 2: Números con las mismas cifras pero en desorden
            numElegido = 1234;
            resultadoSorteo = 4321;
            premio = CalcularPremio(apuesta, numElegido, resultadoSorteo);
            Console.WriteLine("Ejemplo 2 - Permutación: El premio obtenido es: $" + premio);

            // Ejemplo 3: Acierto de las últimas 3 cifras en orden
            numElegido = 1234;
            resultadoSorteo = 9234; // Últimas 3 cifras: "234"
            premio = CalcularPremio(apuesta, numElegido, resultadoSorteo);
            Console.WriteLine("Ejemplo 3 - Últimas 3 cifras: El premio obtenido es: $" + premio);

            // Ejemplo 4: Acierto de las últimas 2 cifras en orden
            numElegido = 1234;
            resultadoSorteo = 5634; // Últimas 2 cifras: "34"
            premio = CalcularPremio(apuesta, numElegido, resultadoSorteo);
            Console.WriteLine("Ejemplo 4 - Últimas 2 cifras: El premio obtenido es: $" + premio);

            // Ejemplo 5: Acierto de la última cifra
            numElegido = 1234;
            resultadoSorteo = 7894; // Última cifra: "4"
            premio = CalcularPremio(apuesta, numElegido, resultadoSorteo);
            Console.WriteLine("Ejemplo 5 - Última cifra: El premio obtenido es: $" + premio);

            // Ejemplo 6: Ningún acierto
            numElegido = 1234;
            resultadoSorteo = 5678;
            premio = CalcularPremio(apuesta, numElegido, resultadoSorteo);
            Console.WriteLine("Ejemplo 6 - Sin acierto: El premio obtenido es: $" + premio);

            // Para evitar que la consola se cierre inmediatamente al ejecutarse fuera de un IDE, se espera una entrada del usuario.
            Console.ReadLine();
        }
    }
}

