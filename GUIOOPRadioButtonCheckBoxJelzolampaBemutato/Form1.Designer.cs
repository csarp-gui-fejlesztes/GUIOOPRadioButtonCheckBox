namespace GUIOOPRadioButtonCheckBoxJelzolampaBemutato
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
            this.radioButtonPiros = new System.Windows.Forms.RadioButton();
            this.radioButtonSarga = new System.Windows.Forms.RadioButton();
            this.radioButtonZold = new System.Windows.Forms.RadioButton();
            this.buttonKovetkezo = new System.Windows.Forms.Button();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonPiros
            // 
            this.radioButtonPiros.AutoSize = true;
            this.radioButtonPiros.Location = new System.Drawing.Point(38, 30);
            this.radioButtonPiros.Name = "radioButtonPiros";
            this.radioButtonPiros.Size = new System.Drawing.Size(47, 17);
            this.radioButtonPiros.TabIndex = 0;
            this.radioButtonPiros.TabStop = true;
            this.radioButtonPiros.Text = "piros";
            this.radioButtonPiros.UseVisualStyleBackColor = true;
            // 
            // radioButtonSarga
            // 
            this.radioButtonSarga.AutoSize = true;
            this.radioButtonSarga.Location = new System.Drawing.Point(38, 64);
            this.radioButtonSarga.Name = "radioButtonSarga";
            this.radioButtonSarga.Size = new System.Drawing.Size(51, 17);
            this.radioButtonSarga.TabIndex = 1;
            this.radioButtonSarga.TabStop = true;
            this.radioButtonSarga.Text = "sárga";
            this.radioButtonSarga.UseVisualStyleBackColor = true;
            // 
            // radioButtonZold
            // 
            this.radioButtonZold.AutoSize = true;
            this.radioButtonZold.Location = new System.Drawing.Point(38, 103);
            this.radioButtonZold.Name = "radioButtonZold";
            this.radioButtonZold.Size = new System.Drawing.Size(44, 17);
            this.radioButtonZold.TabIndex = 2;
            this.radioButtonZold.TabStop = true;
            this.radioButtonZold.Text = "zöld";
            this.radioButtonZold.UseVisualStyleBackColor = true;
            // 
            // buttonKovetkezo
            // 
            this.buttonKovetkezo.Location = new System.Drawing.Point(159, 30);
            this.buttonKovetkezo.Name = "buttonKovetkezo";
            this.buttonKovetkezo.Size = new System.Drawing.Size(75, 23);
            this.buttonKovetkezo.TabIndex = 3;
            this.buttonKovetkezo.Text = "Következő";
            this.buttonKovetkezo.UseVisualStyleBackColor = true;
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.Location = new System.Drawing.Point(185, 161);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(75, 23);
            this.buttonKilepes.TabIndex = 4;
            this.buttonKilepes.Text = "Kilépés";
            this.buttonKilepes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 256);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.buttonKovetkezo);
            this.Controls.Add(this.radioButtonZold);
            this.Controls.Add(this.radioButtonSarga);
            this.Controls.Add(this.radioButtonPiros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonPiros;
        private System.Windows.Forms.RadioButton radioButtonSarga;
        private System.Windows.Forms.RadioButton radioButtonZold;
        private System.Windows.Forms.Button buttonKovetkezo;
        private System.Windows.Forms.Button buttonKilepes;
    }
}

