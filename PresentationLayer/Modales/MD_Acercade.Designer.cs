namespace PresentationLayer.Modales
{
    partial class MD_Acercade
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
            this.richTextBoxAcercaDe = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxAcercaDe
            // 
            this.richTextBoxAcercaDe.Location = new System.Drawing.Point(51, 40);
            this.richTextBoxAcercaDe.Name = "richTextBoxAcercaDe";
            this.richTextBoxAcercaDe.ReadOnly = true;
            this.richTextBoxAcercaDe.Size = new System.Drawing.Size(1099, 572);
            this.richTextBoxAcercaDe.TabIndex = 54;
            this.richTextBoxAcercaDe.Text = "";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1149, 621);
            this.label10.TabIndex = 52;
            this.label10.Text = "Acerca de";
            // 
            // MD_Acercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 639);
            this.Controls.Add(this.richTextBoxAcercaDe);
            this.Controls.Add(this.label10);
            this.Name = "MD_Acercade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MD_Acercade";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxAcercaDe;
        private System.Windows.Forms.Label label10;
    }
}