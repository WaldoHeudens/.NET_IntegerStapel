namespace IntegerStapel
{
    partial class FormStapel
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
            this.udVoegToe = new System.Windows.Forms.NumericUpDown();
            this.btHaalAf = new System.Windows.Forms.Button();
            this.tbShowContent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.udVoegToe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voeg toe";
            // 
            // udVoegToe
            // 
            this.udVoegToe.Location = new System.Drawing.Point(253, 77);
            this.udVoegToe.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.udVoegToe.Name = "udVoegToe";
            this.udVoegToe.Size = new System.Drawing.Size(120, 23);
            this.udVoegToe.TabIndex = 1;
            this.udVoegToe.ValueChanged += new System.EventHandler(this.udVoegToe_ValueChanged);
            // 
            // btHaalAf
            // 
            this.btHaalAf.Location = new System.Drawing.Point(253, 136);
            this.btHaalAf.Name = "btHaalAf";
            this.btHaalAf.Size = new System.Drawing.Size(120, 39);
            this.btHaalAf.TabIndex = 2;
            this.btHaalAf.Text = "Haal Af";
            this.btHaalAf.UseVisualStyleBackColor = true;
            this.btHaalAf.Click += new System.EventHandler(this.btHaalAf_Click);
            // 
            // tbShowContent
            // 
            this.tbShowContent.Enabled = false;
            this.tbShowContent.Location = new System.Drawing.Point(6, 226);
            this.tbShowContent.Name = "tbShowContent";
            this.tbShowContent.Size = new System.Drawing.Size(791, 23);
            this.tbShowContent.TabIndex = 3;
            // 
            // FormStapel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 255);
            this.Controls.Add(this.tbShowContent);
            this.Controls.Add(this.btHaalAf);
            this.Controls.Add(this.udVoegToe);
            this.Controls.Add(this.label1);
            this.Name = "FormStapel";
            this.Text = "Stapel van integers";
            ((System.ComponentModel.ISupportInitialize)(this.udVoegToe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udVoegToe;
        private System.Windows.Forms.Button btHaalAf;
        private System.Windows.Forms.TextBox tbShowContent;
    }
}