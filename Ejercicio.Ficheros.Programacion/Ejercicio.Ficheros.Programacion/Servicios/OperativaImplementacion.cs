using Ejercicio.Ficheros.Programacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Ficheros.Programacion.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
       
        List<ClienteDtos> listaClientes = new List<ClienteDtos>();
        public void funcionesEmpleado()
        {

            MenuInterfaz me = new MenuImplementacion();




            switch (me.menuEmpleado())
            {

                case 0:
                    break;

                case 1:

                    Console.WriteLine("-----------------------");
                    Console.WriteLine("| VALIDAR A UN CLIENTE |");
                    Console.WriteLine("-----------------------");
                    break;

                case 2:
                    Console.WriteLine("------------------------");
                    Console.WriteLine("| ELIMINAR A UN CLIENTE |");
                    Console.WriteLine("------------------------");
                    break;

                default:
                    Console.WriteLine("------------------------");
                    Console.WriteLine("| MOSTRAR UN CLIENTE   |");
                    Console.WriteLine("------------------------");
                    break;


            }
        }


            public void funcionesCliente()
            {

                MenuInterfaz me = new MenuImplementacion();


                switch (me.menuCliente())
                {

                    case 0:
                        break;

                    case 1:
                        Console.WriteLine("--------------------");
                        Console.WriteLine("| REGISTRO CLIENTE  |");
                        Console.WriteLine("--------------------");

                        registroCliente();

                    break;

                    case 2:
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("| ACCESO CLIENTE (LOGIN) |");
                    Console.WriteLine("-------------------------");
                    accesoCliente();
                    break;

                    default:
                        Console.WriteLine("SELECCION NO VALIDA");
                    break;



                }



            }


           public void registroCliente()
            {

            
            ClienteDtos cliente = new ClienteDtos();

      


            Console.WriteLine("DNI: ");
            cliente.DniCliente = Console.ReadLine();

            Console.WriteLine("NOMBRE COMPLETO: ");
            cliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("EMAIL: ");
            cliente.EmailCliente = Console.ReadLine();

            Console.WriteLine("CONTRASENIA: ");
            cliente.ContraseniaCliente = Console.ReadLine();


            listaClientes.Add(cliente);
          


           }


           public void accesoCliente()
            {

            Console.WriteLine("EMAIL: ");
            string email = Console.ReadLine();
            Console.WriteLine("CONTRASENIA: ");
            string contrasenia = Console.ReadLine();


            foreach (ClienteDtos cliente in listaClientes)
            {

               if( cliente.EmailCliente.Equals(email) && cliente.ContraseniaCliente.Equals(contrasenia))
               {

                  if (cliente.EsValidado == true)
                  {
                        Console.WriteLine("INICIO DE SESION CORRECTO");
                  }

                  else
                  {
                        Console.WriteLine("EL CIENTE NO HA SIDO VALIDADO");
                  }


                }


            }



           }



      
    }
}
