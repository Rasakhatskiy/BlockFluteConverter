
namespace BlockFluteConverter.src.Forms
{
    partial class Form_Main
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
            this.link_deleteThis = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // link_deleteThis
            // 
            this.link_deleteThis.AutoSize = true;
            this.link_deleteThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_deleteThis.Location = new System.Drawing.Point(12, 9);
            this.link_deleteThis.Name = "link_deleteThis";
            this.link_deleteThis.Size = new System.Drawing.Size(835, 108);
            this.link_deleteThis.TabIndex = 0;
            this.link_deleteThis.TabStop = true;
            this.link_deleteThis.Text = "Здарова бандиты";
            this.link_deleteThis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_deleteThis_LinkClicked);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 126);
            this.Controls.Add(this.link_deleteThis);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_deleteThis;
    }
}