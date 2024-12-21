namespace Kelime_Ogren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblDogruS = new System.Windows.Forms.Label();
            this.LblCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblYanlisS = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // TxtIng
            // 
            this.TxtIng.Location = new System.Drawing.Point(99, 22);
            this.TxtIng.Name = "TxtIng";
            this.TxtIng.Size = new System.Drawing.Size(190, 26);
            this.TxtIng.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türkçe:";
            // 
            // TxtTr
            // 
            this.TxtTr.Location = new System.Drawing.Point(99, 54);
            this.TxtTr.Name = "TxtTr";
            this.TxtTr.Size = new System.Drawing.Size(190, 26);
            this.TxtTr.TabIndex = 1;
            this.TxtTr.TextChanged += new System.EventHandler(this.TxtTr_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre:";
            // 
            // LblSure
            // 
            this.LblSure.AutoSize = true;
            this.LblSure.Location = new System.Drawing.Point(482, 6);
            this.LblSure.Name = "LblSure";
            this.LblSure.Size = new System.Drawing.Size(27, 18);
            this.LblSure.TabIndex = 5;
            this.LblSure.Text = "90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Doğru:";
            // 
            // LblDogruS
            // 
            this.LblDogruS.AutoSize = true;
            this.LblDogruS.Location = new System.Drawing.Point(433, 38);
            this.LblDogruS.Name = "LblDogruS";
            this.LblDogruS.Size = new System.Drawing.Size(18, 18);
            this.LblDogruS.TabIndex = 7;
            this.LblDogruS.Text = "0";
            // 
            // LblCevap
            // 
            this.LblCevap.AutoSize = true;
            this.LblCevap.Location = new System.Drawing.Point(303, 87);
            this.LblCevap.Name = "LblCevap";
            this.LblCevap.Size = new System.Drawing.Size(49, 18);
            this.LblCevap.TabIndex = 8;
            this.LblCevap.Text = "cevap";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblYanlisS
            // 
            this.LblYanlisS.AutoSize = true;
            this.LblYanlisS.Location = new System.Drawing.Point(433, 62);
            this.LblYanlisS.Name = "LblYanlisS";
            this.LblYanlisS.Size = new System.Drawing.Size(18, 18);
            this.LblYanlisS.TabIndex = 12;
            this.LblYanlisS.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Yanlış:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(126, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 36);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(516, 134);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblYanlisS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblCevap);
            this.Controls.Add(this.LblDogruS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIng);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblDogruS;
        private System.Windows.Forms.Label LblCevap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblYanlisS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

