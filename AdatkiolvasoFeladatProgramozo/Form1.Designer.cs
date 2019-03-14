namespace AdatkiolvasoFeladatProgramozo
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
            this.textBoxProgramozoNev = new System.Windows.Forms.TextBox();
            this.labelProgramozoNev = new System.Windows.Forms.Label();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.radioButtonGyakornok = new System.Windows.Forms.RadioButton();
            this.radioButtonJunior = new System.Windows.Forms.RadioButton();
            this.radioButtonSenior = new System.Windows.Forms.RadioButton();
            this.groupBoxTapasztalatok = new System.Windows.Forms.GroupBox();
            this.checkBoxFrontEnd = new System.Windows.Forms.CheckBox();
            this.checkBoxBackEnd = new System.Windows.Forms.CheckBox();
            this.checkBoxDesktop = new System.Windows.Forms.CheckBox();
            this.buttonAdatokKiolvasasa = new System.Windows.Forms.Button();
            this.labelEredmeny = new System.Windows.Forms.Label();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxTapasztalatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxProgramozoNev
            // 
            this.textBoxProgramozoNev.Location = new System.Drawing.Point(128, 18);
            this.textBoxProgramozoNev.Name = "textBoxProgramozoNev";
            this.textBoxProgramozoNev.Size = new System.Drawing.Size(235, 20);
            this.textBoxProgramozoNev.TabIndex = 0;
            // 
            // labelProgramozoNev
            // 
            this.labelProgramozoNev.AutoSize = true;
            this.labelProgramozoNev.Location = new System.Drawing.Point(23, 21);
            this.labelProgramozoNev.Name = "labelProgramozoNev";
            this.labelProgramozoNev.Size = new System.Drawing.Size(99, 13);
            this.labelProgramozoNev.TabIndex = 1;
            this.labelProgramozoNev.Text = "A programozó neve";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.radioButtonSenior);
            this.groupBoxStatus.Controls.Add(this.radioButtonJunior);
            this.groupBoxStatus.Controls.Add(this.radioButtonGyakornok);
            this.groupBoxStatus.Location = new System.Drawing.Point(26, 67);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(143, 118);
            this.groupBoxStatus.TabIndex = 2;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Programozó statusz";
            // 
            // radioButtonGyakornok
            // 
            this.radioButtonGyakornok.AutoSize = true;
            this.radioButtonGyakornok.Location = new System.Drawing.Point(7, 20);
            this.radioButtonGyakornok.Name = "radioButtonGyakornok";
            this.radioButtonGyakornok.Size = new System.Drawing.Size(75, 17);
            this.radioButtonGyakornok.TabIndex = 0;
            this.radioButtonGyakornok.TabStop = true;
            this.radioButtonGyakornok.Text = "gyakornok";
            this.radioButtonGyakornok.UseVisualStyleBackColor = true;
            // 
            // radioButtonJunior
            // 
            this.radioButtonJunior.AutoSize = true;
            this.radioButtonJunior.Location = new System.Drawing.Point(6, 43);
            this.radioButtonJunior.Name = "radioButtonJunior";
            this.radioButtonJunior.Size = new System.Drawing.Size(91, 17);
            this.radioButtonJunior.TabIndex = 1;
            this.radioButtonJunior.TabStop = true;
            this.radioButtonJunior.Text = "junior fejlesztő";
            this.radioButtonJunior.UseVisualStyleBackColor = true;
            // 
            // radioButtonSenior
            // 
            this.radioButtonSenior.AutoSize = true;
            this.radioButtonSenior.Location = new System.Drawing.Point(6, 66);
            this.radioButtonSenior.Name = "radioButtonSenior";
            this.radioButtonSenior.Size = new System.Drawing.Size(111, 17);
            this.radioButtonSenior.TabIndex = 2;
            this.radioButtonSenior.TabStop = true;
            this.radioButtonSenior.Text = "senior programozó";
            this.radioButtonSenior.UseVisualStyleBackColor = true;
            // 
            // groupBoxTapasztalatok
            // 
            this.groupBoxTapasztalatok.Controls.Add(this.checkBoxDesktop);
            this.groupBoxTapasztalatok.Controls.Add(this.checkBoxBackEnd);
            this.groupBoxTapasztalatok.Controls.Add(this.checkBoxFrontEnd);
            this.groupBoxTapasztalatok.Location = new System.Drawing.Point(234, 67);
            this.groupBoxTapasztalatok.Name = "groupBoxTapasztalatok";
            this.groupBoxTapasztalatok.Size = new System.Drawing.Size(172, 118);
            this.groupBoxTapasztalatok.TabIndex = 3;
            this.groupBoxTapasztalatok.TabStop = false;
            this.groupBoxTapasztalatok.Text = "Fejlesztési tapasztalatok";
            // 
            // checkBoxFrontEnd
            // 
            this.checkBoxFrontEnd.AutoSize = true;
            this.checkBoxFrontEnd.Location = new System.Drawing.Point(16, 20);
            this.checkBoxFrontEnd.Name = "checkBoxFrontEnd";
            this.checkBoxFrontEnd.Size = new System.Drawing.Size(109, 17);
            this.checkBoxFrontEnd.TabIndex = 0;
            this.checkBoxFrontEnd.Text = "front end fejlesztő";
            this.checkBoxFrontEnd.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackEnd
            // 
            this.checkBoxBackEnd.AutoSize = true;
            this.checkBoxBackEnd.Location = new System.Drawing.Point(16, 44);
            this.checkBoxBackEnd.Name = "checkBoxBackEnd";
            this.checkBoxBackEnd.Size = new System.Drawing.Size(112, 17);
            this.checkBoxBackEnd.TabIndex = 1;
            this.checkBoxBackEnd.Text = "back end fejlesztő";
            this.checkBoxBackEnd.UseVisualStyleBackColor = true;
            // 
            // checkBoxDesktop
            // 
            this.checkBoxDesktop.AutoSize = true;
            this.checkBoxDesktop.Location = new System.Drawing.Point(16, 66);
            this.checkBoxDesktop.Name = "checkBoxDesktop";
            this.checkBoxDesktop.Size = new System.Drawing.Size(105, 17);
            this.checkBoxDesktop.TabIndex = 2;
            this.checkBoxDesktop.Text = "desktop fejlesztő";
            this.checkBoxDesktop.UseVisualStyleBackColor = true;
            // 
            // buttonAdatokKiolvasasa
            // 
            this.buttonAdatokKiolvasasa.Location = new System.Drawing.Point(32, 203);
            this.buttonAdatokKiolvasasa.Name = "buttonAdatokKiolvasasa";
            this.buttonAdatokKiolvasasa.Size = new System.Drawing.Size(374, 23);
            this.buttonAdatokKiolvasasa.TabIndex = 4;
            this.buttonAdatokKiolvasasa.Text = "Adatokat kiolvas:";
            this.buttonAdatokKiolvasasa.UseVisualStyleBackColor = true;
            // 
            // labelEredmeny
            // 
            this.labelEredmeny.AutoSize = true;
            this.labelEredmeny.Location = new System.Drawing.Point(33, 249);
            this.labelEredmeny.Name = "labelEredmeny";
            this.labelEredmeny.Size = new System.Drawing.Size(399, 13);
            this.labelEredmeny.TabIndex = 5;
            this.labelEredmeny.Text = "Eredmény: Programozó Péter junior fejlesztő, front end és desktop tapasztalatokka" +
    "l.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 296);
            this.Controls.Add(this.labelEredmeny);
            this.Controls.Add(this.buttonAdatokKiolvasasa);
            this.Controls.Add(this.groupBoxTapasztalatok);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.labelProgramozoNev);
            this.Controls.Add(this.textBoxProgramozoNev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.groupBoxTapasztalatok.ResumeLayout(false);
            this.groupBoxTapasztalatok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProgramozoNev;
        private System.Windows.Forms.Label labelProgramozoNev;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.RadioButton radioButtonSenior;
        private System.Windows.Forms.RadioButton radioButtonJunior;
        private System.Windows.Forms.RadioButton radioButtonGyakornok;
        private System.Windows.Forms.GroupBox groupBoxTapasztalatok;
        private System.Windows.Forms.CheckBox checkBoxDesktop;
        private System.Windows.Forms.CheckBox checkBoxBackEnd;
        private System.Windows.Forms.CheckBox checkBoxFrontEnd;
        private System.Windows.Forms.Button buttonAdatokKiolvasasa;
        private System.Windows.Forms.Label labelEredmeny;
    }
}

