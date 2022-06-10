using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EstructuradeDatosClase1
{
    class Program
    {
        [STAThread]

        static void Main(string[] args)
        {

            /*string a = " ";
            Console.WriteLine("Introduza los datos de su libro favorito");
            Console.ReadKey();

            List<libro> libro2 = new List<libro>();

            while (true)
            {
                var libro3 = new libro();
                Console.Clear();
                
                Console.WriteLine("Titulo");
                libro3.titulo = Console.ReadLine();
                Console.WriteLine("Autor");
                libro3.autor = Console.ReadLine();
                Console.WriteLine("Editorial");
                libro3.editorial = Console.ReadLine();
                Console.WriteLine("Anio de edicion");
                libro3.anioedicion = int.Parse(Console.ReadLine());
                Console.WriteLine("Categoria");
                libro3.categoria = Console.ReadLine();

                Console.WriteLine("Libro agregado!");
                Console.WriteLine("Desea continuar? S/N");
                a = Console.ReadLine();

                if(a=="N")
                {
                    break;
                }

                foreach (var l in libro2)
                {
                    Console.WriteLine(l.titulo);
                    Console.WriteLine(l.autor);
                    Console.WriteLine(l.editorial);
                    Console.WriteLine(l.anioedicion);
                    Console.WriteLine(l.categoria);
                }

            }*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
