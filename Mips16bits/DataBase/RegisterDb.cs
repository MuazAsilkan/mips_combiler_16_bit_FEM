using Mips16bits.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mips16bits.DataBase
{
    class RegisterDb
    {
       static List<Register> registers;
        public RegisterDb()
        {
            registers = new List<Register>() {
            new Register("$v0","0","0x00000000","000"),
            new Register("$a0","1","0x00000000","001"),
            new Register("$t0","2","0x00000002","010"),
            new Register("$t1","3","0x00000001","011"),
            new Register("$t2","4","0x00000000","100"),
            new Register("$t3","5","0x00000000","101"),
            new Register("$sp","6","0x00000000","110"),
            new Register("$ra","7","0x00000000","111"),
            new Register("$pc","8","00000000","000"),
        };

        }



        public List<Register> getRegisters()
        {
            return registers;
        }
        public Register getRegister(string registerName)
        {
            return registers.Where(p => p.name == registerName).First();
        }
        public void changeValue(Register r)
        {
          registers.Where(p => p.name == r.name).First().value = r.value;
        }
        public void assignValue(Register r, string registerValue)
        {

          registers.Where(p => p.name == r.name).First().value = "0x"+ registerValue ;

        }

        public string getRegisterIndex(string registerName)
        {
            return registers.Find(p => p.name == registerName).number;
        }
        public string getRegisterValue(string registerName)
        {
            return registers.Find(p => p.name == registerName).registerValue;
        }
        public Register getRegisterWithRegisterValue(string registerValue)
        {
            return registers.Where(p => p.registerValue == registerValue).First();
        }
    }

    
}
