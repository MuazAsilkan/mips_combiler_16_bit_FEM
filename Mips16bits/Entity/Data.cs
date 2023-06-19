using System;
using System.Collections.Generic;
using System.Text;

namespace Mips16bits.Entity
{
    class Data
    {

        public Data( string adress, string value0, string value1, string value2, string value3, string number)
        {
            this.adress = adress;
            this.value0 = value0;
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
            this.number = number;
        }
        public string number { get; set; }
        public string adress { get; set; }
        public string value0 { get; set; }
        public string value1 { get; set; }
        public string value2 { get; set; }
        public string value3 { get; set; }
    }
}
