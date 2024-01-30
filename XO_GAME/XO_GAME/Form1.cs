namespace XO_GAME
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;
        public string txtplayer1;
        public string txtplayer2;
        public bool playerx;
        public bool playero;
        public int playerxx;
        public int playeroo;


        public Form1(string player1, string player2, bool _playerx, bool _playero)
        {
            InitializeComponent();

            this.txtplayer1 = player1;
            this.txtplayer2 = player2;
            lbl00.Text = $" {(_playerx ? player1 : player2)}";
            lbl11.Text = $" {(_playero ? player2 : player1)}";

            this.playerx = _playerx;
            this.playero = _playero;
           


        }

        void Enable_False()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;

        }
        void score()
        {
            if (btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.PowderBlue;
                btnTic2.BackColor = System.Drawing.Color.PowderBlue;
                btnTic3.BackColor = System.Drawing.Color.PowderBlue;
                MessageBox.Show("The winner is player X", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                lblplayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic1.Text == "X" && btnTic4.Text == "X" && btnTic7.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.Pink;
                btnTic4.BackColor = System.Drawing.Color.Pink;
                btnTic7.BackColor = System.Drawing.Color.Pink;
                MessageBox.Show("The winner is player X", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                lblplayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic1.Text == "X" && btnTic5.Text == "X" && btnTic9.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.Crimson;
                btnTic5.BackColor = System.Drawing.Color.Crimson;
                btnTic9.BackColor = System.Drawing.Color.Crimson;
                MessageBox.Show("The winner is player X", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                lblplayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic3.Text == "X" && btnTic5.Text == "X" && btnTic7.Text == "X")
            {
                btnTic3.BackColor = System.Drawing.Color.CadetBlue;
                btnTic5.BackColor = System.Drawing.Color.CadetBlue;
                btnTic7.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("The winner is player X", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                lblplayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic2.Text == "X" && btnTic5.Text == "X" && btnTic8.Text == "X")
            {
                btnTic2.BackColor = System.Drawing.Color.SlateBlue;
                btnTic5.BackColor = System.Drawing.Color.SlateBlue;
                btnTic8.BackColor = System.Drawing.Color.SlateBlue;
                MessageBox.Show("The winner is player X", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                lblplayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic3.Text == "X" && btnTic6.Text == "X" && btnTic9.Text == "X")
            {
                btnTic3.BackColor = System.Drawing.Color.Violet;
                btnTic6.BackColor = System.Drawing.Color.Violet;
                btnTic9.BackColor = System.Drawing.Color.Violet;
                MessageBox.Show("The winner is player X", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                lblplayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = System.Drawing.Color.DarkSlateBlue;
                btnTic5.BackColor = System.Drawing.Color.DarkSlateBlue;
                btnTic6.BackColor = System.Drawing.Color.DarkSlateBlue;
                MessageBox.Show("The winner is player X", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                lblplayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X")
            {
                btnTic7.BackColor = System.Drawing.Color.Azure;
                btnTic8.BackColor = System.Drawing.Color.Azure;
                btnTic9.BackColor = System.Drawing.Color.Azure;
                MessageBox.Show("The winner is player X", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                lblplayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            //============================================================
            if (btnTic1.Text == "O" && btnTic2.Text == "O" && btnTic3.Text == "O")
            {
                btnTic1.BackColor = System.Drawing.Color.AliceBlue;
                btnTic2.BackColor = System.Drawing.Color.AliceBlue;
                btnTic3.BackColor = System.Drawing.Color.AliceBlue;
                MessageBox.Show("The winner is player O", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                lblplayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic1.Text == "O" && btnTic4.Text == "O" && btnTic7.Text == "O")
            {
                btnTic1.BackColor = System.Drawing.Color.Yellow;
                btnTic4.BackColor = System.Drawing.Color.Yellow;
                btnTic7.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("The winner is player O", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                lblplayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic1.Text == "O" && btnTic5.Text == "O" && btnTic9.Text == "O")
            {
                btnTic1.BackColor = System.Drawing.Color.BlueViolet;
                btnTic5.BackColor = System.Drawing.Color.BlueViolet;
                btnTic9.BackColor = System.Drawing.Color.BlueViolet;
                MessageBox.Show("The winner is player O", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                lblplayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic3.Text == "O" && btnTic5.Text == "O" && btnTic7.Text == "O")
            {
                btnTic3.BackColor = System.Drawing.Color.NavajoWhite;
                btnTic5.BackColor = System.Drawing.Color.NavajoWhite;
                btnTic7.BackColor = System.Drawing.Color.NavajoWhite;
                MessageBox.Show("The winner is player O", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                lblplayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic2.Text == "O" && btnTic5.Text == "O" && btnTic8.Text == "O")
            {
                btnTic2.BackColor = System.Drawing.Color.SandyBrown;
                btnTic5.BackColor = System.Drawing.Color.SandyBrown;
                btnTic8.BackColor = System.Drawing.Color.SandyBrown;
                MessageBox.Show("The winner is player O", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                lblplayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic3.Text == "O" && btnTic6.Text == "O" && btnTic9.Text == "O")
            {
                btnTic3.BackColor = System.Drawing.Color.SeaGreen;
                btnTic6.BackColor = System.Drawing.Color.SeaGreen;
                btnTic9.BackColor = System.Drawing.Color.SeaGreen;
                MessageBox.Show("The winner is player O", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                lblplayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic4.Text == "O" && btnTic5.Text == "O" && btnTic6.Text == "O")
            {
                btnTic4.BackColor = System.Drawing.Color.Azure;
                btnTic5.BackColor = System.Drawing.Color.Azure;
                btnTic6.BackColor = System.Drawing.Color.Azure;
                MessageBox.Show("The winner is player O", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                lblplayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btnTic7.Text == "O" && btnTic8.Text == "O" && btnTic9.Text == "O")
            {
                btnTic7.BackColor = System.Drawing.Color.DarkBlue;
                btnTic8.BackColor = System.Drawing.Color.DarkBlue;
                btnTic9.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("The winner is player O", "XO_Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                lblplayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTic1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic1.Text = "X";
                checker = true;
            }
            else
            {
                btnTic1.Text = "O";
                checker = false;
            }
            score();
            btnTic1.Enabled = false;
        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic2.Text = "X";
                checker = true;
            }
            else
            {
                btnTic2.Text = "O";
                checker = false;
            }
            score();
            btnTic2.Enabled = false;
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic3.Text = "X";
                checker = true;
            }
            else
            {
                btnTic3.Text = "O";
                checker = false;
            }
            score();
            btnTic3.Enabled = false;
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic4.Text = "X";
                checker = true;
            }
            else
            {
                btnTic4.Text = "O";
                checker = false;
            }
            score();
            btnTic4.Enabled = false;
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic5.Text = "X";
                checker = true;
            }
            else
            {
                btnTic5.Text = "O";
                checker = false;
            }
            score();
            btnTic5.Enabled = false;
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic6.Text = "X";
                checker = true;
            }
            else
            {
                btnTic6.Text = "O";
                checker = false;
            }
            score();
            btnTic6.Enabled = false;

        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic7.Text = "X";
                checker = true;
            }
            else
            {
                btnTic7.Text = "O";
                checker = false;
            }
            score();
            btnTic7.Enabled = false;
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic8.Text = "X";
                checker = true;
            }
            else
            {
                btnTic8.Text = "O";
                checker = false;
            }
            score();
            btnTic8.Enabled = false;

        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic9.Text = "X";
                checker = true;
            }
            else
            {
                btnTic9.Text = "O";
                checker = false;
            }
            score();
            btnTic9.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;
                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";
                lblplayerX.Text = "0";
                lblplayerO.Text = "0";
                btnTic1.BackColor = Color.WhiteSmoke;
                btnTic2.BackColor = Color.WhiteSmoke;
                btnTic3.BackColor = Color.WhiteSmoke;
                btnTic4.BackColor = Color.WhiteSmoke;
                btnTic5.BackColor = Color.WhiteSmoke;
                btnTic6.BackColor = Color.WhiteSmoke;
                btnTic7.BackColor = Color.WhiteSmoke;
                btnTic8.BackColor = Color.WhiteSmoke;
                btnTic9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;
                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";
                btnNewGame.Enabled = true;
                btnTic1.BackColor = Color.WhiteSmoke;
                btnTic2.BackColor = Color.WhiteSmoke;
                btnTic3.BackColor = Color.WhiteSmoke;
                btnTic4.BackColor = Color.WhiteSmoke;
                btnTic5.BackColor = Color.WhiteSmoke;
                btnTic6.BackColor = Color.WhiteSmoke;
                btnTic7.BackColor = Color.WhiteSmoke;
                btnTic8.BackColor = Color.WhiteSmoke;
                btnTic9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }





        private void btnexit_Click(object sender, EventArgs e)


        {
            this.Close();
            //    try
            //    {
            //        DialogResult iExit;
            //        iExit = MessageBox.Show("confirm if you want to exit ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        if (iExit == DialogResult.Yes)
            //        {
            //            Application.Exit();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
        }

        private void btnsavescore_Click(object sender, EventArgs e)
        {
           


        }

        private void btnsavescore_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            save_score save_Score = new save_score(lbl00.Text, lbl11.Text,lblplayerX.Text , lblplayerO.Text); 
            save_Score.ShowDialog();

        }
    }
}

