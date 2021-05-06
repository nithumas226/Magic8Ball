
namespace Magic8Ball
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.thinkLabel = new System.Windows.Forms.Label();
            this.magicButton = new System.Windows.Forms.Button();
            this.ballButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thinkLabel
            // 
            this.thinkLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thinkLabel.ForeColor = System.Drawing.Color.White;
            this.thinkLabel.Location = new System.Drawing.Point(202, 44);
            this.thinkLabel.Name = "thinkLabel";
            this.thinkLabel.Size = new System.Drawing.Size(228, 51);
            this.thinkLabel.TabIndex = 0;
            this.thinkLabel.Text = "Think of a Question";
            this.thinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // magicButton
            // 
            this.magicButton.BackColor = System.Drawing.Color.Transparent;
            this.magicButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("magicButton.BackgroundImage")));
            this.magicButton.FlatAppearance.BorderSize = 0;
            this.magicButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.magicButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.magicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magicButton.Location = new System.Drawing.Point(165, 158);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(75, 23);
            this.magicButton.TabIndex = 1;
            this.magicButton.UseVisualStyleBackColor = false;
            // 
            // ballButton
            // 
            this.ballButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ballButton.BackgroundImage")));
            this.ballButton.FlatAppearance.BorderSize = 0;
            this.ballButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ballButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ballButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ballButton.Location = new System.Drawing.Point(12, 98);
            this.ballButton.Name = "ballButton";
            this.ballButton.Size = new System.Drawing.Size(559, 484);
            this.ballButton.TabIndex = 2;
            this.ballButton.UseVisualStyleBackColor = true;
            this.ballButton.Click += new System.EventHandler(this.ballButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(120, 585);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(389, 51);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(627, 660);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.ballButton);
            this.Controls.Add(this.magicButton);
            this.Controls.Add(this.thinkLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Magic 8 Ball";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label thinkLabel;
        private System.Windows.Forms.Button magicButton;
        private System.Windows.Forms.Button ballButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

