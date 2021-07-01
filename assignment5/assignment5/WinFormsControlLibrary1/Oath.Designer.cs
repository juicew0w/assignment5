
namespace AppControlLibrary
{
    partial class Oath
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UnderstandLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UnderstandLabel
            // 
            this.UnderstandLabel.AutoSize = true;
            this.UnderstandLabel.BackColor = System.Drawing.Color.Transparent;
            this.UnderstandLabel.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnderstandLabel.ForeColor = System.Drawing.Color.Blue;
            this.UnderstandLabel.Location = new System.Drawing.Point(13, 12);
            this.UnderstandLabel.Name = "UnderstandLabel";
            this.UnderstandLabel.Size = new System.Drawing.Size(557, 69);
            this.UnderstandLabel.TabIndex = 0;
            this.UnderstandLabel.Text = "I understand that this is a group project.\nIt is in my best interest to participa" +
    "te in writing the \nhomework and study all the code from the homework.";
            this.UnderstandLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Oath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.UnderstandLabel);
            this.MinimumSize = new System.Drawing.Size(578, 96);
            this.Name = "Oath";
            this.Size = new System.Drawing.Size(578, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UnderstandLabel;
    }
}
