
namespace BrickBreaker
{
    partial class LevelSelect
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Button();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftButton
            // 
            this.leftButton.BackColor = System.Drawing.Color.Transparent;
            this.leftButton.FlatAppearance.BorderSize = 0;
            this.leftButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.leftButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leftButton.Location = new System.Drawing.Point(0, 3);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 536);
            this.leftButton.TabIndex = 0;
            this.leftButton.Text = "<";
            this.leftButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leftButton.UseVisualStyleBackColor = false;
            this.leftButton.Visible = false;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            this.leftButton.MouseEnter += new System.EventHandler(this.leftButton_MouseEnter);
            this.leftButton.MouseLeave += new System.EventHandler(this.leftButton_MouseLeave);
            // 
            // rightButton
            // 
            this.rightButton.BackColor = System.Drawing.Color.Transparent;
            this.rightButton.FlatAppearance.BorderSize = 0;
            this.rightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rightButton.Location = new System.Drawing.Point(779, 3);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 536);
            this.rightButton.TabIndex = 1;
            this.rightButton.Text = ">";
            this.rightButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rightButton.UseVisualStyleBackColor = false;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            this.rightButton.MouseEnter += new System.EventHandler(this.rightButton_MouseEnter);
            this.rightButton.MouseLeave += new System.EventHandler(this.rightButton_MouseLeave);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 42);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "<- Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // beginButton
            // 
            this.beginButton.BackColor = System.Drawing.Color.White;
            this.beginButton.FlatAppearance.BorderSize = 0;
            this.beginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.beginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.beginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.Location = new System.Drawing.Point(322, 467);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(204, 49);
            this.beginButton.TabIndex = 6;
            this.beginButton.Text = "Begin!";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.BackColor = System.Drawing.Color.White;
            this.difficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.ForeColor = System.Drawing.Color.Lime;
            this.difficultyLabel.Location = new System.Drawing.Point(232, 107);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(386, 37);
            this.difficultyLabel.TabIndex = 5;
            this.difficultyLabel.Text = "Difficulty: Easy";
            this.difficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.MarioBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.DoubleBuffered = true;
            this.Name = "LevelSelect";
            this.Size = new System.Drawing.Size(854, 542);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Label difficultyLabel;
    }
}
