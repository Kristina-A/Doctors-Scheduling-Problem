namespace DZ1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSelection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCrossover = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numProbability = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTermination = new System.Windows.Forms.ComboBox();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFitness = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxMutation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(593, 356);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(559, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(129, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Veličina populacije:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max";
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(486, 75);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(120, 22);
            this.numMin.TabIndex = 4;
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(670, 75);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(120, 22);
            this.numMax.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selekcija:";
            // 
            // cbxSelection
            // 
            this.cbxSelection.FormattingEnabled = true;
            this.cbxSelection.Items.AddRange(new object[] {
            "Rulet",
            "Elitizam"});
            this.cbxSelection.Location = new System.Drawing.Point(485, 152);
            this.cbxSelection.Name = "cbxSelection";
            this.cbxSelection.Size = new System.Drawing.Size(121, 24);
            this.cbxSelection.TabIndex = 7;
            this.cbxSelection.Text = "Rulet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Crossover:";
            // 
            // cbxCrossover
            // 
            this.cbxCrossover.FormattingEnabled = true;
            this.cbxCrossover.Items.AddRange(new object[] {
            "One-point",
            "Two-point",
            "Uniform"});
            this.cbxCrossover.Location = new System.Drawing.Point(669, 152);
            this.cbxCrossover.Name = "cbxCrossover";
            this.cbxCrossover.Size = new System.Drawing.Size(121, 24);
            this.cbxCrossover.TabIndex = 9;
            this.cbxCrossover.Text = "One-point";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Verovatnoća mutacije:";
            // 
            // numProbability
            // 
            this.numProbability.DecimalPlaces = 2;
            this.numProbability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numProbability.Location = new System.Drawing.Point(669, 218);
            this.numProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProbability.Name = "numProbability";
            this.numProbability.Size = new System.Drawing.Size(120, 22);
            this.numProbability.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Terminacija:";
            // 
            // cbxTermination
            // 
            this.cbxTermination.FormattingEnabled = true;
            this.cbxTermination.Items.AddRange(new object[] {
            "Fitness stagnation",
            "Generation number"});
            this.cbxTermination.Location = new System.Drawing.Point(668, 295);
            this.cbxTermination.Name = "cbxTermination";
            this.cbxTermination.Size = new System.Drawing.Size(121, 24);
            this.cbxTermination.TabIndex = 14;
            this.cbxTermination.Text = "Fitness stagnation";
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3});
            this.dataView.Location = new System.Drawing.Point(12, 12);
            this.dataView.Name = "dataView";
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(403, 280);
            this.dataView.TabIndex = 15;
            // 
            // c1
            // 
            this.c1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c1.HeaderText = "Smena 1";
            this.c1.Name = "c1";
            // 
            // c2
            // 
            this.c2.HeaderText = "Smena 2";
            this.c2.Name = "c2";
            this.c2.Width = 90;
            // 
            // c3
            // 
            this.c3.HeaderText = "Smena 3";
            this.c3.Name = "c3";
            this.c3.Width = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fitness najboljeg rešenja: ";
            // 
            // lblFitness
            // 
            this.lblFitness.AutoSize = true;
            this.lblFitness.Location = new System.Drawing.Point(178, 356);
            this.lblFitness.Name = "lblFitness";
            this.lblFitness.Size = new System.Drawing.Size(46, 17);
            this.lblFitness.TabIndex = 17;
            this.lblFitness.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mutacija:";
            // 
            // cbxMutation
            // 
            this.cbxMutation.FormattingEnabled = true;
            this.cbxMutation.Items.AddRange(new object[] {
            "Twors",
            "Insertion",
            "Partial Shuffle",
            "Reverse Sequence"});
            this.cbxMutation.Location = new System.Drawing.Point(486, 295);
            this.cbxMutation.Name = "cbxMutation";
            this.cbxMutation.Size = new System.Drawing.Size(121, 24);
            this.cbxMutation.TabIndex = 19;
            this.cbxMutation.Text = "Twors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 436);
            this.Controls.Add(this.cbxMutation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblFitness);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.cbxTermination);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numProbability);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxCrossover);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxSelection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMax);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSelection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCrossover;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numProbability;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTermination;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFitness;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxMutation;
    }
}

