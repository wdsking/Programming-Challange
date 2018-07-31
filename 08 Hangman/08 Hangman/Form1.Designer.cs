namespace _08_Hangman
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.categoryLabel = new System.Windows.Forms.Label();
			this.picture = new System.Windows.Forms.PictureBox();
			this.guessTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.missedLetters = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
			this.SuspendLayout();
			// 
			// categoryLabel
			// 
			this.categoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.categoryLabel.AutoSize = true;
			this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.categoryLabel.Location = new System.Drawing.Point(450, 9);
			this.categoryLabel.Name = "categoryLabel";
			this.categoryLabel.Size = new System.Drawing.Size(115, 24);
			this.categoryLabel.TabIndex = 0;
			this.categoryLabel.Text = "CATEGORY";
			// 
			// picture
			// 
			this.picture.Image = global::_08_Hangman.Properties.Resources.Hangman0;
			this.picture.Location = new System.Drawing.Point(12, 40);
			this.picture.Name = "picture";
			this.picture.Size = new System.Drawing.Size(214, 196);
			this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picture.TabIndex = 1;
			this.picture.TabStop = false;
			// 
			// guessTextBox
			// 
			this.guessTextBox.Location = new System.Drawing.Point(12, 304);
			this.guessTextBox.Name = "guessTextBox";
			this.guessTextBox.Size = new System.Drawing.Size(776, 20);
			this.guessTextBox.TabIndex = 2;
			this.guessTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guessTextBox_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 268);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(254, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Write letter or sequence here";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(350, 415);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Make guess";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(12, 327);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Missed letters";
			// 
			// missedLetters
			// 
			this.missedLetters.AutoSize = true;
			this.missedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.missedLetters.Location = new System.Drawing.Point(12, 362);
			this.missedLetters.Name = "missedLetters";
			this.missedLetters.Size = new System.Drawing.Size(0, 20);
			this.missedLetters.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.missedLetters);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guessTextBox);
			this.Controls.Add(this.picture);
			this.Controls.Add(this.categoryLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Hangman";
			((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label categoryLabel;
		private System.Windows.Forms.PictureBox picture;
		private System.Windows.Forms.TextBox guessTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label missedLetters;
	}
}

