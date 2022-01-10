
namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.CAIXA = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.FRASE2 = new System.Windows.Forms.Label();
            this.OK2 = new System.Windows.Forms.Button();
            this.TEXTO = new System.Windows.Forms.Label();
            this.CAIXA2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE UM NUMERO";
            // 
            // CAIXA
            // 
            this.CAIXA.Location = new System.Drawing.Point(317, 60);
            this.CAIXA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CAIXA.Name = "CAIXA";
            this.CAIXA.Size = new System.Drawing.Size(80, 21);
            this.CAIXA.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(331, 99);
            this.OK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(58, 22);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK\r\n";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // FRASE2
            // 
            this.FRASE2.AutoSize = true;
            this.FRASE2.Location = new System.Drawing.Point(39, 195);
            this.FRASE2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FRASE2.Name = "FRASE2";
            this.FRASE2.Size = new System.Drawing.Size(48, 13);
            this.FRASE2.TabIndex = 3;
            this.FRASE2.Text = "LABEK2\r\n";
            this.FRASE2.Visible = false;
            // 
            // OK2
            // 
            this.OK2.Location = new System.Drawing.Point(39, 99);
            this.OK2.Name = "OK2";
            this.OK2.Size = new System.Drawing.Size(59, 23);
            this.OK2.TabIndex = 4;
            this.OK2.Text = "OK";
            this.OK2.UseVisualStyleBackColor = true;
            this.OK2.Click += new System.EventHandler(this.OK2_Click);
            // 
            // TEXTO
            // 
            this.TEXTO.AutoSize = true;
            this.TEXTO.Location = new System.Drawing.Point(30, 35);
            this.TEXTO.Name = "TEXTO";
            this.TEXTO.Size = new System.Drawing.Size(144, 13);
            this.TEXTO.TabIndex = 5;
            this.TEXTO.Text = "DIGITE OUTRO NJUMERO\r\n";
            // 
            // CAIXA2
            // 
            this.CAIXA2.Location = new System.Drawing.Point(39, 60);
            this.CAIXA2.Name = "CAIXA2";
            this.CAIXA2.Size = new System.Drawing.Size(75, 21);
            this.CAIXA2.TabIndex = 6;
            this.CAIXA2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(410, 265);
            this.Controls.Add(this.CAIXA2);
            this.Controls.Add(this.TEXTO);
            this.Controls.Add(this.OK2);
            this.Controls.Add(this.FRASE2);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.CAIXA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOBRO DE UM NUMERO ";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CAIXA;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label FRASE2;
        private System.Windows.Forms.Button OK2;
        private System.Windows.Forms.Label TEXTO;
        private System.Windows.Forms.TextBox CAIXA2;
    }
}

