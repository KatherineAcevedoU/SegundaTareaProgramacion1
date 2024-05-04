using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        public Empleado()
        {

        }

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

        //Creamos un metodo para aumentar un porcentaje del 5% al salario de cualquiera de los empleados
        public void AumentarSalarioEmpleado(int numeroDeAumentoDeSalario)
        {

            double aumentoSalario = 0.0;

            if (numeroDeAumentoDeSalario == 101)
            {

                aumentoSalario = 30000 + (0.05 * 30000);  //Aumento de 0.05
                Console.WriteLine("El nuevo salario es de: " + aumentoSalario);
               
            }
            else if(numeroDeAumentoDeSalario == 102)
            {

                aumentoSalario = 35000 + (0.05 * 35000);
                Console.WriteLine("El nuevo salario es de: " + aumentoSalario);

            }
            else if (numeroDeAumentoDeSalario == 103)
            {

                aumentoSalario = 32000 + (0.05 * 32000);
                Console.WriteLine("El nuevo salario es de: " + aumentoSalario);
                
            }
            else
            {
                Console.WriteLine("El numero del empleado es incorrecto!");

            }
            
        }
        
    }
}
