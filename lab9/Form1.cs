using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        double[] probs, softmax;
        int[] exp_result;
        int n;
        double p;
        double[] dis_func; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            n = (int)NVal.Value;
            probs = new double[5];
            dis_func = new double[6];
            exp_result = new int[5];
            softmax = new double[5];

            probs[0] = (double)prob1.Value;
            probs[1] = (double)prob2.Value;
            probs[2] = (double)prob3.Value;
            probs[3] = (double)prob4.Value;
            probs[4] = 1 - probs[0] - probs[1] - probs[2] - probs[3];
            prob5.Text = probs[4].ToString();

            dis_func[0] = 0;
            for (int i = 1; i < 6; i++)
            {
                dis_func[i] = dis_func[i - 1] + probs[i - 1];
                exp_result[i - 1] = 0;
            }

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                p = rand.NextDouble();
                for (int k = 1; k < 7; k++)
                {
                    if (p < dis_func[k])
                    {
                        exp_result[k - 1] += 1;
                        break;
                    }
                }
            }

            chart1.Series[0].Points.Clear();
            for (int i = 0; i < 5; i++)
            {
                softmax[i] = (double)exp_result[i] / (double)n;
                chart1.Series[0].Points.AddXY(i + 1, softmax[i]);
            }

            double me = 0, mean = 0, variance = 0, got_var = 0, chi = 0;
            for (int i = 0; i < 5; i++)
            {
                me += probs[i] * (i + 1);
                mean += softmax[i] * (i + 1);
            }

            for (int i = 0; i < 5; i++)
            {
                variance += probs[i] * ((i + 1) - me) * ((i + 1) - me);
                got_var += softmax[i] * ((i + 1) - mean) * ((i + 1) - mean);
            }

            for (int i = 0; i < 5; i++)
            {
                double real_freq = (n * probs[i]); 
                chi += (exp_result[i] - real_freq) * (exp_result[i] - real_freq) / real_freq;
            }

            txtAver.Text = Math.Round(mean, 2).ToString();
            txtVar.Text = Math.Round(got_var, 2).ToString(); 
            ChiVal.Text = Math.Round(chi, 2).ToString();

            AvErr.Text = Math.Round(Math.Abs(mean - me) / me * 100, 2).ToString();
            VarErr.Text = Math.Round(Math.Abs(got_var - variance) / variance * 100, 2).ToString();
        }
    }
}
