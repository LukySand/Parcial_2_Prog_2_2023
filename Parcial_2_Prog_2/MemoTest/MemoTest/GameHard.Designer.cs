namespace MemoTest
{
    partial class GameHard
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
            panelHardRight = new Panel();
            GridHardRight = new TableLayoutPanel();
            panelEndGame = new Panel();
            button1 = new Button();
            label1 = new Label();
            panelHardRight.SuspendLayout();
            panelEndGame.SuspendLayout();
            SuspendLayout();
            // 
            // panelHardRight
            // 
            panelHardRight.Controls.Add(GridHardRight);
            panelHardRight.Location = new Point(0, -3);
            panelHardRight.Name = "panelHardRight";
            panelHardRight.Size = new Size(1312, 606);
            panelHardRight.TabIndex = 8;
            // 
            // GridHardRight
            // 
            GridHardRight.BackColor = Color.Black;
            GridHardRight.ColumnCount = 6;
            GridHardRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            GridHardRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            GridHardRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            GridHardRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            GridHardRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            GridHardRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            GridHardRight.Location = new Point(3, 3);
            GridHardRight.Name = "GridHardRight";
            GridHardRight.RowCount = 4;
            GridHardRight.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            GridHardRight.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            GridHardRight.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            GridHardRight.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            GridHardRight.Size = new Size(1309, 603);
            GridHardRight.TabIndex = 5;
            // 
            // panelEndGame
            // 
            panelEndGame.Controls.Add(button1);
            panelEndGame.Controls.Add(label1);
            panelEndGame.Location = new Point(3, -1);
            panelEndGame.Name = "panelEndGame";
            panelEndGame.Size = new Size(1309, 602);
            panelEndGame.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Snap ITC", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.Brown;
            button1.Location = new Point(492, 445);
            button1.Name = "button1";
            button1.Size = new Size(289, 109);
            button1.TabIndex = 1;
            button1.Text = "Ecsit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(192, 288);
            label1.Name = "label1";
            label1.Size = new Size(980, 76);
            label1.TabIndex = 0;
            label1.Text = "Ganaste.....Pero a que costo";
            // 
            // GameHard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 600);
            Controls.Add(panelEndGame);
            Controls.Add(panelHardRight);
            Name = "GameHard";
            Text = "GameHard";
            Load += GameHard_Load;
            panelHardRight.ResumeLayout(false);
            panelEndGame.ResumeLayout(false);
            panelEndGame.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHardRight;
        private TableLayoutPanel GridHardRight;
        private Panel panelEndGame;
        private Button button1;
        private Label label1;
    }
}