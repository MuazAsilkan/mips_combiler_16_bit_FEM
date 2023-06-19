using System;
using System.Collections.Generic;
using System.Text;

namespace Mips16bits.Entity
{
    class Function
    {
        public Function(string name, string value, string type)
        {
            this.name = name;
            this.value = value;
            this.type = type;
        }
        public Function() { }
        public string name { get; set; }
        public string value { get; set; }
        public string type { get; set; }

    }
}
