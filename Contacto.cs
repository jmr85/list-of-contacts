namespace Agenda_JuanMRuiz
{// estructura de un contacto con sus campos
    class Contacto
    {
        public string Nombre  { get; set;}
        public string Mail { get; set; }
        public string Tel { get; set; }
       
        public Contacto(){}

        public Contacto(string nombre, string mail, string tel)
        {
            this.Nombre = nombre;
            this.Mail = mail;
            this.Tel = tel;
        }
    }
}
