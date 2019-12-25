namespace CRM365PublishCustomizations
{
    partial class FrmPublish
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
            this.BtnPublish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPublish
            // 
            this.BtnPublish.Location = new System.Drawing.Point(12, 12);
            this.BtnPublish.Name = "BtnPublish";
            this.BtnPublish.Size = new System.Drawing.Size(262, 23);
            this.BtnPublish.TabIndex = 0;
            this.BtnPublish.Text = "Publish";
            this.BtnPublish.UseVisualStyleBackColor = true;
            this.BtnPublish.Click += new System.EventHandler(this.BtnPublish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 41);
            this.Controls.Add(this.BtnPublish);
            this.Name = "Form1";
            this.Text = "Publish CRM 365 Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPublish;
    }
}

