namespace XO_GAME
{
    partial class save_score
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
            dgv_saveScores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_saveScores).BeginInit();
            SuspendLayout();
            // 
            // dgv_saveScores
            // 
            dgv_saveScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_saveScores.Location = new Point(-2, 91);
            dgv_saveScores.Name = "dgv_saveScores";
            dgv_saveScores.RowHeadersWidth = 51;
            dgv_saveScores.Size = new Size(803, 380);
            dgv_saveScores.TabIndex = 0;
            // 
            // save_score
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 464);
            Controls.Add(dgv_saveScores);
            Name = "save_score";
            Text = "save_score";
            Load += save_score_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_saveScores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_saveScores;
    }
}