
namespace WinFormsApp3
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
            this.TXTNOME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLMSG = new System.Windows.Forms.Label();
            this.BTPK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTNOME
            // 
            this.TXTNOME.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TXTNOME.Location = new System.Drawing.Point(159, 26);
            this.TXTNOME.Name = "TXTNOME";
            this.TXTNOME.Size = new System.Drawing.Size(97, 21);
            this.TXTNOME.TabIndex = 0;
            this.TXTNOME.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite seu numero\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBLMSG
            // 
            this.LBLMSG.AutoSize = true;
            this.LBLMSG.ForeColor = System.Drawing.Color.Yellow;
            this.LBLMSG.Image = ((System.Drawing.Image)(resources.GetObject("LBLMSG.Image")));
            this.LBLMSG.Location = new System.Drawing.Point(45, 169);
            this.LBLMSG.Name = "LBLMSG";
            this.LBLMSG.Size = new System.Drawing.Size(51, 13);
            this.LBLMSG.TabIndex = 2;
            this.LBLMSG.Text = "label2";
            this.LBLMSG.Visible = false;
            this.LBLMSG.Click += new System.EventHandler(this.LBLMSG_Click);
            // 
            // BTPK
            // 
            this.BTPK.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BTPK.ForeColor = System.Drawing.Color.Yellow;
            this.BTPK.Image = ((System.Drawing.Image)(resources.GetObject("BTPK.Image")));
            this.BTPK.Location = new System.Drawing.Point(159, 67);
            this.BTPK.Name = "BTPK";
            this.BTPK.Size = new System.Drawing.Size(77, 34);
            this.BTPK.TabIndex = 3;
            this.BTPK.Text = "ok\r\n";
            this.BTPK.UseVisualStyleBackColor = true;
            this.BTPK.Click += new System.EventHandler(this.BTPK_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BTPK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(352, 248);
            this.Controls.Add(this.BTPK);
            this.Controls.Add(this.LBLMSG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTNOME);
            this.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRACKER";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTNOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLMSG;
        private System.Windows.Forms.Button BTPK;
    }
}

