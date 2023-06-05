namespace tamagochi_ontwerp
{
    partial class frm_christ
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbGezondheid = new System.Windows.Forms.ProgressBar();
            this.pbDrinken = new System.Windows.Forms.ProgressBar();
            this.pbEten = new System.Windows.Forms.ProgressBar();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGezondheid = new System.Windows.Forms.Label();
            this.lblDrinken = new System.Windows.Forms.Label();
            this.lblEten = new System.Windows.Forms.Label();
            this.btnDrinken = new System.Windows.Forms.Button();
            this.btnEten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(109, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 238);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pbGezondheid
            // 
            this.pbGezondheid.Location = new System.Drawing.Point(275, 135);
            this.pbGezondheid.Name = "pbGezondheid";
            this.pbGezondheid.Size = new System.Drawing.Size(257, 39);
            this.pbGezondheid.TabIndex = 36;
            // 
            // pbDrinken
            // 
            this.pbDrinken.Location = new System.Drawing.Point(275, 77);
            this.pbDrinken.Name = "pbDrinken";
            this.pbDrinken.Size = new System.Drawing.Size(257, 39);
            this.pbDrinken.TabIndex = 35;
            // 
            // pbEten
            // 
            this.pbEten.Location = new System.Drawing.Point(275, 22);
            this.pbEten.Name = "pbEten";
            this.pbEten.Size = new System.Drawing.Size(257, 39);
            this.pbEten.TabIndex = 34;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblScore.Location = new System.Drawing.Point(656, 77);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(111, 39);
            this.lblScore.TabIndex = 33;
            this.lblScore.Text = "Score";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lblGezondheid
            // 
            this.lblGezondheid.AutoSize = true;
            this.lblGezondheid.BackColor = System.Drawing.Color.Transparent;
            this.lblGezondheid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGezondheid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGezondheid.Location = new System.Drawing.Point(33, 135);
            this.lblGezondheid.Name = "lblGezondheid";
            this.lblGezondheid.Size = new System.Drawing.Size(221, 39);
            this.lblGezondheid.TabIndex = 32;
            this.lblGezondheid.Text = "Gezondheid:";
            // 
            // lblDrinken
            // 
            this.lblDrinken.AutoSize = true;
            this.lblDrinken.BackColor = System.Drawing.Color.Transparent;
            this.lblDrinken.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinken.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDrinken.Location = new System.Drawing.Point(41, 77);
            this.lblDrinken.Name = "lblDrinken";
            this.lblDrinken.Size = new System.Drawing.Size(152, 39);
            this.lblDrinken.TabIndex = 31;
            this.lblDrinken.Text = "Drinken:";
            // 
            // lblEten
            // 
            this.lblEten.AutoSize = true;
            this.lblEten.BackColor = System.Drawing.Color.Transparent;
            this.lblEten.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEten.Location = new System.Drawing.Point(41, 22);
            this.lblEten.Name = "lblEten";
            this.lblEten.Size = new System.Drawing.Size(101, 39);
            this.lblEten.TabIndex = 30;
            this.lblEten.Text = "Eten:";
            // 
            // btnDrinken
            // 
            this.btnDrinken.Location = new System.Drawing.Point(621, 258);
            this.btnDrinken.Name = "btnDrinken";
            this.btnDrinken.Size = new System.Drawing.Size(157, 79);
            this.btnDrinken.TabIndex = 29;
            this.btnDrinken.Text = "Drinken";
            this.btnDrinken.UseVisualStyleBackColor = true;
            // 
            // btnEten
            // 
            this.btnEten.Location = new System.Drawing.Point(621, 173);
            this.btnEten.Name = "btnEten";
            this.btnEten.Size = new System.Drawing.Size(157, 79);
            this.btnEten.TabIndex = 28;
            this.btnEten.Text = "Eten";
            this.btnEten.UseVisualStyleBackColor = true;
            // 
            // frm_christ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbGezondheid);
            this.Controls.Add(this.pbDrinken);
            this.Controls.Add(this.pbEten);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblGezondheid);
            this.Controls.Add(this.lblDrinken);
            this.Controls.Add(this.lblEten);
            this.Controls.Add(this.btnDrinken);
            this.Controls.Add(this.btnEten);
            this.Name = "frm_christ";
            this.Text = "tamagochi ontwerp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pbGezondheid;
        private System.Windows.Forms.ProgressBar pbDrinken;
        private System.Windows.Forms.ProgressBar pbEten;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGezondheid;
        private System.Windows.Forms.Label lblDrinken;
        private System.Windows.Forms.Label lblEten;
        private System.Windows.Forms.Button btnDrinken;
        private System.Windows.Forms.Button btnEten;
    }
}

