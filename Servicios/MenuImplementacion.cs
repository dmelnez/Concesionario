using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Concesionario.Servicios
{
    /// <summary>
    /// Clase que Implenta la Interfaz del Menu
    /// 27/09/2023 - DMN
    /// </summary>

    internal class MenuImplementacion : MenuInterfaz /*Conexion de la implementacion con la Interfaz*/
    {

        public void bienvenidaUsuario()
        {
            string mensajeBievenida = "Bienvenido a la Gestion del Concesionario";
            Console.WriteLine(mensajeBievenida);
        }

        public int lanzarMenu() 

        {

            int valorIntroducido;
         
             Console.WriteLine("---------------------------------------");
             Console.WriteLine("0. Cerrar Aplicacion");
             Console.WriteLine("1. Modelos de Vehiculos");
             Console.WriteLine("2. Disponibilidad de Marcas");
             Console.WriteLine("---------------------------------------");
             Console.WriteLine("Seleccion una nueva Opcion");




        }



    }







}
