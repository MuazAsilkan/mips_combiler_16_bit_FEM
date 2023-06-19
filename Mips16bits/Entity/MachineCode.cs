using System;
using System.Collections.Generic;
using System.Text;

namespace Mips16bits.Entity
{
    public class MachineCode
    {

        public MachineCode() { }
        public MachineCode( string machineCode, string mipsCode) 
        {
            this.machineCode = machineCode;
            this.mipsCode = mipsCode;
        }

        public string machineCode { get; set; }
        public string mipsCode { get; set; }
        public string type { get; set; }

    }
}
