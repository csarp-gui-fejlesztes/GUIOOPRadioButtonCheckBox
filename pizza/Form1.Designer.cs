namespace pizza
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
            this.groupBoxMeret = new System.Windows.Forms.GroupBox();
            this.radioButtonNagy = new System.Windows.Forms.RadioButton();
            this.radioButtonKozepes = new System.Windows.Forms.RadioButton();
            this.radioButtonKicsi = new System.Windows.Forms.RadioButton();
            this.groupBoxTartalom = new System.Windows.Forms.GroupBox();
            this.checkBoxAlma = new System.Windows.Forms.CheckBox();
            this.checkBoxGomba = new System.Windows.Forms.CheckBox();
            this.checkBoxSonka = new System.Windows.Forms.CheckBox();
            this.numericUpDownMennyiseg = new System.Windows.Forms.NumericUpDown();
            this.labelAr = new System.Windows.Forms.Label();
            this.labelMennyiseg = new System.Windows.Forms.Label();
            this.groupBoxMeret.SuspendLayout();
            this.groupBoxTartalom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMeret
            // 
            this.groupBoxMeret.Controls.Add(this.radioButtonNagy);
            this.groupBoxMeret.Controls.Add(this.radioButtonKozepes);
            this.groupBoxMeret.Controls.Add(this.radioButtonKicsi);
            this.groupBoxMeret.Location = new System.Drawing.Point(35, 35);
            this.groupBoxMeret.Name = "groupBoxMeret";
            this.groupBoxMeret.Size = new System.Drawing.Size(105, 101);
            this.groupBoxMeret.TabIndex = 0;
            this.groupBoxMeret.TabStop = false;
            this.groupBoxMeret.Text = "Méret";
            // 
            // radioButtonNagy
            // 
            this.radioButtonNagy.AutoSize = true;
            this.radioButtonNagy.Location = new System.Drawing.Point(7, 68);
            this.radioButtonNagy.Name = "radioButtonNagy";
            this.radioButtonNagy.Size = new System.Drawing.Size(48, 17);
            this.radioButtonNagy.TabIndex = 2;
            this.radioButtonNagy.TabStop = true;
            this.radioButtonNagy.Text = "nagy";
            this.radioButtonNagy.UseVisualStyleBackColor = true;
            // 
            // radioButtonKozepes
            // 
            this.radioButtonKozepes.AutoSize = true;
            this.radioButtonKozepes.Location = new System.Drawing.Point(7, 44);
            this.radioButtonKozepes.Name = "radioButtonKozepes";
            this.radioButtonKozepes.Size = new System.Drawing.Size(65, 17);
            this.radioButtonKozepes.TabIndex = 1;
            this.radioButtonKozepes.TabStop = true;
            this.radioButtonKozepes.Text = "közepes";
            this.radioButtonKozepes.UseVisualStyleBackColor = true;
            // 
            // radioButtonKicsi
            // 
            this.radioButtonKicsi.AutoSize = true;
            this.radioButtonKicsi.Location = new System.Drawing.Point(7, 20);
            this.radioButtonKicsi.Name = "radioButtonKicsi";
            this.radioButtonKicsi.Size = new System.Drawing.Size(46, 17);
            this.radioButtonKicsi.TabIndex = 0;
            this.radioButtonKicsi.TabStop = true;
            this.radioButtonKicsi.Text = "kicsi";
            this.radioButtonKicsi.UseVisualStyleBackColor = true;
            // 
            // groupBoxTartalom
            // 
            this.groupBoxTartalom.Controls.Add(this.checkBoxAlma);
            this.groupBoxTartalom.Controls.Add(this.checkBoxGomba);
            this.groupBoxTartalom.Controls.Add(this.checkBoxSonka);
            this.groupBoxTartalom.Location = new System.Drawing.Point(202, 35);
            this.groupBoxTartalom.Name = "groupBoxTartalom";
            this.groupBoxTartalom.Size = new System.Drawing.Size(105, 101);
            this.groupBoxTartalom.TabIndex = 1;
            this.groupBoxTartalom.TabStop = false;
            this.groupBoxTartalom.Text = "Tartalom";
            // 
            // checkBoxAlma
            // 
            this.checkBoxAlma.AutoSize = true;
            this.checkBoxAlma.Location = new System.Drawing.Point(7, 68);
            this.checkBoxAlma.Name = "checkBoxAlma";
            this.checkBoxAlma.Size = new System.Drawing.Size(48, 17);
            this.checkBoxAlma.TabIndex = 2;
            this.checkBoxAlma.Text = "alma";
            this.checkBoxAlma.UseVisualStyleBackColor = true;
            // 
            // checkBoxGomba
            // 
            this.checkBoxGomba.AutoSize = true;
            this.checkBoxGomba.Location = new System.Drawing.Point(7, 44);
            this.checkBoxGomba.Name = "checkBoxGomba";
            this.checkBoxGomba.Size = new System.Drawing.Size(58, 17);
            this.checkBoxGomba.TabIndex = 1;
            this.checkBoxGomba.Text = "gomba";
            this.checkBoxGomba.UseVisualStyleBackColor = true;
            // 
            // checkBoxSonka
            // 
            this.checkBoxSonka.AutoSize = true;
            this.checkBoxSonka.Location = new System.Drawing.Point(7, 20);
            this.checkBoxSonka.Name = "checkBoxSonka";
            this.checkBoxSonka.Size = new System.Drawing.Size(55, 17);
            this.checkBoxSonka.TabIndex = 0;
            this.checkBoxSonka.Text = "sonka";
            this.checkBoxSonka.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMennyiseg
            // 
            this.numericUpDownMennyiseg.Location = new System.Drawing.Point(152, 149);
            this.numericUpDownMennyiseg.Name = "numericUpDownMennyiseg";
            this.numericUpDownMennyiseg.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownMennyiseg.TabIndex = 2;
            // 
            // labelAr
            // 
            this.labelAr.Location = new System.Drawing.Point(35, 182);
            this.labelAr.Name = "labelAr";
            this.labelAr.Size = new System.Drawing.Size(100, 54);
            this.labelAr.TabIndex = 3;
            this.labelAr.Text = "Ár:";
            // 
            // labelMennyiseg
            // 
            this.labelMennyiseg.AutoSize = true;
            this.labelMennyiseg.Location = new System.Drawing.Point(79, 149);
            this.labelMennyiseg.Name = "labelMennyiseg";
            this.labelMennyiseg.Size = new System.Drawing.Size(61, 13);
            this.labelMennyiseg.TabIndex = 4;
            this.labelMennyiseg.Text = "Mennyiség:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 245);
            this.Controls.Add(this.labelMennyiseg);
            this.Controls.Add(this.labelAr);
            this.Controls.Add(this.numericUpDownMennyiseg);
            this.Controls.Add(this.groupBoxTartalom);
            this.Controls.Add(this.groupBoxMeret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxMeret.ResumeLayout(false);
            this.groupBoxMeret.PerformLayout();
            this.groupBoxTartalom.ResumeLayout(false);
            this.groupBoxTartalom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMennyiseg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMeret;
        private System.Windows.Forms.RadioButton radioButtonNagy;
        private System.Windows.Forms.RadioButton radioButtonKozepes;
        private System.Windows.Forms.RadioButton radioButtonKicsi;
        private System.Windows.Forms.GroupBox groupBoxTartalom;
        private System.Windows.Forms.CheckBox checkBoxAlma;
        private System.Windows.Forms.CheckBox checkBoxGomba;
        private System.Windows.Forms.CheckBox checkBoxSonka;
        private System.Windows.Forms.NumericUpDown numericUpDownMennyiseg;
        private System.Windows.Forms.Label labelAr;
        private System.Windows.Forms.Label labelMennyiseg;
    }
}

