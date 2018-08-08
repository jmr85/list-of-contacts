using System;
using System.Collections.Generic;
using System.Linq;

namespace Agenda_JuanMRuiz
{// acciones tipicas de una agenda definida en la clase
    class Agenda
    {
        // Estructura de datos que guarda en memoria una colección de claves y valores.
        Dictionary<string, Contacto> contactos = new Dictionary<string, Contacto>();
        
        // Este metodo busca contacto por clave que es un string (nombre)
        public Contacto Buscar(string nombre)
        {      
            if (contactos.ContainsKey(nombre))
            {
               return contactos[nombre];
            }
            else
            {
                return null;
            }
        }
        
        public void Agregar(string nombre, string mail, string tel)
        {
            Contacto cn = new Contacto(nombre, mail, tel);
            if (!contactos.ContainsKey(cn.Nombre))
            {
                // la clave es el mismo nombre
                contactos.Add(cn.Nombre, cn);
                Console.WriteLine("Se ha agregado correctamente el Contacto");

            }
            else
            {
                Console.WriteLine("El nombre de contacto ya existe, intenta guardar con otro nombre");
            }
            
        }
        public bool Eliminar(string nombre)
        {
            return contactos.Remove(nombre);
        }
        //Metodo recorre el listado de la agenda con clave-valor, nombre-contacto
        public Dictionary<string, Contacto> MostrarTodos()
        {
            return contactos;
        }
        public int ContarContactos()
        {
            return contactos.Count();
        }
        public void BorrarTodo()
        {
            contactos.Clear();
        }
    }
}
