using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeEmpleado
{
    internal class Empleado
    {

        //Variables de un empleado

        private string nombreEmpleado;
        private int numeroEmpleado;
        private decimal salarioEmpleado;
        private bool estadoEmpleado;

        //Constructor con parametro
        public Empleado(string nombre, int numero, decimal salario, bool estado = true)
        {
            this.nombreEmpleado = nombre;
            this.numeroEmpleado = numero;
            this.salarioEmpleado = salario;
            this.estadoEmpleado = estado;
        }


        //Metodo para mostrar los datos del empleado
        public void MostrarDatos()
        {
            string estado = (estadoEmpleado) ? "Activo" : "Inactivo";

            Console.WriteLine($"Nombre: {nombreEmpleado}, Numero De Empleado: {numeroEmpleado}, Salario: {salarioEmpleado}, Estado: {estado}");
        }

        //Metodo para obtener el numero del empleado
        public int ObtenerNumeroEmpleado()
        {
            return this.numeroEmpleado;
        }

        //Metodo para cambiar el estado del empleado
        public void CambiarEstadoEmpleado(int nuevoEstado)
        {


            Console.WriteLine("...............................................");
            Console.WriteLine("Cambio de estado de el numero de empleado: " + this.numeroEmpleado);
            Console.WriteLine("...............................................");
            Console.WriteLine();

            if (nuevoEstado == 1)
            {

                estadoEmpleado = true;

                Console.WriteLine("Empleado activo");
                Console.WriteLine();

            }
            else if (nuevoEstado == 0)
            {

                estadoEmpleado = false;

                Console.WriteLine("Empleado inactivo.");
                Console.WriteLine();

            }
            else
            {

                Console.WriteLine("Estado no valido.");

            }

        }

    }
}
