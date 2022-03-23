namespace FilmDunyasi
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.gbYeniFilm = new System.Windows.Forms.GroupBox();
            this.nudYil = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.clbKategoriler = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.gbFilmler = new System.Windows.Forms.GroupBox();
            this.dgvFilmler = new System.Windows.Forms.DataGridView();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbYeniFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYil)).BeginInit();
            this.gbFilmler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(8, 47);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(199, 24);
            this.txtAd.TabIndex = 1;
            // 
            // gbYeniFilm
            // 
            this.gbYeniFilm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbYeniFilm.Controls.Add(this.nudYil);
            this.gbYeniFilm.Controls.Add(this.label3);
            this.gbYeniFilm.Controls.Add(this.clbKategoriler);
            this.gbYeniFilm.Controls.Add(this.label2);
            this.gbYeniFilm.Controls.Add(this.label1);
            this.gbYeniFilm.Controls.Add(this.btnEkle);
            this.gbYeniFilm.Controls.Add(this.txtAd);
            this.gbYeniFilm.Location = new System.Drawing.Point(14, 13);
            this.gbYeniFilm.Margin = new System.Windows.Forms.Padding(4);
            this.gbYeniFilm.Name = "gbYeniFilm";
            this.gbYeniFilm.Padding = new System.Windows.Forms.Padding(4);
            this.gbYeniFilm.Size = new System.Drawing.Size(279, 523);
            this.gbYeniFilm.TabIndex = 0;
            this.gbYeniFilm.TabStop = false;
            this.gbYeniFilm.Text = "Yeni Film";
            // 
            // nudYil
            // 
            this.nudYil.Location = new System.Drawing.Point(8, 96);
            this.nudYil.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudYil.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudYil.Name = "nudYil";
            this.nudYil.Size = new System.Drawing.Size(120, 24);
            this.nudYil.TabIndex = 7;
            this.nudYil.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategoriler";
            // 
            // clbKategoriler
            // 
            this.clbKategoriler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clbKategoriler.CheckOnClick = true;
            this.clbKategoriler.FormattingEnabled = true;
            this.clbKategoriler.Location = new System.Drawing.Point(8, 165);
            this.clbKategoriler.Margin = new System.Windows.Forms.Padding(4);
            this.clbKategoriler.Name = "clbKategoriler";
            this.clbKategoriler.Size = new System.Drawing.Size(261, 308);
            this.clbKategoriler.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yıl:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Location = new System.Drawing.Point(8, 481);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(261, 34);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // gbFilmler
            // 
            this.gbFilmler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilmler.Controls.Add(this.label4);
            this.gbFilmler.Controls.Add(this.cmbKategoriler);
            this.gbFilmler.Controls.Add(this.dgvFilmler);
            this.gbFilmler.Location = new System.Drawing.Point(301, 13);
            this.gbFilmler.Margin = new System.Windows.Forms.Padding(4);
            this.gbFilmler.Name = "gbFilmler";
            this.gbFilmler.Padding = new System.Windows.Forms.Padding(4);
            this.gbFilmler.Size = new System.Drawing.Size(625, 523);
            this.gbFilmler.TabIndex = 1;
            this.gbFilmler.TabStop = false;
            this.gbFilmler.Text = "Filmler";
            // 
            // dgvFilmler
            // 
            this.dgvFilmler.AllowUserToAddRows = false;
            this.dgvFilmler.AllowUserToDeleteRows = false;
            this.dgvFilmler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmler.Location = new System.Drawing.Point(8, 49);
            this.dgvFilmler.MultiSelect = false;
            this.dgvFilmler.Name = "dgvFilmler";
            this.dgvFilmler.ReadOnly = true;
            this.dgvFilmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmler.Size = new System.Drawing.Size(610, 466);
            this.dgvFilmler.TabIndex = 0;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(497, 17);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(121, 26);
            this.cmbKategoriler.TabIndex = 1;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kategoriler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 553);
            this.Controls.Add(this.gbFilmler);
            this.Controls.Add(this.gbYeniFilm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Dünyası";
            this.gbYeniFilm.ResumeLayout(false);
            this.gbYeniFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYil)).EndInit();
            this.gbFilmler.ResumeLayout(false);
            this.gbFilmler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.GroupBox gbYeniFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckedListBox clbKategoriler;
        private System.Windows.Forms.GroupBox gbFilmler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudYil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFilmler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKategoriler;
    }
}

