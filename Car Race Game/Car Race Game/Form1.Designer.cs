namespace Car_Race_Game
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.default_Settings = new System.Windows.Forms.Timer(this.components);
            this.crash = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.car_3 = new System.Windows.Forms.PictureBox();
            this.car_2 = new System.Windows.Forms.PictureBox();
            this.car_1 = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.scoreTxt = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.startAgain = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_1)).BeginInit();
            this.SuspendLayout();
            // 
            // default_Settings
            // 
            this.default_Settings.Enabled = true;
            this.default_Settings.Tick += new System.EventHandler(this.default_Settings_Tick);
            // 
            // crash
            // 
            this.crash.Enabled = true;
            this.crash.Tick += new System.EventHandler(this.crash_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Car_Race_Game.Properties.Resources.road;
            this.panel1.Controls.Add(this.car_3);
            this.panel1.Controls.Add(this.car_2);
            this.panel1.Controls.Add(this.car_1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 747);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // car_3
            // 
            this.car_3.BackColor = System.Drawing.Color.Transparent;
            this.car_3.Image = global::Car_Race_Game.Properties.Resources.car_04;
            this.car_3.Location = new System.Drawing.Point(39, 539);
            this.car_3.Name = "car_3";
            this.car_3.Size = new System.Drawing.Size(84, 149);
            this.car_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car_3.TabIndex = 3;
            this.car_3.TabStop = false;
            // 
            // car_2
            // 
            this.car_2.BackColor = System.Drawing.Color.Transparent;
            this.car_2.Image = global::Car_Race_Game.Properties.Resources.car_07;
            this.car_2.Location = new System.Drawing.Point(161, 11);
            this.car_2.Name = "car_2";
            this.car_2.Size = new System.Drawing.Size(86, 142);
            this.car_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car_2.TabIndex = 1;
            this.car_2.TabStop = false;
            // 
            // car_1
            // 
            this.car_1.BackColor = System.Drawing.Color.Transparent;
            this.car_1.Image = global::Car_Race_Game.Properties.Resources.car_02;
            this.car_1.Location = new System.Drawing.Point(272, 179);
            this.car_1.Name = "car_1";
            this.car_1.Size = new System.Drawing.Size(84, 149);
            this.car_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car_1.TabIndex = 2;
            this.car_1.TabStop = false;
            this.car_1.Click += new System.EventHandler(this.car_1_Click);
            // 
            // start
            // 
            this.start.Interval = 4000;
            this.start.Tick += new System.EventHandler(this.start_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score.Location = new System.Drawing.Point(459, 19);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(24, 25);
            this.score.TabIndex = 4;
            this.score.Text = "0";
            // 
            // scoreTxt
            // 
            this.scoreTxt.AutoSize = true;
            this.scoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreTxt.Location = new System.Drawing.Point(382, 19);
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(74, 25);
            this.scoreTxt.TabIndex = 5;
            this.scoreTxt.Text = "Score:";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.level.Location = new System.Drawing.Point(459, 44);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(24, 25);
            this.level.TabIndex = 6;
            this.level.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(382, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Level :";
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Interval = 1500;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // startAgain
            // 
            this.startAgain.Interval = 3000;
            this.startAgain.Tick += new System.EventHandler(this.startAgain_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(626, 744);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.level);
            this.Controls.Add(this.scoreTxt);
            this.Controls.Add(this.score);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Car Race";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.car_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox car_2;
        private System.Windows.Forms.PictureBox car_1;
        private System.Windows.Forms.Timer default_Settings;
        private System.Windows.Forms.Timer crash;
        private System.Windows.Forms.PictureBox car_3;
        private System.Windows.Forms.Timer start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label scoreTxt;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.Timer startAgain;
    }
}

