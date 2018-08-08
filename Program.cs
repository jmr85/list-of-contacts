using System;
using System.Collections.Generic;


namespace Agenda_JuanMRuiz
{
    class Program
    {
        static void Main(string[] args) 
        {

            int opcion;
            string nombre, mail, tel;
            Agenda agenda = new Agenda();
            Validacion validacion = new Validacion();

            Console.WriteLine("*************** AGENDA ******************");
            Console.WriteLine("\n 0. Menú Principal");
            Console.WriteLine("\n 1. Añadir Contacto\n 2. Buscar Contacto\n 3. Eliminar Contacto\n 4. Mostrar Todo\n 5. Borrar Todo\n 6. Salir\n");
            Console.Write("> ");
            string op = Console.ReadLine();
            
            while (!validacion.EsNumero(op))
            {
                Console.WriteLine("\n El valor ingresado no es numerico, vuelva a intentar");
                Console.Write("> ");
                op = Console.ReadLine();
            }
            opcion = int.Parse(op);
            while (opcion != 6)
            {

                

                switch (opcion)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("*************** AGENDA ******************");
                        Console.WriteLine("\n 0. Menú Principal");
                        Console.WriteLine("\n 1. Añadir Contacto\n 2. Buscar Contacto\n 3. Eliminar Contacto\n 4. Mostrar Todo\n 5. Borrar Todo\n 6. Salir\n");
                        break;
                    case 1:
                        Console.Write("\nIntroduce Nombre (min 4, max 10): ");
                        nombre = Console.ReadLine();
                        while (!validacion.EsValidoNombre(nombre))
                        {
                            //itera hasta que la validacion sea valida
                            Console.Write("Vuelva a intentar (min 4, max 10): ");
                            nombre = Console.ReadLine();
                        }
                        Console.Write("\nIntroduce E-Mail (juanmartin@jmail.com): ");
                        mail = Console.ReadLine();
                        while (!validacion.EsValidoMail(mail))
                        {
                            Console.Write("Vuelva a intentar (____@___.com): ");
                            mail = Console.ReadLine();
                        }
                        Console.Write("\nIntroduce Telefono (11 12341234): ");
                        tel = Console.ReadLine();
                        while (!validacion.EsValidoTel(tel))
                        {
                            Console.Write("Vuelva a intentar (11 XXXXXXXX sin el 15): ");
                            tel = Console.ReadLine();
                        }
                        agenda.Agregar(nombre, mail, tel);
                        break;
                    case 2:
                        if (agenda.ContarContactos() > 0)//chequea que la coleccion de datos no este vacio
                        {
                            Console.Write("\nIntroduce Nombre para buscar: ");
                            
                                nombre = Console.ReadLine();
                                Contacto c = agenda.Buscar(nombre);
                                if (c != null)
                                {
                                    Console.WriteLine("\n Nombre: " + c.Nombre + "\n E-Mail: " + c.Mail + "\n Telefono: " + c.Tel);
                                }
                                else
                                {
                                    Console.WriteLine("No se encuentra el contacto en la agenda, vuelve a intentar");
                                }
                            
                          
                        }
                        else
                        {
                            Console.WriteLine("Agenda vacia!, ingrese contactos con la opcion 1");
                        }
                        break;
                    case 3:
                        if (agenda.ContarContactos() > 0)
                        {
                            Console.Write("\nIntroduce Nombre para Borrar: ");
                            nombre = Console.ReadLine();
                            if (agenda.Buscar(nombre) != null)
                            {
                                agenda.Eliminar(nombre);
                                Console.WriteLine("Se ha eliminado el contacto " + nombre + " de la Agenda");
                            }
                            else
                            {
                                Console.WriteLine("No se encuentra " + nombre + " en la Agenda, vuelva a intentar");
                            }
                        }
                        else
                        {
                            Console.WriteLine("La Agenda esta vacia, nada que borrar");
                        }
                            
                        break;
                    case 4:

                        Dictionary<string, Contacto> contactos = agenda.MostrarTodos(); //devuelve una colleccion de contactos con dos valores, el nombre y el contacto en si
                        foreach (var key in contactos.Keys)
                        {//recorrido de la lista, se ingresa a los campos mediante una clave que es el nombre de cada contacto
                            Console.WriteLine("Nombre: "+contactos[key].Nombre +" E-Mail: "+ contactos[key].Mail+" Telefono: "+ contactos[key].Tel+ "\n");
                        }
                        if(agenda.ContarContactos() == 0)
                        {
                            Console.WriteLine("Agenda vacia!, ingrese contactos con la opcion 1");
                        }else
                        {
                            Console.WriteLine(" Cantidad Contactos: " + agenda.ContarContactos());
                        }
                        
                        break;
                    case 5:
                        if (agenda.ContarContactos() > 0)
                        {
                            Console.Write("¿Seguro que desea borrar toda la Agenda? (s/n): ");
                            string resp = Console.ReadLine();
                            if (resp == "s")
                            {
                                agenda.BorrarTodo();
                                Console.WriteLine("Cantidad de Contactos: "+agenda.ContarContactos());
                            }
                        }
                        else
                        {
                            Console.WriteLine("La Agenda esta vacia, nada que borrar");
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Los valores para las opciones son de 0 a 6");
                        break;            
                }
                Console.Write("> ");
                op = Console.ReadLine();

                while (!validacion.EsNumero(op))
                {
                    Console.WriteLine("\n Volver a ingresar num: ");
                    Console.Write("> ");
                    op = Console.ReadLine();
                }
                opcion = int.Parse(op);
            }

        }
    }
}
