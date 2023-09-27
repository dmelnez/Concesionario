using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Concesionario.Servicios
{

    /// <summary>
    /// Interfaz que contiene la relacion de metodos con el menu
    /// 27/09/2023 - DMN
    /// </summary>

    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que lanza el mensaje de bienvenidaUsuario al usuario
        /// 27/09/2023 - DMN
        /// </summary>

        void bienvenidaUsuario();


        /// <summary>
        /// Metodo que Muestra el menu de seleccion y recoger el valor introducido por el usuario
        /// 27/09/2023
        /// </summary>
        /// <returns>Entero con la Opcion Seleecionada</returns>

        public int lanzarMenu();

    }
}
