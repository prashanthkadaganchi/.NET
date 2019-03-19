namespace Assign2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quit = new System.Windows.Forms.RadioButton();
            this.sortList = new System.Windows.Forms.RadioButton();
            this.changeOff_Num = new System.Windows.Forms.RadioButton();
            this.searchTel_Num = new System.Windows.Forms.RadioButton();
            this.searchOff_Num = new System.Windows.Forms.RadioButton();
            this.searchName = new System.Windows.Forms.RadioButton();
            this.addEntry = new System.Windows.Forms.RadioButton();
            this.printList = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quit);
            this.groupBox1.Controls.Add(this.sortList);
            this.groupBox1.Controls.Add(this.changeOff_Num);
            this.groupBox1.Controls.Add(this.searchTel_Num);
            this.groupBox1.Controls.Add(this.searchOff_Num);
            this.groupBox1.Controls.Add(this.searchName);
            this.groupBox1.Controls.Add(this.addEntry);
            this.groupBox1.Controls.Add(this.printList);
            this.groupBox1.Location = new System.Drawing.Point(30, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose an option below";
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Location = new System.Drawing.Point(7, 181);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(44, 17);
            this.quit.TabIndex = 7;
            this.quit.TabStop = true;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            // 
            // sortList
            // 
            this.sortList.AutoSize = true;
            this.sortList.Location = new System.Drawing.Point(7, 158);
            this.sortList.Name = "sortList";
            this.sortList.Size = new System.Drawing.Size(77, 17);
            this.sortList.TabIndex = 6;
            this.sortList.TabStop = true;
            this.sortList.Text = "Sort the list";
            this.sortList.UseVisualStyleBackColor = true;
            // 
            // changeOff_Num
            // 
            this.changeOff_Num.AutoSize = true;
            this.changeOff_Num.Location = new System.Drawing.Point(7, 135);
            this.changeOff_Num.Name = "changeOff_Num";
            this.changeOff_Num.Size = new System.Drawing.Size(144, 17);
            this.changeOff_Num.TabIndex = 5;
            this.changeOff_Num.TabStop = true;
            this.changeOff_Num.Text = "Change an office number";
            this.changeOff_Num.UseVisualStyleBackColor = true;
            // 
            // searchTel_Num
            // 
            this.searchTel_Num.AutoSize = true;
            this.searchTel_Num.Location = new System.Drawing.Point(7, 112);
            this.searchTel_Num.Name = "searchTel_Num";
            this.searchTel_Num.Size = new System.Drawing.Size(168, 17);
            this.searchTel_Num.TabIndex = 4;
            this.searchTel_Num.TabStop = true;
            this.searchTel_Num.Tag = "";
            this.searchTel_Num.Text = "Seach for a telephone number";
            this.searchTel_Num.UseVisualStyleBackColor = true;
            // 
            // searchOff_Num
            // 
            this.searchOff_Num.AutoSize = true;
            this.searchOff_Num.Location = new System.Drawing.Point(7, 89);
            this.searchOff_Num.Name = "searchOff_Num";
            this.searchOff_Num.Size = new System.Drawing.Size(153, 17);
            this.searchOff_Num.TabIndex = 3;
            this.searchOff_Num.TabStop = true;
            this.searchOff_Num.Text = "Seach for an office number";
            this.searchOff_Num.UseVisualStyleBackColor = true;
            this.searchOff_Num.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // searchName
            // 
            this.searchName.AutoSize = true;
            this.searchName.Location = new System.Drawing.Point(7, 66);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(112, 17);
            this.searchName.TabIndex = 2;
            this.searchName.TabStop = true;
            this.searchName.Text = "Search for a name";
            this.searchName.UseVisualStyleBackColor = true;
            // 
            // addEntry
            // 
            this.addEntry.AutoSize = true;
            this.addEntry.Location = new System.Drawing.Point(7, 43);
            this.addEntry.Name = "addEntry";
            this.addEntry.Size = new System.Drawing.Size(85, 17);
            this.addEntry.TabIndex = 1;
            this.addEntry.TabStop = true;
            this.addEntry.Text = "Add an entry";
            this.addEntry.UseVisualStyleBackColor = true;
            // 
            // printList
            // 
            this.printList.AutoSize = true;
            this.printList.Location = new System.Drawing.Point(7, 20);
            this.printList.Name = "printList";
            this.printList.Size = new System.Drawing.Size(87, 17);
            this.printList.TabIndex = 0;
            this.printList.TabStop = true;
            this.printList.Text = "Print The List";
            this.printList.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(316, 289);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(29, 329);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(387, 121);
            this.listBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter a name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter an office number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter a telephone number";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Employee Details";
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(187, 466);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(75, 23);
            this.clearAll.TabIndex = 9;
            this.clearAll.Text = "Clear All";
            this.clearAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 511);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TestForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton quit;
        private System.Windows.Forms.RadioButton sortList;
        private System.Windows.Forms.RadioButton changeOff_Num;
        private System.Windows.Forms.RadioButton searchTel_Num;
        private System.Windows.Forms.RadioButton searchOff_Num;
        private System.Windows.Forms.RadioButton searchName;
        private System.Windows.Forms.RadioButton addEntry;
        private System.Windows.Forms.RadioButton printList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearAll;
    }
}

