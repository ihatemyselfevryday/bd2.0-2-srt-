
using System;
using System.Windows.Forms;

namespace WinForms
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            button5 = new Button();
            textBox2 = new TextBox();
            button6 = new Button();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(278, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(575, 252);
            dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(12, 186);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 20);
            button2.TabIndex = 1;
            button2.Text = "show";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "component type", "components", "components-build", "manufacturer", "order", "customer", "build" });
            listBox1.Location = new System.Drawing.Point(12, 11);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(237, 169);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(174, 186);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 20);
            button1.TabIndex = 4;
            button1.Text = "delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(93, 186);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 20);
            button3.TabIndex = 5;
            button3.Text = "add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(12, 269);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(237, 22);
            button4.TabIndex = 6;
            button4.Text = "sort";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(12, 212);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(156, 23);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "asc", "desc" });
            comboBox2.Location = new System.Drawing.Point(174, 212);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(75, 23);
            comboBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(278, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(494, 23);
            textBox1.TabIndex = 11;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(778, 274);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "search";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(12, 305);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(760, 133);
            textBox2.TabIndex = 13;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(778, 305);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(75, 132);
            button6.TabIndex = 14;
            button6.Text = "sql";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new System.Drawing.Point(12, 241);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new System.Drawing.Size(156, 23);
            comboBox5.TabIndex = 15;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "asc", "desc" });
            comboBox6.Location = new System.Drawing.Point(174, 240);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new System.Drawing.Size(75, 23);
            comboBox6.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(865, 449);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(button6);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private ListBox listBox1;
        private Button button1;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private TextBox textBox1;
        private Button button5;
        private TextBox textBox2;
        private Button button6;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
    }
}

