using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mau.Models
{
    public class PetModel
    {
     
        private int id;
        private string name;
        private string type;
        private string colour;

      
        [DisplayName("Pet ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
    }
}
