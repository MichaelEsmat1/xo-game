namespace XO_GAME
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            panel1 = new Panel();
            button1 = new Button();
            lblname2 = new Label();
            lblxogame = new Label();
            panel3 = new Panel();
            rdo2 = new RadioButton();
            rdx2 = new RadioButton();
            lblplayer2 = new Label();
            txtplayer2 = new TextBox();
            panel2 = new Panel();
            rdo = new RadioButton();
            rdx = new RadioButton();
            txtplayer1 = new TextBox();
            lblname1 = new Label();
            lblplayer1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblname2);
            panel1.Controls.Add(lblxogame);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 439);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(210, 284);
            button1.Name = "button1";
            button1.Size = new Size(361, 94);
            button1.TabIndex = 3;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblname2
            // 
            lblname2.AutoSize = true;
            lblname2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname2.ForeColor = Color.WhiteSmoke;
            lblname2.Location = new Point(428, 115);
            lblname2.Name = "lblname2";
            lblname2.Size = new Size(95, 38);
            lblname2.TabIndex = 2;
            lblname2.Text = "Name";
            // 
            // lblxogame
            // 
            lblxogame.AutoSize = true;
            lblxogame.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblxogame.ForeColor = Color.Gold;
            lblxogame.Location = new Point(300, 12);
            lblxogame.Name = "lblxogame";
            lblxogame.Size = new Size(239, 62);
            lblxogame.TabIndex = 2;
            lblxogame.Text = "XO_Game";
            // 
            // panel3
            // 
            panel3.Controls.Add(rdo2);
            panel3.Controls.Add(rdx2);
            panel3.Controls.Add(lblplayer2);
            panel3.Controls.Add(txtplayer2);
            panel3.Location = new Point(425, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(309, 153);
            panel3.TabIndex = 1;
            // 
            // rdo2
            // 
            rdo2.AutoSize = true;
            rdo2.BackColor = Color.WhiteSmoke;
            rdo2.Location = new Point(179, 115);
            rdo2.Name = "rdo2";
            rdo2.Size = new Size(41, 24);
            rdo2.TabIndex = 5;
            rdo2.TabStop = true;
            rdo2.Text = "O";
            rdo2.UseVisualStyleBackColor = false;
            rdo2.CheckedChanged += rdo2_CheckedChanged;
            // 
            // rdx2
            // 
            rdx2.AutoSize = true;
            rdx2.BackColor = Color.WhiteSmoke;
            rdx2.Location = new Point(48, 116);
            rdx2.Name = "rdx2";
            rdx2.Size = new Size(39, 24);
            rdx2.TabIndex = 4;
            rdx2.TabStop = true;
            rdx2.Text = "X";
            rdx2.UseVisualStyleBackColor = false;
            rdx2.CheckedChanged += rdx2_CheckedChanged;
            // 
            // lblplayer2
            // 
            lblplayer2.AutoSize = true;
            lblplayer2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblplayer2.ForeColor = Color.WhiteSmoke;
            lblplayer2.Location = new Point(0, 0);
            lblplayer2.Name = "lblplayer2";
            lblplayer2.Size = new Size(122, 38);
            lblplayer2.TabIndex = 1;
            lblplayer2.Text = "Player 2";
            // 
            // txtplayer2
            // 
            txtplayer2.Location = new Point(0, 82);
            txtplayer2.Name = "txtplayer2";
            txtplayer2.Size = new Size(311, 27);
            txtplayer2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(rdo);
            panel2.Controls.Add(rdx);
            panel2.Controls.Add(txtplayer1);
            panel2.Controls.Add(lblname1);
            panel2.Controls.Add(lblplayer1);
            panel2.Location = new Point(34, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 153);
            panel2.TabIndex = 0;
            // 
            // rdo
            // 
            rdo.AutoSize = true;
            rdo.BackColor = Color.WhiteSmoke;
            rdo.Location = new Point(176, 112);
            rdo.Name = "rdo";
            rdo.Size = new Size(41, 24);
            rdo.TabIndex = 4;
            rdo.TabStop = true;
            rdo.Text = "O";
            rdo.UseVisualStyleBackColor = false;
            rdo.CheckedChanged += rdo_CheckedChanged;
            // 
            // rdx
            // 
            rdx.AutoSize = true;
            rdx.BackColor = Color.WhiteSmoke;
            rdx.Location = new Point(54, 114);
            rdx.Name = "rdx";
            rdx.Size = new Size(39, 24);
            rdx.TabIndex = 3;
            rdx.TabStop = true;
            rdx.Text = "X";
            rdx.UseVisualStyleBackColor = false;
            rdx.CheckedChanged += rdx_CheckedChanged;
            // 
            // txtplayer1
            // 
            txtplayer1.Location = new Point(0, 79);
            txtplayer1.Name = "txtplayer1";
            txtplayer1.Size = new Size(312, 27);
            txtplayer1.TabIndex = 2;
            txtplayer1.Text = "michael";
            // 
            // lblname1
            // 
            lblname1.AutoSize = true;
            lblname1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname1.ForeColor = Color.WhiteSmoke;
            lblname1.Location = new Point(3, 38);
            lblname1.Name = "lblname1";
            lblname1.Size = new Size(95, 38);
            lblname1.TabIndex = 1;
            lblname1.Text = "Name";
            // 
            // lblplayer1
            // 
            lblplayer1.AutoSize = true;
            lblplayer1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblplayer1.ForeColor = Color.WhiteSmoke;
            lblplayer1.Location = new Point(3, 0);
            lblplayer1.Name = "lblplayer1";
            lblplayer1.Size = new Size(122, 38);
            lblplayer1.TabIndex = 0;
            lblplayer1.Text = "Player 1";
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "login_form";
            Text = "login_form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblxogame;
        private Panel panel3;
        private Panel panel2;
        private Label lblname1;
        private Label lblplayer1;
        private TextBox txtplayer2;
        private TextBox txtplayer1;
        private Label lblname2;
        private Label lblplayer2;
        private Button button1;
        private RadioButton rdo2;
        private RadioButton rdx2;
        private RadioButton rdo;
        private RadioButton rdx;
    }
}