
namespace AutoService
{
    partial class IslemEkleForm
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
            this.cmbIslemler = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstYapilacakislemler = new System.Windows.Forms.ListBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.grpbYapilacakislemler = new System.Windows.Forms.GroupBox();
            this.grpbYapilacakislemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbIslemler
            // 
            this.cmbIslemler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemler.FormattingEnabled = true;
            this.cmbIslemler.Location = new System.Drawing.Point(23, 39);
            this.cmbIslemler.Name = "cmbIslemler";
            this.cmbIslemler.Size = new System.Drawing.Size(245, 24);
            this.cmbIslemler.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(274, 36);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(89, 30);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // lstYapilacakislemler
            // 
            this.lstYapilacakislemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstYapilacakislemler.FormattingEnabled = true;
            this.lstYapilacakislemler.ItemHeight = 16;
            this.lstYapilacakislemler.Location = new System.Drawing.Point(23, 88);
            this.lstYapilacakislemler.Name = "lstYapilacakislemler";
            this.lstYapilacakislemler.Size = new System.Drawing.Size(245, 196);
            this.lstYapilacakislemler.TabIndex = 2;
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Black;
            this.btnCikis.Location = new System.Drawing.Point(170, 358);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 25);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // grpbYapilacakislemler
            // 
            this.grpbYapilacakislemler.BackColor = System.Drawing.Color.Transparent;
            this.grpbYapilacakislemler.Controls.Add(this.cmbIslemler);
            this.grpbYapilacakislemler.Controls.Add(this.btnEkle);
            this.grpbYapilacakislemler.Controls.Add(this.lstYapilacakislemler);
            this.grpbYapilacakislemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbYapilacakislemler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpbYapilacakislemler.Location = new System.Drawing.Point(23, 22);
            this.grpbYapilacakislemler.Name = "grpbYapilacakislemler";
            this.grpbYapilacakislemler.Size = new System.Drawing.Size(373, 330);
            this.grpbYapilacakislemler.TabIndex = 4;
            this.grpbYapilacakislemler.TabStop = false;
            this.grpbYapilacakislemler.Text = "Yapılacak İşlemler";
            // 
            // IslemEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoService.Properties.Resources.arkaplan2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 389);
            this.Controls.Add(this.grpbYapilacakislemler);
            this.Controls.Add(this.btnCikis);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IslemEkleForm";
            this.Text = "IslemEkleForm";
            this.Load += new System.EventHandler(this.IslemEkleForm_Load);
            this.grpbYapilacakislemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIslemler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstYapilacakislemler;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.GroupBox grpbYapilacakislemler;
    }
}