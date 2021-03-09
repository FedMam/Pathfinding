
namespace Pathfinding
{
    partial class GenerateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.genB = new System.Windows.Forms.Button();
            this.cancB = new System.Windows.Forms.Button();
            this.okB = new System.Windows.Forms.Button();
            this.sizeL = new System.Windows.Forms.Label();
            this.xS = new System.Windows.Forms.NumericUpDown();
            this.yS = new System.Windows.Forms.NumericUpDown();
            this.cost = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dots",
            "Walls",
            "Islands",
            "Maze (algorithm 1)",
            "Maze (algorithm 2)"});
            this.comboBox1.Location = new System.Drawing.Point(52, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // genB
            // 
            this.genB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.genB.Location = new System.Drawing.Point(264, 39);
            this.genB.Name = "genB";
            this.genB.Size = new System.Drawing.Size(75, 23);
            this.genB.TabIndex = 2;
            this.genB.Text = "Generate";
            this.genB.UseVisualStyleBackColor = true;
            this.genB.Click += new System.EventHandler(this.genB_Click);
            // 
            // cancB
            // 
            this.cancB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancB.Location = new System.Drawing.Point(264, 255);
            this.cancB.Name = "cancB";
            this.cancB.Size = new System.Drawing.Size(75, 23);
            this.cancB.TabIndex = 3;
            this.cancB.Text = "Cancel";
            this.cancB.UseVisualStyleBackColor = true;
            this.cancB.Click += new System.EventHandler(this.cancB_Click);
            // 
            // okB
            // 
            this.okB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okB.Location = new System.Drawing.Point(264, 226);
            this.okB.Name = "okB";
            this.okB.Size = new System.Drawing.Size(75, 23);
            this.okB.TabIndex = 4;
            this.okB.Text = "OK";
            this.okB.UseVisualStyleBackColor = true;
            this.okB.Click += new System.EventHandler(this.okB_Click);
            // 
            // sizeL
            // 
            this.sizeL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeL.AutoSize = true;
            this.sizeL.Location = new System.Drawing.Point(261, 65);
            this.sizeL.Name = "sizeL";
            this.sizeL.Size = new System.Drawing.Size(30, 13);
            this.sizeL.TabIndex = 5;
            this.sizeL.Text = "Size:";
            // 
            // xS
            // 
            this.xS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xS.Location = new System.Drawing.Point(264, 81);
            this.xS.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.xS.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.xS.Name = "xS";
            this.xS.Size = new System.Drawing.Size(75, 20);
            this.xS.TabIndex = 6;
            this.xS.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.xS.ValueChanged += new System.EventHandler(this.xS_ValueChanged);
            // 
            // yS
            // 
            this.yS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yS.Location = new System.Drawing.Point(264, 107);
            this.yS.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.yS.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.yS.Name = "yS";
            this.yS.Size = new System.Drawing.Size(75, 20);
            this.yS.TabIndex = 7;
            this.yS.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.yS.ValueChanged += new System.EventHandler(this.yS_ValueChanged);
            // 
            // cost
            // 
            this.cost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(264, 133);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(81, 17);
            this.cost.TabIndex = 8;
            this.cost.Text = "Higher Cost";
            this.cost.UseVisualStyleBackColor = true;
            this.cost.CheckedChanged += new System.EventHandler(this.cost_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cells";
            // 
            // GenerateForm
            // 
            this.AcceptButton = this.okB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancB;
            this.ClientSize = new System.Drawing.Size(351, 290);
            this.Controls.Add(this.okB);
            this.Controls.Add(this.cancB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.yS);
            this.Controls.Add(this.xS);
            this.Controls.Add(this.sizeL);
            this.Controls.Add(this.genB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GenerateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Map";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GenerateForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.xS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button genB;
        private System.Windows.Forms.Button cancB;
        private System.Windows.Forms.Button okB;
        private System.Windows.Forms.Label sizeL;
        private System.Windows.Forms.NumericUpDown xS;
        private System.Windows.Forms.NumericUpDown yS;
        private System.Windows.Forms.CheckBox cost;
        private System.Windows.Forms.Label label2;
    }
}