using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HopfieldNeuralNetwork;

namespace IS2HopfieldNetwork
{
    public partial class Form1 : Form
    {
        NeuralNetwork NN = new NeuralNetwork(100);
        Bitmap[] m = new Bitmap[10];
        private void NN_EnergyChanged(object sender, EnergyEventArgs e)
        {
        }

        public Form1()
        {
            InitializeComponent();

            NN.EnergyChanged += new EnergyChangedHandler(NN_EnergyChanged);
            label1.Text = (NN.M).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m[0] = new Bitmap(openFileDialog1.FileName);
                imageMagnifier1.ImageToMagnify = m[0];
                // display image in picture box
                imageMagnifier1.MagnificationCoefficient = 10;
                // image file path  
                //textBox1.Text = open.FileName;
                //NN.AddPattern(bitmapToPattern(m[0]));
                NN.AddRandomPattern();
                imageMagnifier3.ImageToMagnify = patternToBitmap(NN.Neurons, m[0]);
                imageMagnifier3.MagnificationCoefficient = 10;

                List<Neuron> pattern = generateRandomPattern(100);

                //imageMagnifier2.ImageToMagnify = patternToBitmap(pattern, m[0]);
                //imageMagnifier2.MagnificationCoefficient = 10;
                label1.Text = (NN.M).ToString();
            }
        }

        private List<Neuron> bitmapToPattern(Bitmap b)
        {
            List<Neuron> pattern = new List<Neuron>(100);
            Neuron n = new Neuron();
            Color c;

            for (int i = 0; i < b.Width; i ++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    c = b.GetPixel(i, j);

                    n.State = c.R > 0 ? 1 : -1;

                    pattern.Add(n);
                }
            }

            return pattern;
        }

        private Bitmap patternToBitmap(List<Neuron> p, Image init)
        {
            Bitmap bitmap = new Bitmap(init);
            Color c;

            for (int i = 0; i < init.Width ; i++)
            {
                for (int j = 0; j < init.Height; j++)
                {
                    int val = p[init.Width * i + j].State > 0 ? 255 : 0;
                    Console.WriteLine(val + ": " + p[init.Width * i + j].State);

                    c = Color.FromArgb(val, val, val);

                    bitmap.SetPixel(i, j, c);
                }
            }

            return bitmap;
        }

        private List<Neuron> generateRandomPattern(int size)
        {
            List<Neuron> pattern = new List<Neuron>();
            Random rand  = new Random();

            for (int i = 0; i < size; i++)
            {
                Neuron n = new Neuron();
                n.State = rand.Next(2) > 0 ? 1 : -1; ;
                pattern.Add(n);
            }

            return pattern;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Bitmap b = new Bitmap(imageMagnifier2.ImageToMagnify);
            //NN.Run(bitmapToPattern(b));
            NN.AddRandomPattern();
            imageMagnifier3.ImageToMagnify = patternToBitmap(NN.Neurons, m[0]);
            imageMagnifier3.MagnificationCoefficient = 10;
        }
    }
}
