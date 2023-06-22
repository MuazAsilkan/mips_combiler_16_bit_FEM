using Mips16bits.DataBase;
using Mips16bits.Entity;
using Mips16bits.Mips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Mips16bits.Compiler
{
     class MipsCompiler
    {

        Dictionary<string, string> parserData = new Dictionary<string, string>();
        DataDb dataDb = new DataDb();
        ValueTable valueTable = new ValueTable();
        MachineCode data;
        Register rs, rt, rd;
        RegisterDb registerDb = new RegisterDb();
        Validator validator = new Validator();
        Operation operation = new Operation();
        ConverMipsToMachine converToMac = new ConverMipsToMachine();
        int temp = 0;

        public void compiler(Instruction instructions)
        {
            data = converToMac.converToMac(instructions);
            instructions.machCode = data.machineCode;
            string[] arraay = data.mipsCode.Split(" ");
            parserData.Add("type", valueTable.getType(arraay[0]));
            parserData.Add("oppCode", data.machineCode.Substring(0, 5));
            string funcName = valueTable.getname(parserData["oppCode"]);
            switch (parserData["type"])
            {
                case "R":
                    parserData.Add("rd", data.machineCode.Substring(5, 3)); // eklenecek
                    parserData.Add("rt", data.machineCode.Substring(8, 3));// shiftlencek
                    parserData.Add("rs", data.machineCode.Substring(11, 3)); // shift

                    
                    switch (funcName)
                    {
                        case "add":
                            rs = registerDb.getRegisterWithRegisterValue(parserData["rs"]);
                            rt = registerDb.getRegisterWithRegisterValue(parserData["rt"]);
                            rd = registerDb.getRegisterWithRegisterValue(parserData["rd"]);
                            validator.checkValue(rs.value, rt.value, rd.value);
                            rd.value = operation.add(rs.value, rt.value);
                            rd.value= int.Parse(rd.value).ToString("x8"); 
                            registerDb.assignValue(rd, rd.value);
                            Form1.pcCounter = Form1.pcCounter + 2;
                            break;

                        case "sub":
                            rs = registerDb.getRegisterWithRegisterValue(parserData["rs"]);
                            rt = registerDb.getRegisterWithRegisterValue(parserData["rt"]);
                            rd = registerDb.getRegisterWithRegisterValue(parserData["rd"]);
                           validator.checkValue(rs.value, rt.value, rd.value);
                            rd.value = operation.delete(rt.value, rs.value);
                            rd.value = int.Parse(rd.value).ToString("x8");
                            registerDb.assignValue(rd, rd.value);
                            Form1.pcCounter = Form1.pcCounter + 2;
                            break;

                        case "and":
                            rs = registerDb.getRegisterWithRegisterValue(parserData["rs"]);
                            rt = registerDb.getRegisterWithRegisterValue(parserData["rt"]);
                            rd = registerDb.getRegisterWithRegisterValue(parserData["rd"]);
                            validator.checkValue(rs.value, rt.value, rd.value);
                            rd.value = operation.and(rs.value, rt.value);
                            rd.value = int.Parse(rd.value).ToString("x8");
                            registerDb.assignValue(rd, rd.value);
                            Form1.pcCounter = Form1.pcCounter + 2;
                            break;


                        case "or":
                            rs = registerDb.getRegisterWithRegisterValue(parserData["rs"]);
                            rt = registerDb.getRegisterWithRegisterValue(parserData["rt"]);
                            rd = registerDb.getRegisterWithRegisterValue(parserData["rd"]);
                            validator.checkValue(rs.value, rt.value, rd.value);
                            rd.value = operation.or(rs.value, rt.value);
                            rd.value = int.Parse(rd.value).ToString("x8");
                            registerDb.assignValue(rd, rd.value);
                            Form1.pcCounter = Form1.pcCounter + 2;
                            break;
                        case "xor":
                            rs = registerDb.getRegisterWithRegisterValue(parserData["rs"]);
                            rt = registerDb.getRegisterWithRegisterValue(parserData["rt"]);
                            rd = registerDb.getRegisterWithRegisterValue(parserData["rd"]);
                            validator.checkValue(rs.value, rt.value, rd.value);
                            rd.value = operation.xor(rs.value, rt.value);
                            rd.value = int.Parse(rd.value).ToString("x8");
                            registerDb.assignValue(rd, rd.value);
                            Form1.pcCounter = Form1.pcCounter + 2;
                            break;

                        case "sll":
                            rs = registerDb.getRegisterWithRegisterValue(parserData["rs"]);
                            rt = registerDb.getRegisterWithRegisterValue(parserData["rt"]);
                            rd = registerDb.getRegisterWithRegisterValue(parserData["rd"]);
                            validator.checkValue(rs.value, rt.value, rd.value);
                            rd.value = operation.sll(rt.value, Convert.ToInt32(parserData["rs"], 2).ToString());
                            rd.value = int.Parse(rd.value).ToString("x8");

                            registerDb.assignValue(rd, rd.value);
                            Form1.pcCounter = Form1.pcCounter + 2;
                            break;

                        case "srl":
                            rs = registerDb.getRegisterWithRegisterValue(parserData["rs"]);
                            rt = registerDb.getRegisterWithRegisterValue(parserData["rt"]);
                            rd = registerDb.getRegisterWithRegisterValue(parserData["rd"]);
                            validator.checkValue(rs.value, rt.value, rd.value);
                            rd.value = operation.srl(rt.value, Convert.ToInt32(parserData["rs"], 2).ToString());
                            rd.value = int.Parse(rd.value).ToString("x8");
                            registerDb.assignValue(rd, rd.value);
                            Form1.pcCounter = Form1.pcCounter + 2;
                            break;

                        case "jr":
                            Register r = registerDb.getRegister("$ra");
                            Form1.pcCounter = Convert.ToInt32(r.value, 16);
                            Form1.i = temp;
                            Form1.pcCounter = Form1.pcCounter + 2;
                            break;
                        default:
                            break;
                    }



                    break;



                case "I":
                    parserData.Add("rs", data.machineCode.Substring(5, 3));
                    parserData.Add("rt", data.machineCode.Substring(8, 3));
                    parserData.Add("imm", data.machineCode.Substring(11, 5));
                    rs = registerDb.getRegisterWithRegisterValue(parserData["rs"]);
                    rt = registerDb.getRegisterWithRegisterValue(parserData["rt"]);
                    string imm = parserData["imm"];
                    switch (funcName)
                    {
                        case "addi":
                            rs.value = operation.add(rt.value, "0x" + Convert.ToInt32(imm, 2).ToString("X"));
                            rs.value = int.Parse(rs.value).ToString("x8");
                            registerDb.assignValue(rs, rs.value);
                            Form1.pcCounter = Form1.pcCounter + 2;
                            break;
                        case "subi":
                            rs.value = operation.delete(rt.value, "0x" + Convert.ToInt32(imm, 2).ToString("X"));
                            rs.value = int.Parse(rs.value).ToString("x8");
                            registerDb.assignValue(rs, rs.value);
                            Form1.pcCounter = Form1.pcCounter + 2;
                            break;
                        case "andi":
                            rs.value = operation.and(rt.value, "0x" + Convert.ToInt32(imm, 2).ToString("X"));
                            rs.value = int.Parse(rs.value).ToString("x8");
                            registerDb.assignValue(rs, rs.value);
                            Form1.pcCounter = Form1.pcCounter + 2;
                            break;
                        case "ori":
                            rs.value = operation.or(rt.value, "0x" + Convert.ToInt32(imm, 2).ToString("X"));
                            rs.value = int.Parse(rs.value).ToString("x8");
                            registerDb.assignValue(rs, rs.value);
                            Form1.pcCounter = Form1.pcCounter + 2;
                            break;
                        case "beq":
                            string isEq= operation.beq(rt.value,  rs.value);
                            if (isEq=="1")
                            {
                                Form1.pcCounter = Convert.ToInt32(imm, 2) +2;

                            }
                            else
                            {
                                Form1.pcCounter = Form1.pcCounter+ 2;

                            }
                          
                            break;
                        case "bne":
                             isEq = operation.bne(rt.value, rs.value);
                            if (isEq == "1")
                            {
                                Form1.pcCounter = Convert.ToInt32(imm, 2) + 2;

                            }
                            else
                            {
                                Form1.pcCounter = Form1.pcCounter+ 2;

                            }

                            break;

                        case "sw":
                            string addressHex = operation.sw(rt.value, imm);
                            dataDb.createData(addressHex, rs.value);
                            Form1.pcCounter = Form1.pcCounter + 2;
                            break;
                        case "lw":
                            string addressHexLw = operation.lw(rt.value, imm);
                            string dataValue = dataDb.getValue(addressHexLw);
                            registerDb.assignValue(rs, dataValue.Remove(0, 2));
                            Form1.pcCounter = Form1.pcCounter + 2;
                            break;
                        default:
                            break;
                    }

                    break;


                case "J":
                  
                    switch (funcName)
                    {
                        case "j":
                            parserData.Add("imm", data.machineCode.Substring(5));
                            imm = parserData["imm"];
                            Form1.pcCounter = Convert.ToInt32(imm, 2) + 2;
                            break;
                        case "jal":

                            parserData.Add("imm", data.machineCode.Substring(5));
                            imm = parserData["imm"];
                            Register r = registerDb.getRegister("$ra");
                            Console.WriteLine(Form1.pcCounter);
                            r.value = "0x"+ Form1.pcCounter.ToString("x8");
                            temp = Form1.i;
                            Form1.pcCounter = Convert.ToInt32(imm, 2) + 2;
                            break;
                        default:
                            break;
                    }

                    break;

                
            }
            parserData.Clear();

        }


        


    }
}