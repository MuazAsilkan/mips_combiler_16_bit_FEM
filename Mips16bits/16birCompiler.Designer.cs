
namespace Mips16bits
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Adress = new System.Windows.Forms.ColumnHeader();
            this.Value1 = new System.Windows.Forms.ColumnHeader();
            this.Value2 = new System.Windows.Forms.ColumnHeader();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.counter = new System.Windows.Forms.ColumnHeader();
            this.machcode = new System.Windows.Forms.ColumnHeader();
            this.MachCodeHex = new System.Windows.Forms.ColumnHeader();
            this.code2 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(33)))));
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(12, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(803, 435);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(33)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.ForeColor = System.Drawing.Color.Lime;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(874, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(245, 645);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "index";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.Width = 120;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(544, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 44);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(838, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 44);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(33)))));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Adress,
            this.Value1,
            this.Value2});
            this.listView2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView2.ForeColor = System.Drawing.Color.Lime;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 527);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(803, 187);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Adress
            // 
            this.Adress.Text = "Adress";
            this.Adress.Width = 120;
            // 
            // Value1
            // 
            this.Value1.Text = "Value1";
            this.Value1.Width = 120;
            // 
            // Value2
            // 
            this.Value2.Text = "Value2";
            this.Value2.Width = 120;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(992, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 44);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 31.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSalmon;
            this.label1.Location = new System.Drawing.Point(12, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 65);
            this.label1.TabIndex = 8;
            this.label1.Text = "FEM    Compiler";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(688, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 44);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(33)))));
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.counter,
            this.machcode,
            this.MachCodeHex,
            this.code2});
            this.listView3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView3.ForeColor = System.Drawing.Color.Lime;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(12, 69);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(803, 435);
            this.listView3.TabIndex = 10;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.Visible = false;
            // 
            // counter
            // 
            this.counter.Text = "Counter";
            this.counter.Width = 120;
            // 
            // machcode
            // 
            this.machcode.Text = "MachineCode";
            this.machcode.Width = 200;
            // 
            // MachCodeHex
            // 
            this.MachCodeHex.Text = "MachCode Hex";
            this.MachCodeHex.Width = 200;
            // 
            // code2
            // 
            this.code2.Text = "Code";
            this.code2.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1170, 726);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Adress;
        private System.Windows.Forms.ColumnHeader Value1;
        private System.Windows.Forms.ColumnHeader Value2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader counter;
        private System.Windows.Forms.ColumnHeader machcode;
        private System.Windows.Forms.ColumnHeader MachCodeHex;
        private System.Windows.Forms.ColumnHeader code2;
    }
}

