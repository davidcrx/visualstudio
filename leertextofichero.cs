using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            float counter = 0;
            string line="";
            string sLastLine = "";
            string path = ("1,2,3,4,5");
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\dcreus\source\repos\ReadFile\ReadFile\lista2.txt");
            

            // Lee el archivo y lo muestra linea por linea  
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\dcreus\source\repos\ReadFile\ReadFile\lista.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++; //contador de cada fila
                sLastLine = line;
            }

            string[] sLineElements =  sLastLine.Split(',');
            int ncols = sLineElements.Count<string>();

            //var array = path.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(array[0]);
            //Console.WriteLine(lines[0]);



            file.Close();
            // Mostramos el contador de las filas
            System.Console.WriteLine("Hay {0} filas.", counter);
            System.Console.WriteLine("Hay {0} columnas.", ncols);

            // Cierra la ventana.  
            System.Console.ReadLine();
        }
    }
}
