namespace Pathfinding
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
            this.toolbox = new System.Windows.Forms.Panel();
            this.hL = new System.Windows.Forms.Label();
            this.heuristicPanel = new System.Windows.Forms.Panel();
            this.heuristic2 = new System.Windows.Forms.RadioButton();
            this.heuristic1 = new System.Windows.Forms.RadioButton();
            this.diagCB = new System.Windows.Forms.CheckBox();
            this.astarRB = new System.Windows.Forms.RadioButton();
            this.costCB = new System.Windows.Forms.CheckBox();
            this.bestfirstRB = new System.Windows.Forms.RadioButton();
            this.dfsRB = new System.Windows.Forms.RadioButton();
            this.dijkstraRB = new System.Windows.Forms.RadioButton();
            this.cost = new System.Windows.Forms.NumericUpDown();
            this.bfsRB = new System.Windows.Forms.RadioButton();
            this.ySize = new System.Windows.Forms.NumericUpDown();
            this.yL = new System.Windows.Forms.Label();
            this.xL = new System.Windows.Forms.Label();
            this.xSize = new System.Windows.Forms.NumericUpDown();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.themeButton = new System.Windows.Forms.Button();
            this.showCB = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.controlPanel = new System.Windows.Forms.Panel();
            this.generateB = new System.Windows.Forms.Button();
            this.saveB = new System.Windows.Forms.Button();
            this.loadB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.statsBox = new System.Windows.Forms.GroupBox();
            this.labelD = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.intervalLbl = new System.Windows.Forms.Label();
            this.intervalBar = new System.Windows.Forms.TrackBar();
            this.toolbox.SuspendLayout();
            this.heuristicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSize)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.statsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalBar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbox
            // 
            this.toolbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toolbox.BackColor = System.Drawing.SystemColors.Control;
            this.toolbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolbox.Controls.Add(this.hL);
            this.toolbox.Controls.Add(this.heuristicPanel);
            this.toolbox.Controls.Add(this.diagCB);
            this.toolbox.Controls.Add(this.astarRB);
            this.toolbox.Controls.Add(this.costCB);
            this.toolbox.Controls.Add(this.bestfirstRB);
            this.toolbox.Controls.Add(this.dfsRB);
            this.toolbox.Controls.Add(this.dijkstraRB);
            this.toolbox.Controls.Add(this.cost);
            this.toolbox.Controls.Add(this.bfsRB);
            this.toolbox.Controls.Add(this.ySize);
            this.toolbox.Controls.Add(this.yL);
            this.toolbox.Controls.Add(this.xL);
            this.toolbox.Controls.Add(this.xSize);
            this.toolbox.Controls.Add(this.sizeLabel);
            this.toolbox.Controls.Add(this.runButton);
            this.toolbox.Location = new System.Drawing.Point(0, 0);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(150, 480);
            this.toolbox.TabIndex = 0;
            // 
            // hL
            // 
            this.hL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hL.AutoSize = true;
            this.hL.Location = new System.Drawing.Point(8, 412);
            this.hL.Name = "hL";
            this.hL.Size = new System.Drawing.Size(48, 13);
            this.hL.TabIndex = 16;
            this.hL.Text = "Heuristic";
            // 
            // heuristicPanel
            // 
            this.heuristicPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.heuristicPanel.Controls.Add(this.heuristic2);
            this.heuristicPanel.Controls.Add(this.heuristic1);
            this.heuristicPanel.Location = new System.Drawing.Point(3, 418);
            this.heuristicPanel.Name = "heuristicPanel";
            this.heuristicPanel.Size = new System.Drawing.Size(140, 61);
            this.heuristicPanel.TabIndex = 15;
            // 
            // heuristic2
            // 
            this.heuristic2.AutoSize = true;
            this.heuristic2.Location = new System.Drawing.Point(10, 33);
            this.heuristic2.Name = "heuristic2";
            this.heuristic2.Size = new System.Drawing.Size(115, 17);
            this.heuristic2.TabIndex = 1;
            this.heuristic2.Text = "Euclidean distance";
            this.heuristic2.UseVisualStyleBackColor = true;
            // 
            // heuristic1
            // 
            this.heuristic1.AutoSize = true;
            this.heuristic1.Checked = true;
            this.heuristic1.Location = new System.Drawing.Point(10, 10);
            this.heuristic1.Name = "heuristic1";
            this.heuristic1.Size = new System.Drawing.Size(119, 17);
            this.heuristic1.TabIndex = 0;
            this.heuristic1.TabStop = true;
            this.heuristic1.Text = "Manhattan distance";
            this.heuristic1.UseVisualStyleBackColor = true;
            // 
            // diagCB
            // 
            this.diagCB.AutoSize = true;
            this.diagCB.Location = new System.Drawing.Point(14, 100);
            this.diagCB.Name = "diagCB";
            this.diagCB.Size = new System.Drawing.Size(121, 17);
            this.diagCB.TabIndex = 14;
            this.diagCB.Text = "Diagonal Movement";
            this.diagCB.UseVisualStyleBackColor = true;
            this.diagCB.CheckedChanged += new System.EventHandler(this.diagCB_CheckedChanged);
            // 
            // astarRB
            // 
            this.astarRB.AutoSize = true;
            this.astarRB.Location = new System.Drawing.Point(14, 264);
            this.astarRB.Name = "astarRB";
            this.astarRB.Size = new System.Drawing.Size(82, 17);
            this.astarRB.TabIndex = 11;
            this.astarRB.Text = "A* Algorithm";
            this.astarRB.UseVisualStyleBackColor = true;
            this.astarRB.CheckedChanged += new System.EventHandler(this.astarRB_CheckedChanged);
            // 
            // costCB
            // 
            this.costCB.AutoSize = true;
            this.costCB.Location = new System.Drawing.Point(14, 123);
            this.costCB.Name = "costCB";
            this.costCB.Size = new System.Drawing.Size(106, 17);
            this.costCB.TabIndex = 12;
            this.costCB.Text = "Higher Cost Cells";
            this.costCB.UseVisualStyleBackColor = true;
            this.costCB.CheckedChanged += new System.EventHandler(this.costCB_CheckedChanged);
            // 
            // bestfirstRB
            // 
            this.bestfirstRB.AutoSize = true;
            this.bestfirstRB.Location = new System.Drawing.Point(14, 241);
            this.bestfirstRB.Name = "bestfirstRB";
            this.bestfirstRB.Size = new System.Drawing.Size(105, 17);
            this.bestfirstRB.TabIndex = 10;
            this.bestfirstRB.Text = "Best-First Search";
            this.bestfirstRB.UseVisualStyleBackColor = true;
            this.bestfirstRB.CheckedChanged += new System.EventHandler(this.bestfirstRB_CheckedChanged);
            // 
            // dfsRB
            // 
            this.dfsRB.AutoSize = true;
            this.dfsRB.Location = new System.Drawing.Point(14, 172);
            this.dfsRB.Name = "dfsRB";
            this.dfsRB.Size = new System.Drawing.Size(113, 17);
            this.dfsRB.TabIndex = 7;
            this.dfsRB.Text = "Depth First Search";
            this.dfsRB.UseVisualStyleBackColor = true;
            this.dfsRB.CheckedChanged += new System.EventHandler(this.dfsRB_CheckedChanged);
            // 
            // dijkstraRB
            // 
            this.dijkstraRB.AutoSize = true;
            this.dijkstraRB.Location = new System.Drawing.Point(14, 218);
            this.dijkstraRB.Name = "dijkstraRB";
            this.dijkstraRB.Size = new System.Drawing.Size(113, 17);
            this.dijkstraRB.TabIndex = 9;
            this.dijkstraRB.Text = "Dijkstra\'s Algorithm";
            this.dijkstraRB.UseVisualStyleBackColor = true;
            this.dijkstraRB.CheckedChanged += new System.EventHandler(this.dijktraRB_CheckedChanged);
            // 
            // cost
            // 
            this.cost.Enabled = false;
            this.cost.Location = new System.Drawing.Point(14, 146);
            this.cost.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cost.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(112, 20);
            this.cost.TabIndex = 13;
            this.cost.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cost.ValueChanged += new System.EventHandler(this.cost_ValueChanged);
            // 
            // bfsRB
            // 
            this.bfsRB.AutoSize = true;
            this.bfsRB.Checked = true;
            this.bfsRB.Location = new System.Drawing.Point(14, 195);
            this.bfsRB.Name = "bfsRB";
            this.bfsRB.Size = new System.Drawing.Size(121, 17);
            this.bfsRB.TabIndex = 8;
            this.bfsRB.TabStop = true;
            this.bfsRB.Text = "Breadth First Search";
            this.bfsRB.UseVisualStyleBackColor = true;
            this.bfsRB.CheckedChanged += new System.EventHandler(this.bfsRB_CheckedChanged);
            // 
            // ySize
            // 
            this.ySize.Location = new System.Drawing.Point(31, 74);
            this.ySize.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.ySize.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ySize.Name = "ySize";
            this.ySize.Size = new System.Drawing.Size(112, 20);
            this.ySize.TabIndex = 6;
            this.ySize.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ySize.ValueChanged += new System.EventHandler(this.ySize_ValueChanged);
            // 
            // yL
            // 
            this.yL.AutoSize = true;
            this.yL.Location = new System.Drawing.Point(11, 76);
            this.yL.Name = "yL";
            this.yL.Size = new System.Drawing.Size(14, 13);
            this.yL.TabIndex = 5;
            this.yL.Text = "Y";
            // 
            // xL
            // 
            this.xL.AutoSize = true;
            this.xL.Location = new System.Drawing.Point(11, 53);
            this.xL.Name = "xL";
            this.xL.Size = new System.Drawing.Size(14, 13);
            this.xL.TabIndex = 4;
            this.xL.Text = "X";
            // 
            // xSize
            // 
            this.xSize.Location = new System.Drawing.Point(31, 51);
            this.xSize.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.xSize.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.xSize.Name = "xSize";
            this.xSize.Size = new System.Drawing.Size(112, 20);
            this.xSize.TabIndex = 3;
            this.xSize.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.xSize.ValueChanged += new System.EventHandler(this.xSize_ValueChanged);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(11, 37);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(30, 13);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Size:";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(11, 11);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(132, 23);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // themeButton
            // 
            this.themeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.themeButton.Location = new System.Drawing.Point(11, 11);
            this.themeButton.Name = "themeButton";
            this.themeButton.Size = new System.Drawing.Size(75, 39);
            this.themeButton.TabIndex = 14;
            this.themeButton.Text = "Change Theme";
            this.themeButton.UseVisualStyleBackColor = true;
            // 
            // showCB
            // 
            this.showCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showCB.AutoSize = true;
            this.showCB.Checked = true;
            this.showCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCB.Location = new System.Drawing.Point(2, 398);
            this.showCB.Name = "showCB";
            this.showCB.Size = new System.Drawing.Size(94, 17);
            this.showCB.TabIndex = 1;
            this.showCB.Text = "Show Process";
            this.showCB.UseVisualStyleBackColor = true;
            this.showCB.CheckedChanged += new System.EventHandler(this.showCB_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanel.Controls.Add(this.generateB);
            this.controlPanel.Controls.Add(this.saveB);
            this.controlPanel.Controls.Add(this.loadB);
            this.controlPanel.Controls.Add(this.clearB);
            this.controlPanel.Controls.Add(this.statsBox);
            this.controlPanel.Controls.Add(this.intervalLbl);
            this.controlPanel.Controls.Add(this.intervalBar);
            this.controlPanel.Controls.Add(this.themeButton);
            this.controlPanel.Controls.Add(this.showCB);
            this.controlPanel.Location = new System.Drawing.Point(630, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(100, 480);
            this.controlPanel.TabIndex = 1;
            // 
            // generateB
            // 
            this.generateB.Location = new System.Drawing.Point(12, 143);
            this.generateB.Name = "generateB";
            this.generateB.Size = new System.Drawing.Size(75, 23);
            this.generateB.TabIndex = 21;
            this.generateB.Text = "Generate...";
            this.generateB.UseVisualStyleBackColor = true;
            this.generateB.Click += new System.EventHandler(this.generateB_Click);
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(12, 114);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(75, 23);
            this.saveB.TabIndex = 20;
            this.saveB.Text = "Save Map";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // loadB
            // 
            this.loadB.Location = new System.Drawing.Point(11, 85);
            this.loadB.Name = "loadB";
            this.loadB.Size = new System.Drawing.Size(75, 23);
            this.loadB.TabIndex = 19;
            this.loadB.Text = "Load Map";
            this.loadB.UseVisualStyleBackColor = true;
            this.loadB.Click += new System.EventHandler(this.loadB_Click);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(11, 56);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 23);
            this.clearB.TabIndex = 18;
            this.clearB.Text = "Clear Map";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // statsBox
            // 
            this.statsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statsBox.Controls.Add(this.labelD);
            this.statsBox.Controls.Add(this.labelA);
            this.statsBox.Controls.Add(this.labelB);
            this.statsBox.Controls.Add(this.labelV);
            this.statsBox.Location = new System.Drawing.Point(11, 292);
            this.statsBox.Name = "statsBox";
            this.statsBox.Size = new System.Drawing.Size(76, 100);
            this.statsBox.TabIndex = 17;
            this.statsBox.TabStop = false;
            this.statsBox.Text = "Statistics";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(6, 74);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(61, 13);
            this.labelD.TabIndex = 3;
            this.labelD.Text = "Distance: 0";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(6, 29);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(27, 13);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "BFS";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(6, 16);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(53, 13);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "Algorithm:";
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(6, 48);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(50, 13);
            this.labelV.TabIndex = 0;
            this.labelV.Text = "Visited: 0";
            // 
            // intervalLbl
            // 
            this.intervalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.intervalLbl.AutoSize = true;
            this.intervalLbl.Location = new System.Drawing.Point(2, 418);
            this.intervalLbl.Name = "intervalLbl";
            this.intervalLbl.Size = new System.Drawing.Size(93, 13);
            this.intervalLbl.TabIndex = 16;
            this.intervalLbl.Text = "Animation (ms): 50";
            // 
            // intervalBar
            // 
            this.intervalBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.intervalBar.Location = new System.Drawing.Point(3, 434);
            this.intervalBar.Maximum = 100;
            this.intervalBar.Minimum = 10;
            this.intervalBar.Name = "intervalBar";
            this.intervalBar.Size = new System.Drawing.Size(92, 45);
            this.intervalBar.TabIndex = 15;
            this.intervalBar.TickFrequency = 10;
            this.intervalBar.Value = 50;
            this.intervalBar.Scroll += new System.EventHandler(this.intervalBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.toolbox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pathfinding Algorithms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            this.heuristicPanel.ResumeLayout(false);
            this.heuristicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSize)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.statsBox.ResumeLayout(false);
            this.statsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolbox;
        private System.Windows.Forms.RadioButton astarRB;
        private System.Windows.Forms.CheckBox costCB;
        private System.Windows.Forms.RadioButton bestfirstRB;
        private System.Windows.Forms.Button themeButton;
        private System.Windows.Forms.RadioButton dfsRB;
        private System.Windows.Forms.RadioButton dijkstraRB;
        private System.Windows.Forms.NumericUpDown cost;
        private System.Windows.Forms.RadioButton bfsRB;
        private System.Windows.Forms.NumericUpDown ySize;
        private System.Windows.Forms.Label yL;
        private System.Windows.Forms.Label xL;
        private System.Windows.Forms.NumericUpDown xSize;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.CheckBox showCB;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label intervalLbl;
        private System.Windows.Forms.TrackBar intervalBar;
        private System.Windows.Forms.GroupBox statsBox;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.CheckBox diagCB;
        private System.Windows.Forms.Button generateB;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button loadB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Label hL;
        private System.Windows.Forms.Panel heuristicPanel;
        private System.Windows.Forms.RadioButton heuristic2;
        private System.Windows.Forms.RadioButton heuristic1;
    }
}

