
namespace Game
{
    partial class NextLevelForm
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
            this.GoNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 128);
            this.label1.TabIndex = 0;
            this.label1.Text = "You just finished Level 1 \r\n              congrat";
            // 
            // GoNext
            // 
            this.GoNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoNext.Location = new System.Drawing.Point(464, 318);
            this.GoNext.Name = "GoNext";
            this.GoNext.Size = new System.Drawing.Size(298, 78);
            this.GoNext.TabIndex = 1;
            this.GoNext.Text = "Continue";
            this.GoNext.UseVisualStyleBackColor = true;
            this.GoNext.Click += new System.EventHandler(this.GoNext_Click);
            // 
            // NextLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoNext);
            this.Controls.Add(this.label1);
            this.Name = "NextLevelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NextLevelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GoNext;
    }
}