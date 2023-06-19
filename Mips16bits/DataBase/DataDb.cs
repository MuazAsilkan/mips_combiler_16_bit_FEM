using Mips16bits.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mips16bits.DataBase
{
    class DataDb
    {
        static List<Data> Datas;
        public DataDb()
        {
            Datas = new List<Data>() {
            new Data("0x10010000","0x00000000","0x00000000","0x00000000","0x00000000","0"),
            new Data("0x10010001","0x00000000","0x00000000","0x00000000","0x00000000","1"),
            new Data("0x10010010","0x00000000","0x00000000","0x00000000","0x00000000","2"),
            new Data("0x10010100","0x00000000","0x00000000","0x00000000","0x00000000","3"),
            new Data("0x10011000","0x00000000","0x00000000","0x00000000","0x00000000","4"),
            new Data("0x10110000","0x00000000","0x00000000","0x00000000","0x00000000","5"),

        };

        }



        public List<Data> getDatas()
        {
            return Datas;
        }
        public Data getData(string address)
        {
            return Datas.Where(p => p.adress == address).First();
        }
        public string getValue(string address)
        {
            return Datas.Where(p => p.adress == address).First().value0;
        }
        public void changeValue(Data d)
        {
            Datas.Where(p => p.adress == d.adress).First().value0 = d.value0;
        }
        public void assignValue(Data d, string value)
        {

            Datas.Where(p => p.adress == d.adress).First().value0 = "0x" + value;

        }

        public Data createData(string address, string value)
        {
            Datas.Add(new Data(address, value, "0x00000000", "0x00000000", "0x00000000", "x"));
            return Datas.Where(p => p.adress == address).First();
        }
        /*
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
        }*/
    }

}
