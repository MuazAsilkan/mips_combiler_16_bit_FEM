using System;
using System.Collections.Generic;
using System.Text;

namespace Mips16bits.Entity
{
    class ValueTable
    {
       List<Function> table;
       public  ValueTable()
        {
            table = new List<Function>()
            {
                new Function(){ name="add",type="R" , value="00000"},
                new Function(){ name="and",type="R" , value="00100"},
                new Function(){ name="sub",type="R" , value="01000"},
                new Function(){ name="or",type="R" , value="01100"},
                new Function(){ name="xor",type="R" , value="10000"},
                new Function(){ name="jr",type="R" , value="10100"},
                new Function(){ name="sll",type="R" , value="11000"},
                new Function(){ name="srl",type="R" , value="11100"},
                new Function(){ name="addi",type="I" , value="00010"},
                new Function(){ name="andi",type="I" , value="00110"},
                new Function(){ name="subi",type="I" , value="01010"},
                new Function(){ name="ori",type="I" , value="01110"},
                new Function(){ name="beq",type="I" , value="10010"},
                new Function(){ name="bne",type="I" , value="10110"},
                new Function(){ name="lw",type="I" , value="11010"},
                new Function(){ name="sw",type="I" , value="11110"},
                new Function(){ name="j",type="J" , value="00001"},
                new Function(){ name="jal",type="J" , value="00101"},
            };
        }



        public string getValue(string name)
        {
            return table.Find(p => p.name == name).value;

        }
        public string getType(string name)
        {
            return table.Find(p => p.name == name).type;

        }
        public string getname(string value)
        {
            return table.Find(p => p.value == value).name;

        }

    }
}
