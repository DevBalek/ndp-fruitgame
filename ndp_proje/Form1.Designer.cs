
namespace ndp_proje
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelVitA = new System.Windows.Forms.Label();
            this.labelVitC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPuree = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.countDown = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.solidFruit_btn = new System.Windows.Forms.Button();
            this.squeezableFruit_btn = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelnewA = new System.Windows.Forms.Label();
            this.labelnewC = new System.Windows.Forms.Label();
            this.labelnewPure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(221, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam A vitamini (iu):";
            // 
            // labelVitA
            // 
            this.labelVitA.AutoSize = true;
            this.labelVitA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVitA.Location = new System.Drawing.Point(474, 358);
            this.labelVitA.Name = "labelVitA";
            this.labelVitA.Size = new System.Drawing.Size(77, 25);
            this.labelVitA.TabIndex = 1;
            this.labelVitA.Text = " 180 iu";
            // 
            // labelVitC
            // 
            this.labelVitC.AutoSize = true;
            this.labelVitC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVitC.Location = new System.Drawing.Point(474, 392);
            this.labelVitC.Name = "labelVitC";
            this.labelVitC.Size = new System.Drawing.Size(89, 25);
            this.labelVitC.TabIndex = 3;
            this.labelVitC.Text = " 180 mg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(214, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Toplam C vitamini (mg):";
            // 
            // labelPuree
            // 
            this.labelPuree.AutoSize = true;
            this.labelPuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPuree.Location = new System.Drawing.Point(471, 449);
            this.labelPuree.Name = "labelPuree";
            this.labelPuree.Size = new System.Drawing.Size(89, 25);
            this.labelPuree.TabIndex = 7;
            this.labelPuree.Text = " 180 mg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(262, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Toplam Püre (g):";
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start_btn.Location = new System.Drawing.Point(72, 28);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(150, 44);
            this.start_btn.TabIndex = 9;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // countDown
            // 
            this.countDown.AutoSize = true;
            this.countDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDown.Location = new System.Drawing.Point(767, 28);
            this.countDown.Name = "countDown";
            this.countDown.Size = new System.Drawing.Size(55, 39);
            this.countDown.TabIndex = 10;
            this.countDown.Text = "60";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(643, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 39);
            this.label10.TabIndex = 11;
            this.label10.Text = "Süre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(287, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // solidFruit_btn
            // 
            this.solidFruit_btn.Enabled = false;
            this.solidFruit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.solidFruit_btn.Location = new System.Drawing.Point(641, 140);
            this.solidFruit_btn.Name = "solidFruit_btn";
            this.solidFruit_btn.Size = new System.Drawing.Size(178, 127);
            this.solidFruit_btn.TabIndex = 13;
            this.solidFruit_btn.Text = "KATI MEYVE SIKACAĞI";
            this.solidFruit_btn.UseVisualStyleBackColor = true;
            this.solidFruit_btn.Click += new System.EventHandler(this.solidFruit_btn_Click);
            // 
            // squeezableFruit_btn
            // 
            this.squeezableFruit_btn.Enabled = false;
            this.squeezableFruit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.squeezableFruit_btn.Location = new System.Drawing.Point(59, 140);
            this.squeezableFruit_btn.Name = "squeezableFruit_btn";
            this.squeezableFruit_btn.Size = new System.Drawing.Size(178, 127);
            this.squeezableFruit_btn.TabIndex = 14;
            this.squeezableFruit_btn.Text = "NARENCİYE SIKACAĞI";
            this.squeezableFruit_btn.UseVisualStyleBackColor = true;
            this.squeezableFruit_btn.Click += new System.EventHandler(this.squeezableFruit_btn_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelName.Location = new System.Drawing.Point(373, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(122, 25);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Meyve Adı";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelnewA
            // 
            this.labelnewA.AutoSize = true;
            this.labelnewA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelnewA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelnewA.Location = new System.Drawing.Point(614, 358);
            this.labelnewA.Name = "labelnewA";
            this.labelnewA.Size = new System.Drawing.Size(18, 25);
            this.labelnewA.TabIndex = 15;
            this.labelnewA.Text = " ";
            // 
            // labelnewC
            // 
            this.labelnewC.AutoSize = true;
            this.labelnewC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelnewC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelnewC.Location = new System.Drawing.Point(602, 392);
            this.labelnewC.Name = "labelnewC";
            this.labelnewC.Size = new System.Drawing.Size(18, 25);
            this.labelnewC.TabIndex = 16;
            this.labelnewC.Text = " ";
            // 
            // labelnewPure
            // 
            this.labelnewPure.AutoSize = true;
            this.labelnewPure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelnewPure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelnewPure.Location = new System.Drawing.Point(602, 449);
            this.labelnewPure.Name = "labelnewPure";
            this.labelnewPure.Size = new System.Drawing.Size(18, 25);
            this.labelnewPure.TabIndex = 17;
            this.labelnewPure.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 549);
            this.Controls.Add(this.labelnewPure);
            this.Controls.Add(this.labelnewC);
            this.Controls.Add(this.labelnewA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPuree);
            this.Controls.Add(this.squeezableFruit_btn);
            this.Controls.Add(this.solidFruit_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelVitA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelVitC);
            this.Controls.Add(this.countDown);
            this.Controls.Add(this.start_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button start_btn;
        public System.Windows.Forms.Label countDown;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button solidFruit_btn;
        public System.Windows.Forms.Button squeezableFruit_btn;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label labelVitA;
        public System.Windows.Forms.Label labelVitC;
        public System.Windows.Forms.Label labelPuree;
        public System.Windows.Forms.Label labelnewA;
        public System.Windows.Forms.Label labelnewC;
        public System.Windows.Forms.Label labelnewPure;
    }
}

