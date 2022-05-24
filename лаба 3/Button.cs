using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_3
{
    class Button
    {
        public string Note { get; set; }
         public Button(string note)
         {
            this.Note = note;
         }


        public override int GetHashCode()
        {
            return Note.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Button but = obj as Button;
            if (but as Button == null)
                return false;
            return but.Note == this.Note;
        }
        public override string ToString()
        {
            return $"{Note}";
        }
    }
}
