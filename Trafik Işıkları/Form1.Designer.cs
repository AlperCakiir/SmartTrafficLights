namespace Trafik_Işıkları
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
            this.btnKırmızı = new System.Windows.Forms.Button();
            this.btnSarı = new System.Windows.Forms.Button();
            this.btnYesil = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnKırmızı
            // 
            this.btnKırmızı.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnKırmızı.Location = new System.Drawing.Point(201, 12);
            this.btnKırmızı.Name = "btnKırmızı";
            this.btnKırmızı.Size = new System.Drawing.Size(106, 87);
            this.btnKırmızı.TabIndex = 0;
            this.btnKırmızı.UseVisualStyleBackColor = true;
            // 
            // btnSarı
            // 
            this.btnSarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnSarı.Location = new System.Drawing.Point(201, 153);
            this.btnSarı.Name = "btnSarı";
            this.btnSarı.Size = new System.Drawing.Size(106, 87);
            this.btnSarı.TabIndex = 1;
            this.btnSarı.UseVisualStyleBackColor = true;
            // 
            // btnYesil
            // 
            this.btnYesil.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnYesil.Location = new System.Drawing.Point(201, 271);
            this.btnYesil.Name = "btnYesil";
            this.btnYesil.Size = new System.Drawing.Size(106, 87);
            this.btnYesil.TabIndex = 2;
            this.btnYesil.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 410);
            this.Controls.Add(this.btnYesil);
            this.Controls.Add(this.btnSarı);
            this.Controls.Add(this.btnKırmızı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKırmızı;
        private System.Windows.Forms.Button btnSarı;
        private System.Windows.Forms.Button btnYesil;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer1;
    }
}

