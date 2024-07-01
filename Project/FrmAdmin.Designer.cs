namespace Project
{
    partial class FrmWelcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncontinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(691, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selamat datang di In-Flight Entertaintment kami. \r\nKami berharap anda dapat menja" +
    "lani penerbangan ini dengan nyaman.";
            // 
            // btncontinue
            // 
            this.btncontinue.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btncontinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontinue.ForeColor = System.Drawing.Color.White;
            this.btncontinue.Location = new System.Drawing.Point(633, 396);
            this.btncontinue.Name = "btncontinue";
            this.btncontinue.Size = new System.Drawing.Size(155, 42);
            this.btncontinue.TabIndex = 2;
            this.btncontinue.Text = "Lanjutkan";
            this.btncontinue.UseVisualStyleBackColor = false;
            this.btncontinue.Click += new System.EventHandler(this.btncontinue_Click);
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Project.Properties.Resources.istockphoto_155380716_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncontinue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncontinue;
    }
}