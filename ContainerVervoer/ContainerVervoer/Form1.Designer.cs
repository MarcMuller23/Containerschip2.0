namespace ContainerVervoer
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
            this.AddContanerBtn = new System.Windows.Forms.Button();
            this.ContainerWeightNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ContainerTypeCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShipHeightNum = new System.Windows.Forms.NumericUpDown();
            this.SetShipBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ShipLengthNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ShipWidthNum = new System.Windows.Forms.NumericUpDown();
            this.AddedContainerLB = new System.Windows.Forms.ListBox();
            this.PlanContainersBtn = new System.Windows.Forms.Button();
            this.Stack1Lb = new System.Windows.Forms.ListBox();
            this.ShowVisual = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerWeightNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipHeightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipLengthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipWidthNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddContanerBtn);
            this.groupBox1.Controls.Add(this.ContainerWeightNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ContainerTypeCB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // AddContanerBtn
            // 
            this.AddContanerBtn.Location = new System.Drawing.Point(6, 128);
            this.AddContanerBtn.Name = "AddContanerBtn";
            this.AddContanerBtn.Size = new System.Drawing.Size(75, 23);
            this.AddContanerBtn.TabIndex = 12;
            this.AddContanerBtn.Text = "Add container";
            this.AddContanerBtn.UseVisualStyleBackColor = true;
            this.AddContanerBtn.Click += new System.EventHandler(this.AddContanerBtn_Click);
            // 
            // ContainerWeightNum
            // 
            this.ContainerWeightNum.Location = new System.Drawing.Point(9, 78);
            this.ContainerWeightNum.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ContainerWeightNum.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ContainerWeightNum.Name = "ContainerWeightNum";
            this.ContainerWeightNum.Size = new System.Drawing.Size(120, 20);
            this.ContainerWeightNum.TabIndex = 4;
            this.ContainerWeightNum.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight:";
            // 
            // ContainerTypeCB
            // 
            this.ContainerTypeCB.FormattingEnabled = true;
            this.ContainerTypeCB.Location = new System.Drawing.Point(9, 33);
            this.ContainerTypeCB.Name = "ContainerTypeCB";
            this.ContainerTypeCB.Size = new System.Drawing.Size(121, 21);
            this.ContainerTypeCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Container type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShipHeightNum);
            this.groupBox2.Controls.Add(this.SetShipBtn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ShipLengthNum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ShipWidthNum);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 208);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ship:";
            // 
            // ShipHeightNum
            // 
            this.ShipHeightNum.Location = new System.Drawing.Point(6, 127);
            this.ShipHeightNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ShipHeightNum.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ShipHeightNum.Name = "ShipHeightNum";
            this.ShipHeightNum.Size = new System.Drawing.Size(120, 20);
            this.ShipHeightNum.TabIndex = 12;
            this.ShipHeightNum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // SetShipBtn
            // 
            this.SetShipBtn.Location = new System.Drawing.Point(9, 179);
            this.SetShipBtn.Name = "SetShipBtn";
            this.SetShipBtn.Size = new System.Drawing.Size(75, 23);
            this.SetShipBtn.TabIndex = 11;
            this.SetShipBtn.Text = "Set ship";
            this.SetShipBtn.UseVisualStyleBackColor = true;
            this.SetShipBtn.Click += new System.EventHandler(this.SetShipBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "* In containers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "*Height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "*Length:";
            // 
            // ShipLengthNum
            // 
            this.ShipLengthNum.Location = new System.Drawing.Point(9, 88);
            this.ShipLengthNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ShipLengthNum.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ShipLengthNum.Name = "ShipLengthNum";
            this.ShipLengthNum.Size = new System.Drawing.Size(120, 20);
            this.ShipLengthNum.TabIndex = 7;
            this.ShipLengthNum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Width:";
            // 
            // ShipWidthNum
            // 
            this.ShipWidthNum.Location = new System.Drawing.Point(9, 49);
            this.ShipWidthNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ShipWidthNum.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ShipWidthNum.Name = "ShipWidthNum";
            this.ShipWidthNum.Size = new System.Drawing.Size(120, 20);
            this.ShipWidthNum.TabIndex = 5;
            this.ShipWidthNum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // AddedContainerLB
            // 
            this.AddedContainerLB.FormattingEnabled = true;
            this.AddedContainerLB.Location = new System.Drawing.Point(165, 12);
            this.AddedContainerLB.Name = "AddedContainerLB";
            this.AddedContainerLB.Size = new System.Drawing.Size(197, 407);
            this.AddedContainerLB.TabIndex = 6;
            // 
            // PlanContainersBtn
            // 
            this.PlanContainersBtn.Enabled = false;
            this.PlanContainersBtn.Location = new System.Drawing.Point(6, 399);
            this.PlanContainersBtn.Name = "PlanContainersBtn";
            this.PlanContainersBtn.Size = new System.Drawing.Size(136, 23);
            this.PlanContainersBtn.TabIndex = 13;
            this.PlanContainersBtn.Text = "Make planning";
            this.PlanContainersBtn.UseVisualStyleBackColor = true;
            this.PlanContainersBtn.Click += new System.EventHandler(this.PlanContainersBtn_Click);
            // 
            // Stack1Lb
            // 
            this.Stack1Lb.FormattingEnabled = true;
            this.Stack1Lb.Location = new System.Drawing.Point(385, 12);
            this.Stack1Lb.Name = "Stack1Lb";
            this.Stack1Lb.Size = new System.Drawing.Size(197, 407);
            this.Stack1Lb.TabIndex = 14;
            // 
            // ShowVisual
            // 
            this.ShowVisual.Location = new System.Drawing.Point(34, 467);
            this.ShowVisual.Name = "ShowVisual";
            this.ShowVisual.Size = new System.Drawing.Size(136, 23);
            this.ShowVisual.TabIndex = 15;
            this.ShowVisual.Text = "visual";
            this.ShowVisual.UseVisualStyleBackColor = true;
            this.ShowVisual.Click += new System.EventHandler(this.ShowVisual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.ShowVisual);
            this.Controls.Add(this.Stack1Lb);
            this.Controls.Add(this.PlanContainersBtn);
            this.Controls.Add(this.AddedContainerLB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerWeightNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipHeightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipLengthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipWidthNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ContainerWeightNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ContainerTypeCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ShipWidthNum;
        private System.Windows.Forms.Button AddContanerBtn;
        private System.Windows.Forms.Button SetShipBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ShipLengthNum;
        private System.Windows.Forms.ListBox AddedContainerLB;
        private System.Windows.Forms.Button PlanContainersBtn;
        private System.Windows.Forms.NumericUpDown ShipHeightNum;
        private System.Windows.Forms.ListBox Stack1Lb;
        private System.Windows.Forms.Button ShowVisual;
    }
}

