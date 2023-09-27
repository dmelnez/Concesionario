using Gestion_Concesionario.Servicios;

namespace Gestion_Concesionario.Controladores;

class program
{




    static void Main(String[] args)
    {

        MenuInterfaz menuInterfaz = new MenuImplementacion();
        menuInterfaz.bienvenidaUsuario();
        bool salirMenu = false;
        int valorSeleccionUsuario;


        while (!salirMenu)
        {
            valorSeleccionUsuario = menuInterfaz.lanzarMenu();
            Console.WriteLine(valorSeleccionUsuario);

            switch (valorSeleccionUsuario)
            {
                case 0:
                    Console.WriteLine("[INFO - Seleccion de la Opcion 0]");
                    salirMenu = true;
                    break;
                case 1:
                    Console.WriteLine("[INFO - Seleccion de la Opcion 1]");
                    break;
                case 2:
                    Console.WriteLine("[INFO - Seleccion de la Opcion 2]");
                    break;

                default:
                    Console.WriteLine("[INFO - La Seleccion, no tiene coincidencia]");
                    break;
            }



        }



    }


















}
