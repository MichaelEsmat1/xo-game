namespace XO_GAME
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            btnsavescore = new Button();
            btnReset = new Button();
            btnNewGame = new Button();
            panel5 = new Panel();
            label5 = new Label();
            lbl11 = new Label();
            label4 = new Label();
            lblplayerO = new Label();
            lblplayerX = new Label();
            lbl00 = new Label();
            panel3 = new Panel();
            btnTic6 = new Button();
            btnTic3 = new Button();
            btnTic9 = new Button();
            btnTic8 = new Button();
            btnTic7 = new Button();
            btnTic5 = new Button();
            btnTic4 = new Button();
            btnTic2 = new Button();
            btnTic1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 206);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(312, 27);
            label1.Name = "label1";
            label1.Size = new Size(529, 133);
            label1.TabIndex = 0;
            label1.Text = "XO_GAME";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(1344, 653);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(733, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(608, 650);
            panel4.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(btnsavescore);
            panel6.Controls.Add(btnReset);
            panel6.Controls.Add(btnNewGame);
            panel6.Location = new Point(3, 267);
            panel6.Name = "panel6";
            panel6.Size = new Size(598, 288);
            panel6.TabIndex = 1;
            // 
            // btnsavescore
            // 
            btnsavescore.BackColor = Color.Red;
            btnsavescore.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsavescore.ForeColor = Color.Black;
            btnsavescore.Location = new Point(320, 143);
            btnsavescore.Name = "btnsavescore";
            btnsavescore.Size = new Size(271, 138);
            btnsavescore.TabIndex = 0;
            btnsavescore.Text = "SaveScore";
            btnsavescore.UseVisualStyleBackColor = false;
            btnsavescore.Click += btnsavescore_Click_1;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(0, 192, 0);
            btnReset.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(-2, 143);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(316, 138);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.BackColor = Color.Gold;
            btnNewGame.Font = new Font("Segoe UI", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewGame.ForeColor = Color.Black;
            btnNewGame.Location = new Point(3, 3);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(588, 134);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = false;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(lbl11);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(lblplayerO);
            panel5.Controls.Add(lblplayerX);
            panel5.Controls.Add(lbl00);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(598, 220);
            panel5.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(852, 469);
            label5.Name = "label5";
            label5.Size = new Size(308, 91);
            label5.TabIndex = 1;
            label5.Text = "player x:";
            // 
            // lbl11
            // 
            lbl11.AutoSize = true;
            lbl11.BackColor = Color.Black;
            lbl11.BorderStyle = BorderStyle.Fixed3D;
            lbl11.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl11.ForeColor = Color.Gold;
            lbl11.Location = new Point(-2, 111);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(307, 91);
            lbl11.TabIndex = 0;
            lbl11.Text = "player y:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(296, 11);
            label4.Name = "label4";
            label4.Size = new Size(0, 89);
            label4.TabIndex = 0;
            // 
            // lblplayerO
            // 
            lblplayerO.AutoSize = true;
            lblplayerO.BackColor = Color.Gold;
            lblplayerO.BorderStyle = BorderStyle.Fixed3D;
            lblplayerO.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblplayerO.ForeColor = Color.Black;
            lblplayerO.Location = new Point(330, 111);
            lblplayerO.Name = "lblplayerO";
            lblplayerO.Size = new Size(79, 91);
            lblplayerO.TabIndex = 0;
            lblplayerO.Text = "0";
            lblplayerO.Click += label2_Click;
            // 
            // lblplayerX
            // 
            lblplayerX.AutoSize = true;
            lblplayerX.BackColor = Color.Gold;
            lblplayerX.BorderStyle = BorderStyle.Fixed3D;
            lblplayerX.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblplayerX.ForeColor = Color.Black;
            lblplayerX.Location = new Point(330, 0);
            lblplayerX.Name = "lblplayerX";
            lblplayerX.Size = new Size(79, 91);
            lblplayerX.TabIndex = 0;
            lblplayerX.Text = "0";
            lblplayerX.Click += label2_Click;
            // 
            // lbl00
            // 
            lbl00.AutoSize = true;
            lbl00.BorderStyle = BorderStyle.Fixed3D;
            lbl00.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl00.ForeColor = Color.Gold;
            lbl00.Location = new Point(3, 0);
            lbl00.Name = "lbl00";
            lbl00.Size = new Size(308, 91);
            lbl00.TabIndex = 0;
            lbl00.Text = "player x:";
            lbl00.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnTic6);
            panel3.Controls.Add(btnTic3);
            panel3.Controls.Add(btnTic9);
            panel3.Controls.Add(btnTic8);
            panel3.Controls.Add(btnTic7);
            panel3.Controls.Add(btnTic5);
            panel3.Controls.Add(btnTic4);
            panel3.Controls.Add(btnTic2);
            panel3.Controls.Add(btnTic1);
            panel3.Location = new Point(12, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(701, 647);
            panel3.TabIndex = 0;
            // 
            // btnTic6
            // 
            btnTic6.BackColor = Color.WhiteSmoke;
            btnTic6.Font = new Font("Segoe UI", 72F);
            btnTic6.ForeColor = Color.Black;
            btnTic6.Location = new Point(466, 164);
            btnTic6.Name = "btnTic6";
            btnTic6.Size = new Size(228, 155);
            btnTic6.TabIndex = 0;
            btnTic6.UseVisualStyleBackColor = false;
            btnTic6.Click += btnTic6_Click;
            // 
            // btnTic3
            // 
            btnTic3.BackColor = Color.WhiteSmoke;
            btnTic3.Font = new Font("Segoe UI", 72F);
            btnTic3.ForeColor = Color.Black;
            btnTic3.Location = new Point(466, 3);
            btnTic3.Name = "btnTic3";
            btnTic3.Size = new Size(228, 155);
            btnTic3.TabIndex = 0;
            btnTic3.UseVisualStyleBackColor = false;
            btnTic3.Click += btnTic3_Click;
            // 
            // btnTic9
            // 
            btnTic9.BackColor = Color.WhiteSmoke;
            btnTic9.Font = new Font("Segoe UI", 72F);
            btnTic9.ForeColor = Color.Black;
            btnTic9.Location = new Point(466, 325);
            btnTic9.Name = "btnTic9";
            btnTic9.Size = new Size(228, 155);
            btnTic9.TabIndex = 0;
            btnTic9.UseVisualStyleBackColor = false;
            btnTic9.Click += btnTic9_Click;
            // 
            // btnTic8
            // 
            btnTic8.BackColor = Color.WhiteSmoke;
            btnTic8.Font = new Font("Segoe UI", 72F);
            btnTic8.ForeColor = Color.Black;
            btnTic8.Location = new Point(237, 325);
            btnTic8.Name = "btnTic8";
            btnTic8.Size = new Size(228, 155);
            btnTic8.TabIndex = 0;
            btnTic8.UseVisualStyleBackColor = false;
            btnTic8.Click += btnTic8_Click;
            // 
            // btnTic7
            // 
            btnTic7.BackColor = Color.WhiteSmoke;
            btnTic7.Font = new Font("Segoe UI", 72F);
            btnTic7.ForeColor = Color.Black;
            btnTic7.Location = new Point(3, 325);
            btnTic7.Name = "btnTic7";
            btnTic7.Size = new Size(228, 155);
            btnTic7.TabIndex = 0;
            btnTic7.UseVisualStyleBackColor = false;
            btnTic7.Click += btnTic7_Click;
            // 
            // btnTic5
            // 
            btnTic5.BackColor = Color.WhiteSmoke;
            btnTic5.Font = new Font("Segoe UI", 72F);
            btnTic5.ForeColor = Color.Black;
            btnTic5.Location = new Point(237, 164);
            btnTic5.Name = "btnTic5";
            btnTic5.Size = new Size(228, 155);
            btnTic5.TabIndex = 0;
            btnTic5.UseVisualStyleBackColor = false;
            btnTic5.Click += btnTic5_Click;
            // 
            // btnTic4
            // 
            btnTic4.BackColor = Color.WhiteSmoke;
            btnTic4.Font = new Font("Segoe UI", 72F);
            btnTic4.ForeColor = Color.Black;
            btnTic4.Location = new Point(3, 164);
            btnTic4.Name = "btnTic4";
            btnTic4.Size = new Size(228, 155);
            btnTic4.TabIndex = 0;
            btnTic4.UseVisualStyleBackColor = false;
            btnTic4.Click += btnTic4_Click;
            // 
            // btnTic2
            // 
            btnTic2.BackColor = Color.WhiteSmoke;
            btnTic2.Font = new Font("Segoe UI", 72F);
            btnTic2.ForeColor = Color.Black;
            btnTic2.Location = new Point(237, 3);
            btnTic2.Name = "btnTic2";
            btnTic2.Size = new Size(228, 155);
            btnTic2.TabIndex = 0;
            btnTic2.UseVisualStyleBackColor = false;
            btnTic2.Click += btnTic2_Click;
            // 
            // btnTic1
            // 
            btnTic1.BackColor = Color.WhiteSmoke;
            btnTic1.Font = new Font("Segoe UI", 72F);
            btnTic1.ForeColor = Color.Black;
            btnTic1.Location = new Point(3, 3);
            btnTic1.Name = "btnTic1";
            btnTic1.Size = new Size(228, 155);
            btnTic1.TabIndex = 0;
            btnTic1.UseVisualStyleBackColor = false;
            btnTic1.Click += btnTic1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1368, 889);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Panel panel6;
        private Button btnTic1;
        private Button btnsavescore;
        private Button btnTic6;
        private Button btnTic3;
        private Button btnTic8;
        private Button btnTic7;
        private Button btnTic5;
        private Button btnTic4;
        private Button btnTic2;
        private Button btnReset;
        private Button btnNewGame;
        private Panel panel5;
        private Label lbl11;
        private Label label4;
        private Label lbl00;
        private Button btnTic9;
        private Label label5;
        public Label lblplayerX;
        public Label lblplayerO;
    }
}
