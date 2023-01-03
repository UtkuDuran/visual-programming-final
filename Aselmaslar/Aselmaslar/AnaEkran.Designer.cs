namespace Aselmaslar
{
    partial class FrmAnaEkran
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
            this.btnTanim = new System.Windows.Forms.Button();
            this.btnPetrol = new System.Windows.Forms.Button();
            this.btnNakliye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTanim
            // 
            this.btnTanim.BackColor = System.Drawing.SystemColors.Control;
            this.btnTanim.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTanim.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTanim.Location = new System.Drawing.Point(14, 118);
            this.btnTanim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTanim.Name = "btnTanim";
            this.btnTanim.Size = new System.Drawing.Size(251, 107);
            this.btnTanim.TabIndex = 0;
            this.btnTanim.Text = "Veri Tanımlamları";
            this.btnTanim.UseVisualStyleBackColor = false;
            this.btnTanim.Click += new System.EventHandler(this.btnTanim_Click);
            // 
            // btnPetrol
            // 
            this.btnPetrol.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPetrol.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPetrol.Location = new System.Drawing.Point(273, 118);
            this.btnPetrol.Margin = new System.Windows.Forms.Padding(4);
            this.btnPetrol.Name = "btnPetrol";
            this.btnPetrol.Size = new System.Drawing.Size(251, 107);
            this.btnPetrol.TabIndex = 1;
            this.btnPetrol.Text = "Petrol İşlemleri";
            this.btnPetrol.UseVisualStyleBackColor = true;
            this.btnPetrol.Click += new System.EventHandler(this.btnPetrol_Click);
            // 
            // btnNakliye
            // 
            this.btnNakliye.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNakliye.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnNakliye.Location = new System.Drawing.Point(531, 118);
            this.btnNakliye.Margin = new System.Windows.Forms.Padding(4);
            this.btnNakliye.Name = "btnNakliye";
            this.btnNakliye.Size = new System.Drawing.Size(251, 107);
            this.btnNakliye.TabIndex = 2;
            this.btnNakliye.Text = "Nakliye İşlemleri";
            this.btnNakliye.UseVisualStyleBackColor = true;
            this.btnNakliye.Click += new System.EventHandler(this.btnNakliye_Click);
            // 
            // FrmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 380);
            this.Controls.Add(this.btnNakliye);
            this.Controls.Add(this.btnPetrol);
            this.Controls.Add(this.btnTanim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmAnaEkran";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aselmaslar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTanim;
        private System.Windows.Forms.Button btnPetrol;
        private System.Windows.Forms.Button btnNakliye;
    }
}

