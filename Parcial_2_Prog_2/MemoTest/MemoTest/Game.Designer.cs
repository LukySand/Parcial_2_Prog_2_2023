namespace MemoTest
{
    partial class Game
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
            GridEasyLeft = new TableLayoutPanel();
            panelEasyLeft = new Panel();
            panelEndGame = new Panel();
            button1 = new Button();
            label1 = new Label();
            panelEasyLeft.SuspendLayout();
            panelEndGame.SuspendLayout();
            SuspendLayout();
            // 
            // GridEasyLeft
            // 
            GridEasyLeft.BackColor = Color.Black;
            GridEasyLeft.ColumnCount = 4;
            GridEasyLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            GridEasyLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            GridEasyLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            GridEasyLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            GridEasyLeft.Location = new Point(3, 0);
            GridEasyLeft.Name = "GridEasyLeft";
            GridEasyLeft.RowCount = 3;
            GridEasyLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GridEasyLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GridEasyLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GridEasyLeft.Size = new Size(1326, 646);
            GridEasyLeft.TabIndex = 0;
            // 
            // panelEasyLeft
            // 
            panelEasyLeft.Controls.Add(GridEasyLeft);
            panelEasyLeft.Location = new Point(3, 3);
            panelEasyLeft.Name = "panelEasyLeft";
            panelEasyLeft.Size = new Size(1332, 649);
            panelEasyLeft.TabIndex = 1;
            // 
            // panelEndGame
            // 
            panelEndGame.Controls.Add(button1);
            panelEndGame.Controls.Add(label1);
            panelEndGame.Location = new Point(3, 3);
            panelEndGame.Name = "panelEndGame";
            panelEndGame.Size = new Size(1329, 646);
            panelEndGame.TabIndex = 1;
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
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 654);
            Controls.Add(panelEndGame);
            Controls.Add(panelEasyLeft);
            Name = "Game";
            Text = "Game";
            Load += Game_Load;
            panelEasyLeft.ResumeLayout(false);
            panelEndGame.ResumeLayout(false);
            panelEndGame.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel GridEasyLeft;
        private Panel panelEasyLeft;
        private Panel panelEndGame;
        private Label label1;
        private Button button1;
    }
}