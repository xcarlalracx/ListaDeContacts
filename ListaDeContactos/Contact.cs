using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContactos
{
    public class Contact
    {
        public string Name;
        public string Address;
        public string Phone;

        public Contact(
            string Name,
            string Address,
            string Phone)
        {
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
        }

        public string DisplayContact()
        {
            return ($"Nome:{Name}\tTelefone:{Phone}");
        }
    }

    //private static async Task TaskAsync()
    //{
    //    string[] lines =
    //    {

    //    };
    //    await File.AppendAllLinesAsync("WriteLines.txt", lines);
    //}
}
