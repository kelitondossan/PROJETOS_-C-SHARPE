
namespace ENTRADADADOWINDOWSFORM
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
            this.TXTNOME = new System.Windows.Forms.TextBox();
            this.BTNOK = new System.Windows.Forms.Button();
            this.LBLMSG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // TXTNOME
            // 
            resources.ApplyResources(this.TXTNOME, "TXTNOME");
            this.TXTNOME.Name = "TXTNOME";
            // 
            // BTNOK
            // 
            resources.ApplyResources(this.BTNOK, "BTNOK");
            this.BTNOK.Name = "BTNOK";
            this.BTNOK.UseVisualStyleBackColor = true;
            this.BTNOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBLMSG
            // 
            resources.ApplyResources(this.LBLMSG, "LBLMSG");
            this.LBLMSG.Name = "LBLMSG";
            this.LBLMSG.Click += new System.EventHandler(this.LBLMSG_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BTNOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.Controls.Add(this.LBLMSG);
            this.Controls.Add(this.BTNOK);
            this.Controls.Add(this.TXTNOME);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTNOME;
        private System.Windows.Forms.Button BTNOK;
        private System.Windows.Forms.Label LBLMSG;
    }
}

