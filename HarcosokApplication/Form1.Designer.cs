
namespace HarcosokApplication
{
    partial class harcosForm
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
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.nevLetrehozas = new System.Windows.Forms.Button();
            this.nev = new System.Windows.Forms.Label();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.kepessegNeveTextBox = new System.Windows.Forms.TextBox();
            this.kepessegHozzaadButton = new System.Windows.Forms.Button();
            this.kepessegTorlesButton = new System.Windows.Forms.Button();
            this.modositasButton = new System.Windows.Forms.Button();
            this.kepessegNevLabel = new System.Windows.Forms.Label();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.hasznaloLabel = new System.Windows.Forms.Label();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.leirasLabel = new System.Windows.Forms.Label();
            this.kepessegLeirasaMutatTextBox = new System.Windows.Forms.TextBox();
            this.harcosokLabel = new System.Windows.Forms.Label();
            this.kepessegeikLabel = new System.Windows.Forms.Label();
            this.kepessegLeirasaLabel = new System.Windows.Forms.Label();
            this.kepessegekListBox = new System.Windows.Forms.ListBox();
            this.karakterTorlesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nevTextBox
            // 
            this.nevTextBox.Location = new System.Drawing.Point(157, 41);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(100, 22);
            this.nevTextBox.TabIndex = 0;
            // 
            // nevLetrehozas
            // 
            this.nevLetrehozas.Location = new System.Drawing.Point(359, 33);
            this.nevLetrehozas.Name = "nevLetrehozas";
            this.nevLetrehozas.Size = new System.Drawing.Size(109, 39);
            this.nevLetrehozas.TabIndex = 1;
            this.nevLetrehozas.Text = "Létrehozás";
            this.nevLetrehozas.UseVisualStyleBackColor = true;
            this.nevLetrehozas.Click += new System.EventHandler(this.nevLetrehozas_Click);
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Location = new System.Drawing.Point(51, 46);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(37, 17);
            this.nev.TabIndex = 2;
            this.nev.Text = "Név:";
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(500, 128);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(246, 84);
            this.leirasTextBox.TabIndex = 3;
            // 
            // kepessegNeveTextBox
            // 
            this.kepessegNeveTextBox.Location = new System.Drawing.Point(157, 162);
            this.kepessegNeveTextBox.Name = "kepessegNeveTextBox";
            this.kepessegNeveTextBox.Size = new System.Drawing.Size(121, 22);
            this.kepessegNeveTextBox.TabIndex = 4;
            // 
            // kepessegHozzaadButton
            // 
            this.kepessegHozzaadButton.Location = new System.Drawing.Point(44, 209);
            this.kepessegHozzaadButton.Name = "kepessegHozzaadButton";
            this.kepessegHozzaadButton.Size = new System.Drawing.Size(97, 33);
            this.kepessegHozzaadButton.TabIndex = 5;
            this.kepessegHozzaadButton.Text = "Hozzáad";
            this.kepessegHozzaadButton.UseVisualStyleBackColor = true;
            this.kepessegHozzaadButton.Click += new System.EventHandler(this.kepessegHozzaadButton_Click);
            // 
            // kepessegTorlesButton
            // 
            this.kepessegTorlesButton.Location = new System.Drawing.Point(359, 495);
            this.kepessegTorlesButton.Name = "kepessegTorlesButton";
            this.kepessegTorlesButton.Size = new System.Drawing.Size(75, 23);
            this.kepessegTorlesButton.TabIndex = 6;
            this.kepessegTorlesButton.Text = "Törlés";
            this.kepessegTorlesButton.UseVisualStyleBackColor = true;
            // 
            // modositasButton
            // 
            this.modositasButton.Location = new System.Drawing.Point(734, 443);
            this.modositasButton.Name = "modositasButton";
            this.modositasButton.Size = new System.Drawing.Size(138, 23);
            this.modositasButton.TabIndex = 7;
            this.modositasButton.Text = "Módosítás";
            this.modositasButton.UseVisualStyleBackColor = true;
            // 
            // kepessegNevLabel
            // 
            this.kepessegNevLabel.AutoSize = true;
            this.kepessegNevLabel.BackColor = System.Drawing.SystemColors.Control;
            this.kepessegNevLabel.Location = new System.Drawing.Point(41, 165);
            this.kepessegNevLabel.Name = "kepessegNevLabel";
            this.kepessegNevLabel.Size = new System.Drawing.Size(110, 17);
            this.kepessegNevLabel.TabIndex = 9;
            this.kepessegNevLabel.Text = "Képesség neve:";
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(157, 119);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(121, 24);
            this.hasznaloComboBox.TabIndex = 10;
            // 
            // hasznaloLabel
            // 
            this.hasznaloLabel.AutoSize = true;
            this.hasznaloLabel.Location = new System.Drawing.Point(51, 119);
            this.hasznaloLabel.Name = "hasznaloLabel";
            this.hasznaloLabel.Size = new System.Drawing.Size(71, 17);
            this.hasznaloLabel.TabIndex = 11;
            this.hasznaloLabel.Text = "Használó:";
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.ItemHeight = 16;
            this.harcosokListBox.Location = new System.Drawing.Point(12, 286);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(155, 196);
            this.harcosokListBox.TabIndex = 12;
            // 
            // leirasLabel
            // 
            this.leirasLabel.AutoSize = true;
            this.leirasLabel.BackColor = System.Drawing.SystemColors.Control;
            this.leirasLabel.Location = new System.Drawing.Point(497, 108);
            this.leirasLabel.Name = "leirasLabel";
            this.leirasLabel.Size = new System.Drawing.Size(51, 17);
            this.leirasLabel.TabIndex = 14;
            this.leirasLabel.Text = "Leírás:";
            // 
            // kepessegLeirasaMutatTextBox
            // 
            this.kepessegLeirasaMutatTextBox.Location = new System.Drawing.Point(563, 286);
            this.kepessegLeirasaMutatTextBox.Multiline = true;
            this.kepessegLeirasaMutatTextBox.Name = "kepessegLeirasaMutatTextBox";
            this.kepessegLeirasaMutatTextBox.Size = new System.Drawing.Size(309, 151);
            this.kepessegLeirasaMutatTextBox.TabIndex = 15;
            // 
            // harcosokLabel
            // 
            this.harcosokLabel.AutoSize = true;
            this.harcosokLabel.BackColor = System.Drawing.SystemColors.Control;
            this.harcosokLabel.Location = new System.Drawing.Point(51, 257);
            this.harcosokLabel.Name = "harcosokLabel";
            this.harcosokLabel.Size = new System.Drawing.Size(72, 17);
            this.harcosokLabel.TabIndex = 16;
            this.harcosokLabel.Text = "Harcosok:";
            // 
            // kepessegeikLabel
            // 
            this.kepessegeikLabel.AutoSize = true;
            this.kepessegeikLabel.BackColor = System.Drawing.SystemColors.Control;
            this.kepessegeikLabel.Location = new System.Drawing.Point(227, 257);
            this.kepessegeikLabel.Name = "kepessegeikLabel";
            this.kepessegeikLabel.Size = new System.Drawing.Size(86, 17);
            this.kepessegeikLabel.TabIndex = 17;
            this.kepessegeikLabel.Text = "Képességei:";
            // 
            // kepessegLeirasaLabel
            // 
            this.kepessegLeirasaLabel.AutoSize = true;
            this.kepessegLeirasaLabel.BackColor = System.Drawing.SystemColors.Control;
            this.kepessegLeirasaLabel.Location = new System.Drawing.Point(560, 257);
            this.kepessegLeirasaLabel.Name = "kepessegLeirasaLabel";
            this.kepessegLeirasaLabel.Size = new System.Drawing.Size(126, 17);
            this.kepessegLeirasaLabel.TabIndex = 18;
            this.kepessegLeirasaLabel.Text = "Képesség Leírása:";
            // 
            // kepessegekListBox
            // 
            this.kepessegekListBox.FormattingEnabled = true;
            this.kepessegekListBox.ItemHeight = 16;
            this.kepessegekListBox.Location = new System.Drawing.Point(230, 286);
            this.kepessegekListBox.Name = "kepessegekListBox";
            this.kepessegekListBox.Size = new System.Drawing.Size(318, 196);
            this.kepessegekListBox.TabIndex = 19;
            // 
            // karakterTorlesButton
            // 
            this.karakterTorlesButton.Location = new System.Drawing.Point(44, 488);
            this.karakterTorlesButton.Name = "karakterTorlesButton";
            this.karakterTorlesButton.Size = new System.Drawing.Size(75, 23);
            this.karakterTorlesButton.TabIndex = 20;
            this.karakterTorlesButton.Text = "Törlés";
            this.karakterTorlesButton.UseVisualStyleBackColor = true;
            this.karakterTorlesButton.Click += new System.EventHandler(this.karakterTorlesButton_Click);
            // 
            // harcosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 530);
            this.Controls.Add(this.karakterTorlesButton);
            this.Controls.Add(this.kepessegekListBox);
            this.Controls.Add(this.kepessegLeirasaLabel);
            this.Controls.Add(this.kepessegeikLabel);
            this.Controls.Add(this.harcosokLabel);
            this.Controls.Add(this.kepessegLeirasaMutatTextBox);
            this.Controls.Add(this.leirasLabel);
            this.Controls.Add(this.harcosokListBox);
            this.Controls.Add(this.hasznaloLabel);
            this.Controls.Add(this.hasznaloComboBox);
            this.Controls.Add(this.kepessegNevLabel);
            this.Controls.Add(this.modositasButton);
            this.Controls.Add(this.kepessegTorlesButton);
            this.Controls.Add(this.kepessegHozzaadButton);
            this.Controls.Add(this.kepessegNeveTextBox);
            this.Controls.Add(this.leirasTextBox);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.nevLetrehozas);
            this.Controls.Add(this.nevTextBox);
            this.Name = "harcosForm";
            this.Text = "Beadandó Harcos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.Button nevLetrehozas;
        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.TextBox kepessegNeveTextBox;
        private System.Windows.Forms.Button kepessegHozzaadButton;
        private System.Windows.Forms.Button kepessegTorlesButton;
        private System.Windows.Forms.Button modositasButton;
        private System.Windows.Forms.Label kepessegNevLabel;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.Label hasznaloLabel;
        private System.Windows.Forms.ListBox harcosokListBox;
        private System.Windows.Forms.Label leirasLabel;
        private System.Windows.Forms.TextBox kepessegLeirasaMutatTextBox;
        private System.Windows.Forms.Label harcosokLabel;
        private System.Windows.Forms.Label kepessegeikLabel;
        private System.Windows.Forms.Label kepessegLeirasaLabel;
        private System.Windows.Forms.ListBox kepessegekListBox;
        private System.Windows.Forms.Button karakterTorlesButton;
    }
}

