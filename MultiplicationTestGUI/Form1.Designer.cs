namespace MultiplicationTestGUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbSamples = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackSpeed = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEquation = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tbAnswer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 244);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.Location = new System.Drawing.Point(4, 210);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(611, 30);
            this.tbAnswer.TabIndex = 3;
            this.tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnswer_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblRecord);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.lblSpeed);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.tbSamples);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackSpeed);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 95);
            this.panel1.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 83);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(611, 12);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 8;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(468, 7);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(49, 17);
            this.lblSpeed.TabIndex = 6;
            this.lblSpeed.Text = "Speed";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(65, 34);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbSamples
            // 
            this.tbSamples.BeepOnError = true;
            this.tbSamples.Location = new System.Drawing.Point(19, 36);
            this.tbSamples.Margin = new System.Windows.Forms.Padding(4);
            this.tbSamples.Mask = "00";
            this.tbSamples.Name = "tbSamples";
            this.tbSamples.PromptChar = ' ';
            this.tbSamples.Size = new System.Drawing.Size(37, 22);
            this.tbSamples.TabIndex = 0;
            this.tbSamples.Text = "5";
            this.tbSamples.TextChanged += new System.EventHandler(this.tbSamples_TextChanged);
            this.tbSamples.Enter += new System.EventHandler(this.tbSamples_Enter);
            this.tbSamples.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSamples_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Samples";
            // 
            // trackSpeed
            // 
            this.trackSpeed.LargeChange = 3;
            this.trackSpeed.Location = new System.Drawing.Point(460, 36);
            this.trackSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.trackSpeed.Maximum = 7;
            this.trackSpeed.Minimum = 1;
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(139, 56);
            this.trackSpeed.TabIndex = 2;
            this.trackSpeed.Value = 4;
            this.trackSpeed.Scroll += new System.EventHandler(this.trackSpeed_Scroll);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblEquation);
            this.panel2.Location = new System.Drawing.Point(4, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 95);
            this.panel2.TabIndex = 4;
            // 
            // lblEquation
            // 
            this.lblEquation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquation.Location = new System.Drawing.Point(0, 0);
            this.lblEquation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(611, 95);
            this.lblEquation.TabIndex = 0;
            this.lblEquation.Text = "lblEquation";
            this.lblEquation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Current Record";
            // 
            // lblRecord
            // 
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(172, 37);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(281, 23);
            this.lblRecord.TabIndex = 10;
            this.lblRecord.Text = "No record";
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 244);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Multiplication Speed Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackSpeed;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox tbSamples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label2;
    }
}

