namespace KWZP_20_lab1
{
	partial class Form1
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnChange = new System.Windows.Forms.Button();
            this.chcBox1 = new System.Windows.Forms.CheckBox();
            this.lblText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(163, 241);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(124, 23);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "CHANGE ME";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // chcBox1
            // 
            this.chcBox1.AutoSize = true;
            this.chcBox1.Location = new System.Drawing.Point(115, 166);
            this.chcBox1.Name = "chcBox1";
            this.chcBox1.Size = new System.Drawing.Size(172, 21);
            this.chcBox1.TabIndex = 1;
            this.chcBox1.Text = "Włącz/Wyłącz przycisk";
            this.chcBox1.UseVisualStyleBackColor = true;
            this.chcBox1.CheckedChanged += new System.EventHandler(this.chcBox1_CheckedChanged);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblText.Location = new System.Drawing.Point(61, 32);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(340, 32);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Laboratoria KWZP 2020";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 293);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.chcBox1);
            this.Controls.Add(this.btnChange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.CheckBox chcBox1;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.TextBox textBox1;
	}
}

