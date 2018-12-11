using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationTestGUI
{
    public partial class Form1 : Form
    {
        private int countdown;
        private readonly ProblemGenerator problemGenerator = new ProblemGenerator();
        private Problem currentProblem;
        private Statistics statistics;

        public int Samples
        {
            get
            {
                int result = 0;
                int.TryParse(tbSamples.Text, out result);
                return result;
            }

            set
            {
                if (value >= 0 && value < 100)
                {
                    tbSamples.Text = "" + value;
                    btnStart.Enabled = value > 0;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Samples > 0 || countdown >= 0)
            {
                if (countdown > 0)
                {
                    countdown--;
                    lblCountdown.Text = "" + countdown;
                }
                else if (countdown == 0)
                {
                    countdown--;
                    CheckSample(true);
                }
                else
                {
                    InitSample();
                }
            }
            else
            {
                Stop();
            }
        }

        private void CheckSample(bool timeout)
        {
            if (currentProblem != null)
            {
                lblEquation.Text = lblEquation.Text + currentProblem.CorrectAnswer;
                if (currentProblem.CorrectAnswer.Equals(tbAnswer.Text))
                {
                    statistics.Correct++;
                    lblEquation.ForeColor = Color.ForestGreen;
                }
                else
                {
                    if(timeout)
                    {
                        statistics.Timeout++;
                    }
                    else
                    {
                        statistics.Error++;
                    }
                    lblEquation.ForeColor = Color.Red;
                }
                currentProblem = null;
            }
        }

        private void InitSample()
        {
            if (Samples > 0)
            {
                countdown = trackSpeed.Maximum + 1 - trackSpeed.Value;
                lblCountdown.Text = "" + countdown;
                currentProblem = problemGenerator.Next();
                lblEquation.Text = currentProblem.Equation;
                lblEquation.ForeColor = Color.Black;
                Samples = Samples - 1;
                tbAnswer.Text = "";
                tbAnswer.Focus();
            }
        }

        private void Stop()
        {
            timer.Enabled = false;
            btnStart.Text = "Start";
            lblCountdown.Text = "";
            lblEquation.Text = "";
            tbAnswer.Text = "";
            tbAnswer.Enabled = false;
            tbSamples.Enabled = true;
            trackSpeed.Enabled = true;
            if (statistics != null)
            {
                MessageBox.Show(statistics.ToString(), "Results");
            }
            tbSamples.Focus();
        }

        private void Start()
        {
            statistics = new Statistics();
            statistics.Speed = trackSpeed.Value;
            trackSpeed.Enabled = false;
            tbAnswer.Enabled = true;
            tbSamples.Enabled = false;
            timer.Enabled = true;
            btnStart.Text = "Stop";
            InitSample();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                Stop();
            }
            else
            {
                Start();
            }
        }

        private void tbSamples_Enter(object sender, EventArgs e)
        {
            tbSamples.SelectAll();
        }

        private void tbSamples_TextChanged(object sender, EventArgs e)
        {
            Samples = Samples;
        }

        private void tbAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (timer.Enabled)
                {
                    CheckSample(false);
                    countdown = 0;
                }
            }
            else if (e.KeyChar == 27)
            {
                e.Handled = true;
                if (timer.Enabled)
                {
                    Stop();
                }
            }
        }

        private void tbSamples_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (!timer.Enabled && Samples > 0)
                {
                    Start();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stop();
        }
    }
}
