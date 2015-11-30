namespace CherryQuestProject
{
    partial class frmGameField
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
            this.exiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exiButton
            // 
            this.exiButton.Location = new System.Drawing.Point(1011, 12);
            this.exiButton.Name = "exiButton";
            this.exiButton.Size = new System.Drawing.Size(75, 23);
            this.exiButton.TabIndex = 0;
            this.exiButton.Text = "Exit";
            this.exiButton.UseVisualStyleBackColor = true;
            this.exiButton.Click += new System.EventHandler(this.exiButton_Click);
            // 
            // frmGameField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 384);
            this.Controls.Add(this.exiButton);
            this.Name = "frmGameField";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exiButton;
    }
}

