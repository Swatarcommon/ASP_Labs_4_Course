using laba4;
using System;
using System.Windows.Forms;

namespace ProxyForm
{
    public partial class Form1 : Form
    {
        Simple client;

        public Form1()
        {
            this.client = new Simple();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int k;
                float f;
                A A1 = new A();
                bool isNum = int.TryParse(ak1.Text, out k);
                if (!isNum)
                    throw new Exception("k is int");
                else
                    A1.k = k;
                bool isFloat = float.TryParse(af1.Text, out f);
                if (!isFloat)
                    throw new Exception("f is float");
                else
                    A1.f = f;
                A1.s = as1.Text;

                A A2 = new A();
                isNum = int.TryParse(ak2.Text, out k);
                if (!isNum)
                    throw new Exception("k is int");
                else
                    A2.k = k;
                isFloat = float.TryParse(af2.Text, out f);
                if (!isFloat)
                    throw new Exception("f is float");
                else
                    A2.f = f;
                A2.s = as2.Text;

                A result = client.Sum(A1, A2);
                rs.Text = result.s;
                rk.Text = result.k.ToString();
                rf.Text = result.f.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
