using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace EjerciciosLambda
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            Console.ReadKey();
            // List with eah element of type Student 
            List<Estudiante> details = new List<Estudiante>() {
                new Estudiante{ Id = 1, Nombre = "Liza", Apellido="Zambrano", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Stewart",  Apellido="Rivera",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Tina",  Apellido="Mendoza",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Stefani",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Trish",  Apellido="Restrepo",Promedio= 3, Edad=23  }
        };

            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla los nombres de los estudiantes
            Console.WriteLine("Nombre de los estudiantes:");
            Console.WriteLine("");
            var Listado = details.Select(emp => new { emp.Nombre });
            Console.WriteLine(string.Join("\n", Listado));
            Console.ReadKey();
            //2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor
            Console.WriteLine("Nombres y Apellido, Promedio:");
            var nombres = details.OrderByDescending(prome => prome.Promedio).Select(n => new { n.Nombre, n.Apellido });
            Console.WriteLine(string.Join("\n", nombres));
            Console.WriteLine("");
            Console.ReadKey();
            //3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente
            Console.WriteLine("Orden Alfabeticamente:");
            Console.WriteLine("");
            var orden = details.OrderBy(l => l.Apellido).Select(A => new { A.Apellido });
            Console.WriteLine(string.Join("\n", orden));
            //4. Muestre por pantalla los datos del estudiante mas joven
            Console.WriteLine("Datos del estudiante mas joven:");
            var datos = details.OrderBy(joven => joven.Edad).First();
            Console.Write(string.Join("", datos.Id, ";", datos.Apellido, ";", datos.Nombre, ";", datos.Promedio)); ;
            Console.ReadKey();
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla el cuadrado de los números
            // Func <int, int> cuadrado=( cuadrado1)=>cuadrado1*cuadrado1;
            // var cuadrado =list.Where (cuadrado);
            var cuadrado = list.Select(n => n * n);
            Console.WriteLine("Cuadrado de los numero { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 } ");
            Console.WriteLine("");
            Console.WriteLine(string.Join(";", cuadrado));
            Console.WriteLine("");
            Console.ReadKey();
            //2. Muestre por pantalla los números pares
            Console.WriteLine("Pares de los numero { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 }");
            Console.WriteLine("");
            var pares = list.Where((lista) => lista % 2 == 0);
            Console.WriteLine(pares.Count());
            string resultado = string.Join(Environment.NewLine, pares);
            Console.Write(resultado);
            Console.WriteLine("");
            Console.ReadKey();
            //3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares
            Console.WriteLine("multiplicar por 5 los numero impares { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 } ");
            Console.WriteLine("");
            var multiplicacion = list.Where(listas => listas % 2 != 0).Select(x => x * 5);
            Console.WriteLine(string.Join(";", multiplicacion));
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}