using System.Diagnostics;
using System.Runtime.Serialization;

namespace Clase17R;

class Program
{
    static void Main(string[] args)
    {
       double[] num = new double[10];
       double totalP = 0.0, totalN = 0.0;
       int contP = 0, contN = 0;

       Console.WriteLine("Ingrese los valores del arreglo: ");
       for (int i = 0; i < 10; i++){
        Console.Write("{0}: ", i+1);
        num[i] = Convert.ToDouble(Console.ReadLine());
       } 
        for (int i = 0; i < 10; i++){
            if (num[i] > 0){
                totalP += num[i];
                contP++;
            }
            else if (num[i] < 0){
                totalN += num[i];
                contN++;
            }
        }
        Console.WriteLine("\nEl promedio de números positivos es {0}", (totalP/contP).ToString("N2"));
        Console.WriteLine("El promedio de números negativos es {0}", (totalN/contN).ToString("N2"));
    }
}      




