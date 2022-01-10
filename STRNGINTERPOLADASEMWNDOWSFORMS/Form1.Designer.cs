
namespace STRNGINTERPOLADASEMWNDOWSFORMS
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
            this.BTMOK = new System.Windows.Forms.Button();
            this.LBLMSG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTMOK
            // 
            this.BTMOK.Location = new System.Drawing.Point(73, 111);
            this.BTMOK.Name = "BTMOK";
            this.BTMOK.Size = new System.Drawing.Size(73, 26);
            this.BTMOK.TabIndex = 0;
            this.BTMOK.Text = "button1";
            this.BTMOK.UseVisualStyleBackColor = true;
            this.BTMOK.Click += new System.EventHandler(this.BTMOK_Click);
            // 
            // LBLMSG
            // 
            this.LBLMSG.AutoSize = true;
            this.LBLMSG.Location = new System.Drawing.Point(58, 32);
            this.LBLMSG.Name = "LBLMSG";
            this.LBLMSG.Size = new System.Drawing.Size(35, 13);
            this.LBLMSG.TabIndex = 1;
            this.LBLMSG.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 211);
            this.Controls.Add(this.LBLMSG);
            this.Controls.Add(this.BTMOK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTMOK;
        private System.Windows.Forms.Label LBLMSG;
    }
}

