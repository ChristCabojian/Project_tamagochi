namespace TamaGochi_christ
{
    partial class frm_tamagochi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tamagochi));
            this.lblEten = new System.Windows.Forms.Label();
            this.lblDrinken = new System.Windows.Forms.Label();
            this.lblGezondheid = new System.Windows.Forms.Label();
            this.barFood = new System.Windows.Forms.ProgressBar();
            this.barDrinken = new System.Windows.Forms.ProgressBar();
            this.barGezondheid = new System.Windows.Forms.ProgressBar();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnEten = new System.Windows.Forms.Button();
            this.btnDrinken = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEten
            // 
            this.lblEten.AutoSize = true;
            this.lblEten.BackColor = System.Drawing.Color.Transparent;
            this.lblEten.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEten.Location = new System.Drawing.Point(41, 23);
            this.lblEten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEten.Name = "lblEten";
            this.lblEten.Size = new System.Drawing.Size(113, 38);
            this.lblEten.TabIndex = 0;
            this.lblEten.Text = "Food:";
            // 
            // lblDrinken
            // 
            this.lblDrinken.AutoSize = true;
            this.lblDrinken.BackColor = System.Drawing.Color.Transparent;
            this.lblDrinken.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinken.Location = new System.Drawing.Point(21, 73);
            this.lblDrinken.Name = "lblDrinken";
            this.lblDrinken.Size = new System.Drawing.Size(134, 38);
            this.lblDrinken.TabIndex = 1;
            this.lblDrinken.Text = "Drink:";
            // 
            // lblGezondheid
            // 
            this.lblGezondheid.AutoSize = true;
            this.lblGezondheid.BackColor = System.Drawing.Color.Transparent;
            this.lblGezondheid.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGezondheid.Location = new System.Drawing.Point(3, 117);
            this.lblGezondheid.Name = "lblGezondheid";
            this.lblGezondheid.Size = new System.Drawing.Size(152, 38);
            this.lblGezondheid.TabIndex = 2;
            this.lblGezondheid.Text = "Health:";
            // 
            // barFood
            // 
            this.barFood.Location = new System.Drawing.Point(161, 17);
            this.barFood.Name = "barFood";
            this.barFood.Size = new System.Drawing.Size(328, 44);
            this.barFood.TabIndex = 12;
            this.barFood.Value = 100;
            // 
            // barDrinken
            // 
            this.barDrinken.Location = new System.Drawing.Point(161, 67);
            this.barDrinken.Name = "barDrinken";
            this.barDrinken.Size = new System.Drawing.Size(328, 44);
            this.barDrinken.TabIndex = 12;
            this.barDrinken.Value = 100;
            // 
            // barGezondheid
            // 
            this.barGezondheid.Location = new System.Drawing.Point(161, 117);
            this.barGezondheid.Name = "barGezondheid";
            this.barGezondheid.Size = new System.Drawing.Size(328, 44);
            this.barGezondheid.TabIndex = 12;
            this.barGezondheid.Value = 100;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(557, 52);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(142, 44);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score";
            // 
            // btnEten
            // 
            this.btnEten.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEten.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEten.BackgroundImage")));
            this.btnEten.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnEten.FlatAppearance.BorderSize = 20;
            this.btnEten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEten.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEten.ForeColor = System.Drawing.Color.Black;
            this.btnEten.Location = new System.Drawing.Point(511, 207);
            this.btnEten.Name = "btnEten";
            this.btnEten.Size = new System.Drawing.Size(277, 86);
            this.btnEten.TabIndex = 10;
            this.btnEten.Text = "Eat";
            this.btnEten.UseVisualStyleBackColor = false;
            this.btnEten.Click += new System.EventHandler(this.btnEten_Click);
            // 
            // btnDrinken
            // 
            this.btnDrinken.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDrinken.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDrinken.BackgroundImage")));
            this.btnDrinken.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnDrinken.FlatAppearance.BorderSize = 20;
            this.btnDrinken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDrinken.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinken.ForeColor = System.Drawing.Color.Black;
            this.btnDrinken.Location = new System.Drawing.Point(511, 320);
            this.btnDrinken.Name = "btnDrinken";
            this.btnDrinken.Size = new System.Drawing.Size(277, 86);
            this.btnDrinken.TabIndex = 10;
            this.btnDrinken.Text = "Drink";
            this.btnDrinken.UseVisualStyleBackColor = false;
            this.btnDrinken.Click += new System.EventHandler(this.btnDrinken_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.Transparent;
            this.pbFoto.ErrorImage = null;
            this.pbFoto.InitialImage = null;
            this.pbFoto.Location = new System.Drawing.Point(1, 176);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(487, 334);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 9;
            this.pbFoto.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_tamagochi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 522);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnDrinken);
            this.Controls.Add(this.btnEten);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.barGezondheid);
            this.Controls.Add(this.barDrinken);
            this.Controls.Add(this.barFood);
            this.Controls.Add(this.lblGezondheid);
            this.Controls.Add(this.lblDrinken);
            this.Controls.Add(this.lblEten);
            this.Name = "frm_tamagochi";
            this.Text = "Tamagochi_christ";
            this.Load += new System.EventHandler(this.frm_tamagochi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEten;
        private System.Windows.Forms.Label lblDrinken;
        private System.Windows.Forms.Label lblGezondheid;
        private System.Windows.Forms.ProgressBar barFood;
        private System.Windows.Forms.ProgressBar barDrinken;
        private System.Windows.Forms.ProgressBar barGezondheid;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnEten;
        private System.Windows.Forms.Button btnDrinken;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Timer timer1;
    }
}

