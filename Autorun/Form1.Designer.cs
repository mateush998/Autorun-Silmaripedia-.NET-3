namespace Autorun
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
            this.install = new System.Windows.Forms.Label();
            this.pdf_reader = new System.Windows.Forms.Label();
            this.bonuses = new System.Windows.Forms.Label();
            this.exit_p = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stronka = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.presentation = new System.Windows.Forms.Label();
            this.ringtone = new System.Windows.Forms.Label();
            this.wallpaper = new System.Windows.Forms.Label();
            this.optim = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // install
            // 
            this.install.AutoSize = true;
            this.install.BackColor = System.Drawing.Color.Black;
            this.install.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.install.ForeColor = System.Drawing.Color.Yellow;
            this.install.Location = new System.Drawing.Point(170, 212);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(280, 24);
            this.install.TabIndex = 0;
            this.install.Text = "Instaluj program Silmaripedia";
            this.install.Click += new System.EventHandler(this.install_Click);
            this.install.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.install.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // pdf_reader
            // 
            this.pdf_reader.AutoSize = true;
            this.pdf_reader.BackColor = System.Drawing.Color.Black;
            this.pdf_reader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdf_reader.ForeColor = System.Drawing.Color.Yellow;
            this.pdf_reader.Location = new System.Drawing.Point(146, 245);
            this.pdf_reader.Name = "pdf_reader";
            this.pdf_reader.Size = new System.Drawing.Size(331, 24);
            this.pdf_reader.TabIndex = 1;
            this.pdf_reader.Text = "Przeczytaj podręcznik użytkownika";
            this.pdf_reader.Click += new System.EventHandler(this.pdf_reader_Click);
            this.pdf_reader.MouseEnter += new System.EventHandler(this.pdf_reader_MouseEnter);
            this.pdf_reader.MouseLeave += new System.EventHandler(this.pdf_reader_MouseLeave);
            // 
            // bonuses
            // 
            this.bonuses.AutoSize = true;
            this.bonuses.BackColor = System.Drawing.Color.Black;
            this.bonuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bonuses.ForeColor = System.Drawing.Color.Yellow;
            this.bonuses.Location = new System.Drawing.Point(266, 308);
            this.bonuses.Name = "bonuses";
            this.bonuses.Size = new System.Drawing.Size(79, 24);
            this.bonuses.TabIndex = 2;
            this.bonuses.Text = "Dodatki";
            this.bonuses.Click += new System.EventHandler(this.bonuses_Click);
            this.bonuses.MouseEnter += new System.EventHandler(this.bonuses_MouseEnter);
            this.bonuses.MouseLeave += new System.EventHandler(this.bonuses_MouseLeave);
            // 
            // exit_p
            // 
            this.exit_p.AutoSize = true;
            this.exit_p.BackColor = System.Drawing.Color.Black;
            this.exit_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_p.ForeColor = System.Drawing.Color.Yellow;
            this.exit_p.Location = new System.Drawing.Point(273, 339);
            this.exit_p.Name = "exit_p";
            this.exit_p.Size = new System.Drawing.Size(66, 24);
            this.exit_p.TabIndex = 3;
            this.exit_p.Text = "Wyjdź";
            this.exit_p.Click += new System.EventHandler(this.exit_p_Click);
            this.exit_p.MouseEnter += new System.EventHandler(this.exit_p_MouseEnter);
            this.exit_p.MouseLeave += new System.EventHandler(this.exit_p_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // stronka
            // 
            this.stronka.AutoSize = true;
            this.stronka.BackColor = System.Drawing.Color.Black;
            this.stronka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stronka.ForeColor = System.Drawing.Color.Yellow;
            this.stronka.Location = new System.Drawing.Point(175, 276);
            this.stronka.Name = "stronka";
            this.stronka.Size = new System.Drawing.Size(276, 24);
            this.stronka.TabIndex = 5;
            this.stronka.Text = "Strona domowa Silmaripedia";
            this.stronka.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stronka_MouseClick);
            this.stronka.MouseEnter += new System.EventHandler(this.stronka_MouseEnter);
            this.stronka.MouseLeave += new System.EventHandler(this.stronka_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(105, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(401, 213);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back.ForeColor = System.Drawing.Color.Red;
            this.back.Location = new System.Drawing.Point(274, 308);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(59, 24);
            this.back.TabIndex = 7;
            this.back.Text = "Wróć";
            this.back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.back_MouseClick);
            this.back.MouseEnter += new System.EventHandler(this.label1_MouseEnter_1);
            this.back.MouseLeave += new System.EventHandler(this.Wróć_MouseLeave);
            // 
            // presentation
            // 
            this.presentation.AutoSize = true;
            this.presentation.BackColor = System.Drawing.Color.Black;
            this.presentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.presentation.ForeColor = System.Drawing.Color.Yellow;
            this.presentation.Location = new System.Drawing.Point(141, 275);
            this.presentation.Name = "presentation";
            this.presentation.Size = new System.Drawing.Size(336, 24);
            this.presentation.TabIndex = 8;
            this.presentation.Text = "Prezentacja programu Silmaripedia";
            this.presentation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.presentation_MouseClick);
            this.presentation.MouseEnter += new System.EventHandler(this.presentation_MouseEnter);
            this.presentation.MouseLeave += new System.EventHandler(this.presentation_MouseLeave);
            // 
            // ringtone
            // 
            this.ringtone.AutoSize = true;
            this.ringtone.BackColor = System.Drawing.Color.Black;
            this.ringtone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ringtone.ForeColor = System.Drawing.Color.Yellow;
            this.ringtone.Location = new System.Drawing.Point(257, 246);
            this.ringtone.Name = "ringtone";
            this.ringtone.Size = new System.Drawing.Size(88, 24);
            this.ringtone.TabIndex = 9;
            this.ringtone.Text = "Dzwonki";
            this.ringtone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ringtone_MouseClick);
            this.ringtone.MouseEnter += new System.EventHandler(this.ringtone_MouseEnter);
            this.ringtone.MouseLeave += new System.EventHandler(this.ringtone_MouseLeave);
            // 
            // wallpaper
            // 
            this.wallpaper.AutoSize = true;
            this.wallpaper.BackColor = System.Drawing.Color.Black;
            this.wallpaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wallpaper.ForeColor = System.Drawing.Color.Yellow;
            this.wallpaper.Location = new System.Drawing.Point(264, 214);
            this.wallpaper.Name = "wallpaper";
            this.wallpaper.Size = new System.Drawing.Size(73, 24);
            this.wallpaper.TabIndex = 10;
            this.wallpaper.Text = "Tapety";
            this.wallpaper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.wallpaper_MouseClick);
            this.wallpaper.MouseEnter += new System.EventHandler(this.wallpaper_MouseEnter);
            this.wallpaper.MouseLeave += new System.EventHandler(this.wallpaper_MouseLeave);
            // 
            // optim
            // 
            this.optim.BackColor = System.Drawing.Color.Red;
            this.optim.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.optim.Location = new System.Drawing.Point(590, 409);
            this.optim.Name = "optim";
            this.optim.Size = new System.Drawing.Size(22, 21);
            this.optim.TabIndex = 11;
            this.optim.UseVisualStyleBackColor = false;
            this.optim.Click += new System.EventHandler(this.optim_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.ForeColor = System.Drawing.Color.Yellow;
            this.title.Location = new System.Drawing.Point(173, 62);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(288, 42);
            this.title.TabIndex = 12;
            this.title.Text = "SILMARIPEDIA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.title);
            this.Controls.Add(this.optim);
            this.Controls.Add(this.wallpaper);
            this.Controls.Add(this.ringtone);
            this.Controls.Add(this.presentation);
            this.Controls.Add(this.back);
            this.Controls.Add(this.stronka);
            this.Controls.Add(this.exit_p);
            this.Controls.Add(this.bonuses);
            this.Controls.Add(this.pdf_reader);
            this.Controls.Add(this.install);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorun - Silmaripedia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label install;
        private System.Windows.Forms.Label pdf_reader;
        private System.Windows.Forms.Label bonuses;
        private System.Windows.Forms.Label exit_p;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label stronka;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label presentation;
        private System.Windows.Forms.Label ringtone;
        private System.Windows.Forms.Label wallpaper;
        private System.Windows.Forms.Button optim;
        private System.Windows.Forms.Label title;
    }
}

