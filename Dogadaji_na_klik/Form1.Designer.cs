namespace Dogadaji_na_klik
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
            this.button_da = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_da
            // 
            this.button_da.Location = new System.Drawing.Point(559, 102);
            this.button_da.Name = "button_da";
            this.button_da.Size = new System.Drawing.Size(75, 23);
            this.button_da.TabIndex = 0;
            this.button_da.Text = "Prihvaćam";
            this.button_da.UseVisualStyleBackColor = true;
            this.button_da.Click += new System.EventHandler(this.button_da_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prihvaćate li ponudu vlade?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_ne
            // 
            this.button_ne.Location = new System.Drawing.Point(337, 102);
            this.button_ne.Name = "button_ne";
            this.button_ne.Size = new System.Drawing.Size(107, 23);
            this.button_ne.TabIndex = 2;
            this.button_ne.Text = "Ne prihvaćam";
            this.button_ne.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 351);
            this.Controls.Add(this.button_ne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_da);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_da;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ne;
    }
}

