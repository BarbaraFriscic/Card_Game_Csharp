namespace Exercise_24_10_22
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
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.lblGameRez = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblKarte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.Location = new System.Drawing.Point(24, 22);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(123, 13);
            this.lblInstruction1.TabIndex = 0;
            this.lblInstruction1.Text = "Pritisni za iduće dijeljenje";
            // 
            // lblGameRez
            // 
            this.lblGameRez.AutoSize = true;
            this.lblGameRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGameRez.Location = new System.Drawing.Point(27, 77);
            this.lblGameRez.Name = "lblGameRez";
            this.lblGameRez.Size = new System.Drawing.Size(0, 15);
            this.lblGameRez.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(164, 17);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Igraj";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblKarte
            // 
            this.lblKarte.AutoSize = true;
            this.lblKarte.Location = new System.Drawing.Point(472, 47);
            this.lblKarte.Name = "lblKarte";
            this.lblKarte.Size = new System.Drawing.Size(0, 13);
            this.lblKarte.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 518);
            this.Controls.Add(this.lblKarte);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblGameRez);
            this.Controls.Add(this.lblInstruction1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Label lblGameRez;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblKarte;
    }
}

