using Mips16bits.DataBase;
using Mips16bits.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mips16bits.Mips
{
    class ConverMipsToMachine
    {
        string functionName;
        MachineCode machineCode = new MachineCode();
        ValueTable valueTable= new ValueTable();
        RegisterDb registerDb = new RegisterDb();

        public MachineCode converToMac(Instruction ins)
        {

            string data = ins.data;
            machineCode.mipsCode = data;
            string[] arraay = data.Split(" ");
            this.functionName = arraay[0];
            machineCode.machineCode = valueTable.getValue(functionName);
            
            string[] constants = arraay.Skip(1).ToArray();
            string variables = string.Join("", constants);

            string[] variableList = variables.Split(",");

            if (machineCode.machineCode.Substring(3, 2) == "00")
            {
                if (functionName == "sll" | functionName == "srl")
                {
                    machineCode.machineCode = machineCode.machineCode + (registerDb.getRegisterValue(variableList[0]));
                    machineCode.machineCode = machineCode.machineCode + (registerDb.getRegisterValue(variableList[1]));
                    machineCode.machineCode = machineCode.machineCode + Convert.ToString(int.Parse(variableList[2]), 2).PadLeft(3, '0');
                }
                else
                {
                    foreach (string r in variableList)
                    {



                        if (r == "$ra")
                        {


                            machineCode.machineCode = machineCode.machineCode + "000000";

                        }

                        machineCode.machineCode = machineCode.machineCode + (registerDb.getRegisterValue(r));


                    }
                }
              
                machineCode.machineCode = machineCode.machineCode + "00";
            }
            else if (machineCode.machineCode.Substring(3, 2) == "10")
            {
                if (machineCode.machineCode == "11010" | machineCode.machineCode == "11110")
                {
                    machineCode.machineCode = machineCode.machineCode + (registerDb.getRegisterValue(variableList[0]));
                    string dest = variableList[1].Split("(")[1].Trim(')');
                    string offset = variableList[1].Split("(")[0];
                    machineCode.machineCode = machineCode.machineCode + (registerDb.getRegisterValue(dest));
                    // machineCode.machineCode = machineCode.machineCode + Convert.ToString(int.Parse(offset), 2).PadLeft(5, '0');
                    try
                    {
                        machineCode.machineCode = machineCode.machineCode + Convert.ToString(int.Parse(offset), 2).PadLeft(5, '0');
                    }
                    catch
                    {
                        offset = Convert.ToInt32(offset, 16).ToString();
                        machineCode.machineCode = machineCode.machineCode + Convert.ToString(int.Parse(offset), 2).PadLeft(5, '0');
                    }
                }
                else { 
                machineCode.machineCode = machineCode.machineCode + (registerDb.getRegisterValue(variableList[0]));
                machineCode.machineCode = machineCode.machineCode + (registerDb.getRegisterValue(variableList[1]));
                try
                {
                        try
                        {
                            machineCode.machineCode = machineCode.machineCode + Convert.ToString(int.Parse(variableList[2]), 2).PadLeft(5, '0');
                        }
                        catch (Exception)
                        {

                            machineCode.machineCode = machineCode.machineCode + Convert.ToString(Convert.ToInt32(variableList[2], 16), 2).PadLeft(5, '0');
                        }
                   


                }
                catch (Exception)
                {

                    foreach (var item in Form1.ınstructions)
                    {

                        if (item.data.Replace(":", "") == variableList[2])
                        {
                             Console.WriteLine(item.insMemory);
                            machineCode.machineCode = machineCode.machineCode + Convert.ToString(item.insMemory, 2).PadLeft(5, '0');
                        }

                    }


                }
               
            }}
            else if(machineCode.machineCode.Substring(3, 2) == "01")
            {

                foreach (var item in Form1.ınstructions)
                {
            

                    if (item.data.Replace(":","").Trim()  == constants[0]) 
                    {
                        Console.WriteLine(item.insMemory);
                        machineCode.machineCode = machineCode.machineCode + Convert.ToString(item.insMemory, 2).PadLeft(11, '0');
                    }

                }
            }



            return machineCode;


        }


    }
}
