using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeEmpleado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Aplicacion de Gestion de Empleados");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            //Creamos una lista para guardar datos de los empleados

            List<Empleado> listaEmpleados = new List<Empleado>();

            //Agregamos datos a la lista

            listaEmpleados.Add(new Empleado("Juan", 101, 30000));
            listaEmpleados.Add(new Empleado("Maria", 102, 35000));
            listaEmpleados.Add(new Empleado("Pedro", 103, 32000, false));
            Console.WriteLine();

            //Mostramos los datos de cada empleado

            foreach (var empleado in listaEmpleados)
            {
                empleado.MostrarDatos();

            }
            Console.WriteLine();


            //Cambiamos el estado de un empleado por su numero de empleado

            int numeroEmpleadoCambiarEstado = 103;

            Empleado empleadoCambiarEstado = BuscarEmpleado(listaEmpleados, numeroEmpleadoCambiarEstado);

            if (empleadoCambiarEstado != null)
            {

                empleadoCambiarEstado.CambiarEstadoEmpleado(1);
                Console.WriteLine();

                empleadoCambiarEstado.MostrarDatos();
                Console.WriteLine();
   
            }
            else
            {

                Console.WriteLine($"Empleado con numero {numeroEmpleadoCambiarEstado} no encontrado.");

            }

            //Creamos una instancia de la clase, donde pasamos datos al metodo que esta en Empleado

            Empleado mensajero1 = new Empleado();

            Console.Write("Ingrese el numero del empleado que se le va aumentar el salario: ");
            int numeroDeAumentoDeSalario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("------------------------------------------");
            mensajero1.AumentarSalarioEmpleado(numeroDeAumentoDeSalario);
            Console.WriteLine("------------------------------------------");

        }

        //Metodo para buscar un empleado por su numero
        static Empleado BuscarEmpleado(List<Empleado> empleados, int numeroEmpleado)
        {

            foreach (var empleado in empleados)
            {

                if (empleado.ObtenerNumeroEmpleado() == numeroEmpleado)
                {

                    return empleado;

                }
                
            }

            return null;

        }


    }
}
