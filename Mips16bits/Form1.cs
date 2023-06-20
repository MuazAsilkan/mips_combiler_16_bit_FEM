using Mips16bits.Compiler;
using Mips16bits.DataBase;
using Mips16bits.Entity;
using Mips16bits.Mips;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mips16bits
{
    public partial class Form1 : Form
    {
        DataDb dataDb = new DataDb();
        RegisterDb registerdb = new RegisterDb();
        ListViewItem item;
        ConverMipsToMachine convert = new ConverMipsToMachine();
        Instruction ins = new Instruction();
        int insMemory =0x00000000;
        public static List<Instruction> ınstructions = new List<Instruction>();
        public static int pcCounter = 0x00000000;
        public static int i = 0;
        MipsCompiler compiler = new MipsCompiler();


        public Form1()
        {


            InitializeComponent();
        }


        private void showAllRegister()
        {
            foreach (Register s in registerdb.getRegisters())
            {

                this.item = new ListViewItem(s.name);
                this.item.SubItems.Add(s.number);
                this.item.SubItems.Add(s.value);

                listView1.Items.Add(item);

            }
        }

        private void showAllData()
        {
            foreach (Data d in dataDb.getDatas())
            {

                this.item = new ListViewItem(d.adress);
                this.item.SubItems.Add(d.value0);
                this.item.SubItems.Add(d.value1);

                listView2.Items.Add(item);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            this.listView2.Items.Clear();
            showAllRegister();
            showAllData();
        }

        public void createInstruction()
        {

            int k = 0;

            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {


                string[] variableList = string.Join("", richTextBox1.Lines[i].Split(" ").Skip(1).ToArray()).Split(",");
             

                if (string.IsNullOrEmpty(richTextBox1.Lines[i]))
                {
                    continue;
                }


                else
                {
                    
                    int val = this.insMemory + (k * 2);
                    if (richTextBox1.Lines[i].Contains(":"))
                    {
                        ins = new Instruction(richTextBox1.Lines[i], val, 1);
                    }
                    else
                    {
                        ins = new Instruction(richTextBox1.Lines[i], val,0);
                    }

                    ınstructions.Add(ins);
    

                    k++;



                }


            }
          

            //runInstruction();
        }


        public void runInstructions()
            
        {
            for( i=0 ; i<=ınstructions.Count; i++)
            {
                try
                {
                    if (pcCounter == ınstructions[i].insMemory)
                    {
                        if (ınstructions[i].data == "exit")
                        {
                            break;
                        }
                        if (ınstructions[i].runned == 0)
                        {
                            compiler.compiler(ınstructions[i]);
                            ınstructions[i].runned = 1;
                        }


                    }
                }
                catch { }
            }
         
            
            registerdb.assignValue(registerdb.getRegister("$pc"), (pcCounter-2).ToString("x8"));
            ınstructions.Clear();
            pcCounter = 0x00000000;
        }


        public void runInstruction()
        {
            try
            {
                if (pcCounter == ınstructions[i].insMemory)
                {
                    if (ınstructions[i].data == "exit")
                    {
                        
                    }
                    if (ınstructions[i].runned == 0)
                    {
                        compiler.compiler(ınstructions[i]);
                        ınstructions[i].runned = 1;
                    }
                    
                    //Dim searchWord As String = "James"
                    int startingPos= richTextBox1.Find(ınstructions[i].data);
                    richTextBox1.Select(startingPos, ınstructions[i].data.Length);
                    richTextBox1.SelectionColor = Color.Red;
                    
                    /*
                    this.richTextBox1.Select(i,1);
                    this.richTextBox1.SelectionBackColor = Color.Aqua;*/
                    //this.richTextBox1.Select(0, 0);
                    string func = ınstructions[i].data.Split(' ')[0];
                    if (func!="jal")
                    {
                        registerdb.assignValue(registerdb.getRegister("$pc"), (pcCounter - 2).ToString("x8"));
                    }
                    else
                    {
                        registerdb.assignValue(registerdb.getRegister("$pc"), (pcCounter).ToString("x8"));
                    }
                    ınstructions.Clear();
                    
                }
                i++;
            }
            catch { }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            createInstruction();
            runInstructions();
            this.listView1.Items.Clear();
            this.listView2.Items.Clear();
            showAllRegister();
            showAllData();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            createInstruction();
            runInstruction();
            this.listView1.Items.Clear();
            this.listView2.Items.Clear();
            showAllRegister();
            showAllData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.listView1.Items.Clear();
            this.listView2.Items.Clear();
            DataDb dataDb = new DataDb();
            RegisterDb registerdb = new RegisterDb();
            showAllRegister();
            showAllData();
            ınstructions.Clear();
            i = 0;
            pcCounter = 0x00000000;
        }
    }
}