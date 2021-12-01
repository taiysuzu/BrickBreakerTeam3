
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
            this.rightButton.MouseEnter += new System.EventHandler(this.rightButton_MouseEnter);
            this.rightButton.MouseLeave += new System.EventHandler(this.rightButton_MouseLeave);
            // 
            // LevelSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.MarioBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
    }
}
