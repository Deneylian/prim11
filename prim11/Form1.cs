using System.Drawing.Text;

namespace prim11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void res_Click(object sender, EventArgs e)
        {
            int[] rand = { 8, 8, 8, 8, 8, 8, 8 };
            bool cl_gen = true;
            int cnt = 0, n, j = 0;
            Random cl_random = new Random();
            while (cl_gen == true)
            {
                n = cl_random.Next(0, 7);

                for (int i = 0; i < 7; i++)
                {
                    if (rand[i] != n)
                    {
                        cnt++;
                    }
                }

                if (cnt == 7)
                {
                    rand[j] = n;
                    j++;

                }
                cnt = 0;
                if (j == 7)
                {
                    cl_gen = false;
                }





            }
            string b_name;
            for (int i = 0; i < 7; i++)
            {
                b_name = "b" + i.ToString();
                switch (rand[i])
                {
                    case 0:
                        ((Button)Controls[b_name]).BackColor = Color.Red;
                        ((Button)Controls[b_name]).ForeColor = Color.Red;
                        ((Button)Controls[b_name]).Text = "0";

                        break;
                    case 1:
                        ((Button)Controls[b_name]).BackColor = Color.Orange;
                        ((Button)Controls[b_name]).ForeColor = Color.Orange;
                        ((Button)Controls[b_name]).Text = "1";
                        break;
                    case 2:
                        ((Button)Controls[b_name]).BackColor = Color.Yellow;
                        ((Button)Controls[b_name]).ForeColor = Color.Yellow;
                        ((Button)Controls[b_name]).Text = "2";
                        break;
                    case 3:
                        ((Button)Controls[b_name]).BackColor = Color.Green;
                        ((Button)Controls[b_name]).ForeColor = Color.Green;
                        ((Button)Controls[b_name]).Text = "3";
                        break;
                    case 4:
                        ((Button)Controls[b_name]).BackColor = Color.Blue;
                        ((Button)Controls[b_name]).ForeColor = Color.Blue;
                        ((Button)Controls[b_name]).Text = "4";
                        break;
                    case 5:
                        ((Button)Controls[b_name]).BackColor = Color.DarkBlue;
                        ((Button)Controls[b_name]).ForeColor = Color.DarkBlue;
                        ((Button)Controls[b_name]).Text = "5";
                        break;
                    case 6:
                        ((Button)Controls[b_name]).BackColor = Color.Purple;
                        ((Button)Controls[b_name]).ForeColor = Color.Purple;
                        ((Button)Controls[b_name]).Text = "6";
                        break;
                }
            }
        }

        private void Game(object sender, EventArgs e)
        {
            string n = (sender as Button).Text;
            string t_but_name;
            int m = Convert.ToInt32(n);
            bool inf = true;
            int test = 0;
            for (int i = 0; i < 7; i++)
            {
                t_but_name = "t" + i;
                if (m == i)
                {
                    ((Button)Controls[t_but_name]).BackColor = (sender as Button).BackColor;
                }
                else
                {
                    label1.Text = "Вы проиграли, начните игру заново!";
                    while(inf == true)
                    {
                        if ((sender as Button).Name == "res")
                        {
                            inf = true;
                        }
                        else
                        {
                            inf = false;
                        }
                    }

                }
            }

        }
    }
}
