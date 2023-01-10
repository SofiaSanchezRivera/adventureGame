namespace adventureGame
{
    partial class DanceNight
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanceNight));
            this.outputLabel = new System.Windows.Forms.Label();
            this.option2button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Times New Roman", 12.5F);
            this.outputLabel.Location = new System.Drawing.Point(26, 26);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(432, 39);
            this.outputLabel.TabIndex = 0;
            // 
            // option2button
            // 
            this.option2button.Image = global::adventureGame.Properties.Resources.morado;
            this.option2button.Location = new System.Drawing.Point(29, 404);
            this.option2button.Name = "option2button";
            this.option2button.Size = new System.Drawing.Size(43, 34);
            this.option2button.TabIndex = 3;
            this.option2button.UseVisualStyleBackColor = true;
            this.option2button.Click += new System.EventHandler(this.option2button_Click);
            // 
            // option3Button
            // 
            this.option3Button.Image = global::adventureGame.Properties.Resources.morado;
            this.option3Button.Location = new System.Drawing.Point(29, 455);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(43, 34);
            this.option3Button.TabIndex = 4;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3button_Click);
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.Location = new System.Drawing.Point(78, 361);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(380, 21);
            this.option1Label.TabIndex = 5;
            this.option1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.Location = new System.Drawing.Point(78, 411);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(380, 21);
            this.option2Label.TabIndex = 6;
            this.option2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option3Label
            // 
            this.option3Label.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.Location = new System.Drawing.Point(78, 462);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(380, 21);
            this.option3Label.TabIndex = 7;
            this.option3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option1Button
            // 
            this.option1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.option1Button.Image = global::adventureGame.Properties.Resources.morado;
            this.option1Button.Location = new System.Drawing.Point(29, 354);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(43, 34);
            this.option1Button.TabIndex = 2;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(29, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DanceNight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(484, 501);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 540);
            this.MinimumSize = new System.Drawing.Size(500, 540);
            this.Name = "DanceNight";
            this.Text = "Dance Night";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option3Label;
    }
}

