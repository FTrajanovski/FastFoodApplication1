namespace FastFoodResturante
{
    partial class frm_avslut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_avslut));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Avsluta = new System.Windows.Forms.Button();
            this.lbl_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "We hope that you are satisfied with our service,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Our goal is to deliver quality products at a low cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Best regards Grupp 1";
            // 
            // Avsluta
            // 
            this.Avsluta.Location = new System.Drawing.Point(676, 349);
            this.Avsluta.Name = "Avsluta";
            this.Avsluta.Size = new System.Drawing.Size(112, 34);
            this.Avsluta.TabIndex = 3;
            this.Avsluta.Text = "Exit";
            this.Avsluta.UseVisualStyleBackColor = true;
            this.Avsluta.Click += new System.EventHandler(this.Avsluta_Click);
            // 
            // lbl_label
            // 
            this.lbl_label.AutoSize = true;
            this.lbl_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_label.Location = new System.Drawing.Point(219, 99);
            this.lbl_label.Name = "lbl_label";
            this.lbl_label.Size = new System.Drawing.Size(347, 30);
            this.lbl_label.TabIndex = 5;
            this.lbl_label.Text = "Thank you for shopping with us!";
            this.lbl_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(430, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "To achieve the highest possible customer satisfaction";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // frm_avslut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_label);
            this.Controls.Add(this.Avsluta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_avslut";
            this.Text = "Avslut";
            this.Load += new System.EventHandler(this.Avslut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button Avsluta;
        private Label lbl_label;
        private Label label5;
        private Button button1;
        private PictureBox pictureBox2;
    }
}