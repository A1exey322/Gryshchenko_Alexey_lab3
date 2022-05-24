using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_3
{
    class Pedal 
    {
        public string Type { get; set; }

        public Pedal(string type) 
        {
            this.Type = type;
        }
        public override int GetHashCode()
        {
            return Type.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Button but = obj as Button;
            if (but as Button == null)
                return false;
            return but.Note == this.Type;
        }

        public override string ToString()
        {
            return $"{Type}";
        }
    }
}
