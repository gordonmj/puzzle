namespace Puzzle
{
    partial class GameArea
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
            this.playBoard = new System.Windows.Forms.Panel();
            this.goalBoard = new System.Windows.Forms.Panel();
            this.newGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.refreshInitial = new System.Windows.Forms.Button();
            this.refreshGoal = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.highlight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playBoard
            // 
            this.playBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playBoard.BackColor = System.Drawing.SystemColors.Control;
            this.playBoard.Location = new System.Drawing.Point(30, 39);
            this.playBoard.Name = "playBoard";
            this.playBoard.Size = new System.Drawing.Size(512, 512);
            this.playBoard.TabIndex = 0;
            this.playBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.playBoard_Paint);
            this.playBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playBoard_MouseClick);
            this.playBoard.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playBoard_MouseDoubleClick);
            // 
            // goalBoard
            // 
            this.goalBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goalBoard.BackColor = System.Drawing.SystemColors.Control;
            this.goalBoard.Location = new System.Drawing.Point(575, 39);
            this.goalBoard.Name = "goalBoard";
            this.goalBoard.Size = new System.Drawing.Size(512, 512);
            this.goalBoard.TabIndex = 1;
            this.goalBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // newGame
            // 
            this.newGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newGame.BackColor = System.Drawing.SystemColors.Control;
            this.newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.newGame.Location = new System.Drawing.Point(1109, 23);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(131, 42);
            this.newGame.TabIndex = 2;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.BackColor = System.Drawing.SystemColors.Control;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Location = new System.Drawing.Point(1258, 23);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(131, 42);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Undo
            // 
            this.Undo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Undo.BackColor = System.Drawing.SystemColors.Control;
            this.Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Undo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Undo.Location = new System.Drawing.Point(1109, 84);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(131, 42);
            this.Undo.TabIndex = 4;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = false;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Reset
            // 
            this.Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reset.BackColor = System.Drawing.SystemColors.Control;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Reset.Location = new System.Drawing.Point(1258, 84);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(131, 42);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // refreshInitial
            // 
            this.refreshInitial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshInitial.BackColor = System.Drawing.SystemColors.Control;
            this.refreshInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshInitial.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.refreshInitial.Location = new System.Drawing.Point(1109, 148);
            this.refreshInitial.Name = "refreshInitial";
            this.refreshInitial.Size = new System.Drawing.Size(131, 60);
            this.refreshInitial.TabIndex = 6;
            this.refreshInitial.Text = "(re)set Initial";
            this.refreshInitial.UseVisualStyleBackColor = false;
            this.refreshInitial.Click += new System.EventHandler(this.refreshInitial_Click);
            // 
            // refreshGoal
            // 
            this.refreshGoal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshGoal.BackColor = System.Drawing.SystemColors.Control;
            this.refreshGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshGoal.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.refreshGoal.Location = new System.Drawing.Point(1258, 148);
            this.refreshGoal.Name = "refreshGoal";
            this.refreshGoal.Size = new System.Drawing.Size(131, 60);
            this.refreshGoal.TabIndex = 7;
            this.refreshGoal.Text = "(re)set Goal";
            this.refreshGoal.UseVisualStyleBackColor = false;
            this.refreshGoal.Click += new System.EventHandler(this.refreshGoal_Click);
            // 
            // count
            // 
            this.count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.ForeColor = System.Drawing.Color.White;
            this.count.Location = new System.Drawing.Point(1233, 270);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(32, 33);
            this.count.TabIndex = 8;
            this.count.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1123, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Misplaced Titles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Click on a Highlighted Number to Move it to the Blank Space";
            // 
            // highlight
            // 
            this.highlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.highlight.BackColor = System.Drawing.SystemColors.Control;
            this.highlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.highlight.Location = new System.Drawing.Point(1182, 327);
            this.highlight.Name = "highlight";
            this.highlight.Size = new System.Drawing.Size(144, 42);
            this.highlight.TabIndex = 11;
            this.highlight.Text = "Highlight On";
            this.highlight.UseVisualStyleBackColor = false;
            this.highlight.Click += new System.EventHandler(this.highlight_Click);
            // 
            // GameArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1397, 573);
            this.Controls.Add(this.highlight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.count);
            this.Controls.Add(this.refreshGoal);
            this.Controls.Add(this.refreshInitial);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.goalBoard);
            this.Controls.Add(this.playBoard);
            this.Name = "GameArea";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel playBoard;
        private System.Windows.Forms.Panel goalBoard;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button refreshInitial;
        private System.Windows.Forms.Button refreshGoal;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button highlight;
    }
}

