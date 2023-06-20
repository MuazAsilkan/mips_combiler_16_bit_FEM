using System;
using System.Collections.Generic;
using System.Text;

namespace Mips16bits.Entity
{
    public class Instruction
    {
        public Instruction(string data, int insMemory,int runned)
        {
            this.data = data;
            this.insMemory = insMemory;
            this.runned = runned;
        }
        public Instruction() { }
        public string data { get; set; }
        public int insMemory { get; set; }
        public int runned { get; set; }

        public string machCode { get; set; }
    }
}
