using System;
using System.Collections.Generic;
using System.Text;

namespace Mips16bits.Entity
{
    class Register
    {
        public Register(string name, string number, string value,string registerValue)
        {
            this.name = name;
            this.number = number;
            this.value = value;
            this.registerValue = registerValue;
        }
        public string name { get; set; }
        public string number { get; set; }
        public string value { get; set; }
        public string registerValue { get; set; }
    }
}
