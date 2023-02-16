namespace Inventory
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
            this.btnExit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnaddItem = new System.Windows.Forms.Button();
            this.btndeleteItem = new System.Windows.Forms.Button();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(682, 113);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Add Item";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // btnaddItem
            // 
            this.btnaddItem.Location = new System.Drawing.Point(760, 56);
            this.btnaddItem.Name = "btnaddItem";
            this.btnaddItem.Size = new System.Drawing.Size(150, 46);
            this.btnaddItem.TabIndex = 0;
            this.btnaddItem.Text = "Add Item";
            this.btnaddItem.UseVisualStyleBackColor = true;
            this.btnaddItem.Click += new System.EventHandler(this.btnaddItem_Click);
            // 
            // btndeleteItem
            // 
            this.btndeleteItem.Location = new System.Drawing.Point(760, 150);
            this.btndeleteItem.Name = "btndeleteItem";
            this.btndeleteItem.Size = new System.Drawing.Size(150, 46);
            this.btndeleteItem.TabIndex = 1;
            this.btndeleteItem.Text = "Delete Item";
            this.btndeleteItem.UseVisualStyleBackColor = true;
            this.btndeleteItem.Click += new System.EventHandler(this.btndeleteItem_Click);
            // 
            // btnExit1
            // 
            this.btnExit1.Location = new System.Drawing.Point(760, 245);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(150, 46);
            this.btnExit1.TabIndex = 2;
            this.btnExit1.Text = "Exit";
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(518, 350);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(944, 533);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit1);
            this.Controls.Add(this.btndeleteItem);
            this.Controls.Add(this.btnaddItem);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExit;
        private Button button2;
        private Button button3;
        private Button btnaddItem;
        private Button btndeleteItem;
        private Button btnExit1;
        private TextBox textBox1;
    }
}