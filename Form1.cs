using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSNRUProject
{

     
  public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           int[] a= new int[8];
        }


    private void button1_Click(object sender, EventArgs e)
    {
        int[,] arr = new int[10, 3];
        int[,] buffer = new int[10, 3];
        int n = 0, i = 0, buff = 3, j = 0;
        int k = 0;
        foreach (string line in textBox1.Lines)
        {
            string[] stuff = line.Split(' ');
            arr[k, 0] = Int32.Parse(stuff[0]);
            arr[k, 1] = Int32.Parse(stuff[1]);
            arr[k, 2] = Int32.Parse(stuff[2]);
            k++;

        }
        n = textBox1.Lines.Length;
        for (i = 0; i < buff; i++)
        {
            buffer[i, 0] = arr[i, 0];
            buffer[i, 1] = arr[i, 1];
            buffer[i, 2] = arr[i, 2];

        }
        for (i = buff; i < n; i++)
        {
            textBox2.Text += "Current Buffer :";
            for (int l = 0; l < buff; l++)
            
                textBox2.Text += " " + buffer[l, 0];
                textBox2.Text += System.Environment.NewLine;
            
            int newpage = arr[i, 0];
            int stat = 0;
            for (j = 0; j < buff; j++)
            {
                if (newpage == buffer[j, 0])
                {
                    buffer[j, 0] = arr[i, 0];
                    buffer[j, 1] = arr[i, 1];
                    buffer[j, 2] = arr[i, 2];
                    stat = 1;
                }
            }
            if (stat == 0)
            {
                int choice = 0, score = 2 * buffer[0, 1] + buffer[0, 2];
                for (k = 0; k < buff; k++)
                {
                  
                        if (2 * buffer[k, 1] + buffer[k, 2] < score)
                        {
                            score = 2*buffer[k, 1] + buffer[k, 2];
                            choice = k;
                        }
                }
                buffer[choice, 0] = arr[i, 0];
                buffer[choice, 1] = arr[i, 1];
                buffer[choice, 2] = arr[i, 2];
            }
        }
    }    

    }
}
