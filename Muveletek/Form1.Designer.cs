namespace GUIOOPRadioButtonCheckBox
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
            this.components = new System.ComponentModel.Container();
            this.labelElsoSzam = new System.Windows.Forms.Label();
            this.labelMasodikSzam = new System.Windows.Forms.Label();
            this.textBoxElsoSzam = new System.Windows.Forms.TextBox();
            this.textBoxMasodikSzam = new System.Windows.Forms.TextBox();
            this.labelEgyenlo = new System.Windows.Forms.Label();
            this.textBoxEredmeny = new System.Windows.Forms.TextBox();
            this.groupBoxMuvelet = new System.Windows.Forms.GroupBox();
            this.radioButtonOsztas = new System.Windows.Forms.RadioButton();
            this.radioButtonSzorzas = new System.Windows.Forms.RadioButton();
            this.radioButtonKivonas = new System.Windows.Forms.RadioButton();
            this.radioButtonOsszeadas = new System.Windows.Forms.RadioButton();
            this.errorProviderMuveletHiba = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelMuvelet = new System.Windows.Forms.Label();
            this.groupBoxMuvelet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMuveletHiba)).BeginInit();
            this.SuspendLayout();
            // 
            // labelElsoSzam
            // 
            this.labelElsoSzam.AutoSize = true;
            this.labelElsoSzam.Location = new System.Drawing.Point(23, 14);
            this.labelElsoSzam.Name = "labelElsoSzam";
            this.labelElsoSzam.Size = new System.Drawing.Size(57, 13);
            this.labelElsoSzam.TabIndex = 0;
            this.labelElsoSzam.Text = "Első szám:";
            // 
            // labelMasodikSzam
            // 
            this.labelMasodikSzam.AutoSize = true;
            this.labelMasodikSzam.Location = new System.Drawing.Point(114, 14);
            this.labelMasodikSzam.Name = "labelMasodikSzam";
            this.labelMasodikSzam.Size = new System.Drawing.Size(77, 13);
            this.labelMasodikSzam.TabIndex = 1;
            this.labelMasodikSzam.Text = "Második szám:";
            // 
            // textBoxElsoSzam
            // 
            this.textBoxElsoSzam.Location = new System.Drawing.Point(26, 30);
            this.textBoxElsoSzam.Name = "textBoxElsoSzam";
            this.textBoxElsoSzam.Size = new System.Drawing.Size(54, 20);
            this.textBoxElsoSzam.TabIndex = 2;
            this.textBoxElsoSzam.Text = "1";            
            // 
            // textBoxMasodikSzam
            // 
            this.textBoxMasodikSzam.Location = new System.Drawing.Point(117, 30);
            this.textBoxMasodikSzam.Name = "textBoxMasodikSzam";
            this.textBoxMasodikSzam.Size = new System.Drawing.Size(54, 20);
            this.textBoxMasodikSzam.TabIndex = 3;
            this.textBoxMasodikSzam.Text = "1";
            // 
            // labelEgyenlo
            // 
            this.labelEgyenlo.AutoSize = true;
            this.labelEgyenlo.Location = new System.Drawing.Point(177, 33);
            this.labelEgyenlo.Name = "labelEgyenlo";
            this.labelEgyenlo.Size = new System.Drawing.Size(13, 13);
            this.labelEgyenlo.TabIndex = 4;
            this.labelEgyenlo.Text = "=";
            // 
            // textBoxEredmeny
            // 
            this.textBoxEredmeny.Location = new System.Drawing.Point(196, 30);
            this.textBoxEredmeny.Name = "textBoxEredmeny";
            this.textBoxEredmeny.ReadOnly = true;
            this.textBoxEredmeny.Size = new System.Drawing.Size(54, 20);
            this.textBoxEredmeny.TabIndex = 5;
            // 
            // groupBoxMuvelet
            // 
            this.groupBoxMuvelet.Controls.Add(this.radioButtonOsztas);
            this.groupBoxMuvelet.Controls.Add(this.radioButtonSzorzas);
            this.groupBoxMuvelet.Controls.Add(this.radioButtonKivonas);
            this.groupBoxMuvelet.Controls.Add(this.radioButtonOsszeadas);
            this.groupBoxMuvelet.Location = new System.Drawing.Point(26, 81);
            this.groupBoxMuvelet.Name = "groupBoxMuvelet";
            this.groupBoxMuvelet.Size = new System.Drawing.Size(200, 118);
            this.groupBoxMuvelet.TabIndex = 6;
            this.groupBoxMuvelet.TabStop = false;
            this.groupBoxMuvelet.Text = "Válasszon műveletet";
            // 
            // radioButtonOsztas
            // 
            this.radioButtonOsztas.AutoSize = true;
            this.radioButtonOsztas.Location = new System.Drawing.Point(6, 89);
            this.radioButtonOsztas.Name = "radioButtonOsztas";
            this.radioButtonOsztas.Size = new System.Drawing.Size(55, 17);
            this.radioButtonOsztas.TabIndex = 3;
            this.radioButtonOsztas.TabStop = true;
            this.radioButtonOsztas.Text = "osztas";
            this.radioButtonOsztas.UseVisualStyleBackColor = true;
            // 
            // radioButtonSzorzas
            // 
            this.radioButtonSzorzas.AutoSize = true;
            this.radioButtonSzorzas.Location = new System.Drawing.Point(6, 66);
            this.radioButtonSzorzas.Name = "radioButtonSzorzas";
            this.radioButtonSzorzas.Size = new System.Drawing.Size(60, 17);
            this.radioButtonSzorzas.TabIndex = 2;
            this.radioButtonSzorzas.TabStop = true;
            this.radioButtonSzorzas.Text = "szorzás";
            this.radioButtonSzorzas.UseVisualStyleBackColor = true;
            // 
            // radioButtonKivonas
            // 
            this.radioButtonKivonas.AutoSize = true;
            this.radioButtonKivonas.Location = new System.Drawing.Point(7, 43);
            this.radioButtonKivonas.Name = "radioButtonKivonas";
            this.radioButtonKivonas.Size = new System.Drawing.Size(62, 17);
            this.radioButtonKivonas.TabIndex = 1;
            this.radioButtonKivonas.TabStop = true;
            this.radioButtonKivonas.Text = "kivonás";
            this.radioButtonKivonas.UseVisualStyleBackColor = true;
            // 
            // radioButtonOsszeadas
            // 
            this.radioButtonOsszeadas.AutoSize = true;
            this.radioButtonOsszeadas.Location = new System.Drawing.Point(7, 20);
            this.radioButtonOsszeadas.Name = "radioButtonOsszeadas";
            this.radioButtonOsszeadas.Size = new System.Drawing.Size(75, 17);
            this.radioButtonOsszeadas.TabIndex = 0;
            this.radioButtonOsszeadas.TabStop = true;
            this.radioButtonOsszeadas.Text = "összeadás";
            this.radioButtonOsszeadas.UseVisualStyleBackColor = true;            
            // 
            // errorProviderMuveletHiba
            // 
            this.errorProviderMuveletHiba.ContainerControl = this;
            // 
            // labelMuvelet
            // 
            this.labelMuvelet.AutoSize = true;
            this.labelMuvelet.Location = new System.Drawing.Point(95, 33);
            this.labelMuvelet.Name = "labelMuvelet";
            this.labelMuvelet.Size = new System.Drawing.Size(13, 13);
            this.labelMuvelet.TabIndex = 7;
            this.labelMuvelet.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelMuvelet);
            this.Controls.Add(this.groupBoxMuvelet);
            this.Controls.Add(this.textBoxEredmeny);
            this.Controls.Add(this.labelEgyenlo);
            this.Controls.Add(this.textBoxMasodikSzam);
            this.Controls.Add(this.textBoxElsoSzam);
            this.Controls.Add(this.labelMasodikSzam);
            this.Controls.Add(this.labelElsoSzam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxMuvelet.ResumeLayout(false);
            this.groupBoxMuvelet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMuveletHiba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelElsoSzam;
        private System.Windows.Forms.Label labelMasodikSzam;
        private System.Windows.Forms.TextBox textBoxElsoSzam;
        private System.Windows.Forms.TextBox textBoxMasodikSzam;
        private System.Windows.Forms.Label labelEgyenlo;
        private System.Windows.Forms.TextBox textBoxEredmeny;
        private System.Windows.Forms.GroupBox groupBoxMuvelet;
        private System.Windows.Forms.RadioButton radioButtonOsztas;
        private System.Windows.Forms.RadioButton radioButtonSzorzas;
        private System.Windows.Forms.RadioButton radioButtonKivonas;
        private System.Windows.Forms.RadioButton radioButtonOsszeadas;
        private System.Windows.Forms.ErrorProvider errorProviderMuveletHiba;
        private System.Windows.Forms.Label labelMuvelet;
    }
}

