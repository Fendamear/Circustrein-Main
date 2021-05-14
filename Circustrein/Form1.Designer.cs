
namespace Circustrein
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
            this.components = new System.ComponentModel.Container();
            this.TBname = new System.Windows.Forms.TextBox();
            this.TBanimalAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RBsmall = new System.Windows.Forms.RadioButton();
            this.RBmedium = new System.Windows.Forms.RadioButton();
            this.RBlarge = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvAnimals = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtDeleteAnimal = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.CBCarn = new System.Windows.Forms.CheckBox();
            this.LbTrain = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBname
            // 
            this.TBname.Location = new System.Drawing.Point(66, 55);
            this.TBname.Multiline = true;
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(127, 25);
            this.TBname.TabIndex = 2;
            // 
            // TBanimalAdd
            // 
            this.TBanimalAdd.Location = new System.Drawing.Point(6, 212);
            this.TBanimalAdd.Name = "TBanimalAdd";
            this.TBanimalAdd.Size = new System.Drawing.Size(123, 27);
            this.TBanimalAdd.TabIndex = 3;
            this.TBanimalAdd.Text = "Add Animal";
            this.TBanimalAdd.UseVisualStyleBackColor = true;
            this.TBanimalAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // RBsmall
            // 
            this.RBsmall.AutoSize = true;
            this.RBsmall.Location = new System.Drawing.Point(13, 20);
            this.RBsmall.Name = "RBsmall";
            this.RBsmall.Size = new System.Drawing.Size(50, 17);
            this.RBsmall.TabIndex = 6;
            this.RBsmall.TabStop = true;
            this.RBsmall.Text = "Small";
            this.RBsmall.UseVisualStyleBackColor = true;
            // 
            // RBmedium
            // 
            this.RBmedium.AutoSize = true;
            this.RBmedium.Location = new System.Drawing.Point(13, 43);
            this.RBmedium.Name = "RBmedium";
            this.RBmedium.Size = new System.Drawing.Size(62, 17);
            this.RBmedium.TabIndex = 7;
            this.RBmedium.TabStop = true;
            this.RBmedium.Text = "Medium";
            this.RBmedium.UseVisualStyleBackColor = true;
            // 
            // RBlarge
            // 
            this.RBlarge.AutoSize = true;
            this.RBlarge.Location = new System.Drawing.Point(13, 66);
            this.RBlarge.Name = "RBlarge";
            this.RBlarge.Size = new System.Drawing.Size(52, 17);
            this.RBlarge.TabIndex = 8;
            this.RBlarge.TabStop = true;
            this.RBlarge.Text = "Large";
            this.RBlarge.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvAnimals);
            this.groupBox1.Location = new System.Drawing.Point(242, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 426);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal";
            // 
            // lvAnimals
            // 
            this.lvAnimals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvAnimals.FullRowSelect = true;
            this.lvAnimals.HideSelection = false;
            this.lvAnimals.Location = new System.Drawing.Point(6, 19);
            this.lvAnimals.Name = "lvAnimals";
            this.lvAnimals.Scrollable = false;
            this.lvAnimals.Size = new System.Drawing.Size(265, 401);
            this.lvAnimals.TabIndex = 1;
            this.lvAnimals.UseCompatibleStateImageBehavior = false;
            this.lvAnimals.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 70;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LbTrain);
            this.groupBox2.Location = new System.Drawing.Point(519, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 426);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Train";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RBlarge);
            this.groupBox3.Controls.Add(this.RBsmall);
            this.groupBox3.Controls.Add(this.RBmedium);
            this.groupBox3.Location = new System.Drawing.Point(6, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Size";
            // 
            // BtDeleteAnimal
            // 
            this.BtDeleteAnimal.Location = new System.Drawing.Point(6, 245);
            this.BtDeleteAnimal.Name = "BtDeleteAnimal";
            this.BtDeleteAnimal.Size = new System.Drawing.Size(123, 27);
            this.BtDeleteAnimal.TabIndex = 16;
            this.BtDeleteAnimal.Text = "Delete Animal";
            this.BtDeleteAnimal.UseVisualStyleBackColor = true;
            this.BtDeleteAnimal.Click += new System.EventHandler(this.BtDeleteAnimal_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(6, 383);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(230, 65);
            this.BtnCalculate.TabIndex = 17;
            this.BtnCalculate.Text = "Calculate!";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // CBCarn
            // 
            this.CBCarn.AutoSize = true;
            this.CBCarn.Location = new System.Drawing.Point(6, 189);
            this.CBCarn.Name = "CBCarn";
            this.CBCarn.Size = new System.Drawing.Size(82, 17);
            this.CBCarn.TabIndex = 18;
            this.CBCarn.Text = "Is Carnivore";
            this.CBCarn.UseVisualStyleBackColor = true;
            // 
            // LbTrain
            // 
            this.LbTrain.FormattingEnabled = true;
            this.LbTrain.Location = new System.Drawing.Point(7, 19);
            this.LbTrain.Name = "LbTrain";
            this.LbTrain.Size = new System.Drawing.Size(262, 407);
            this.LbTrain.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBCarn);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.BtDeleteAnimal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBanimalAdd);
            this.Controls.Add(this.TBname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Button TBanimalAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBsmall;
        private System.Windows.Forms.RadioButton RBmedium;
        private System.Windows.Forms.RadioButton RBlarge;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtDeleteAnimal;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.CheckBox CBCarn;
        public System.Windows.Forms.ListView lvAnimals;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListBox LbTrain;
    }
}

