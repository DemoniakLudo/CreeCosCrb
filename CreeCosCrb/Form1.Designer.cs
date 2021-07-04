namespace CreeSinCrb {
	partial class Form1 {
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent() {
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bpTest = new System.Windows.Forms.Button();
			this.grpCos1 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txbOffset1 = new System.Windows.Forms.TextBox();
			this.txbDephasage1 = new System.Windows.Forms.TextBox();
			this.txbAmplitude1 = new System.Windows.Forms.TextBox();
			this.txbPeriode1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chkEnable1 = new System.Windows.Forms.CheckBox();
			this.grpCos2 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txbOffset2 = new System.Windows.Forms.TextBox();
			this.txbDephasage2 = new System.Windows.Forms.TextBox();
			this.txbAmplitude2 = new System.Windows.Forms.TextBox();
			this.txbPeriode2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.chkEnable2 = new System.Windows.Forms.CheckBox();
			this.grpCos3 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txbOffset3 = new System.Windows.Forms.TextBox();
			this.txbDephasage3 = new System.Windows.Forms.TextBox();
			this.txbAmplitude3 = new System.Windows.Forms.TextBox();
			this.txbPeriode3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.chkEnable3 = new System.Windows.Forms.CheckBox();
			this.bpExport = new System.Windows.Forms.Button();
			this.bpRead = new System.Windows.Forms.Button();
			this.bpSave = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.txbNbPt = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.grpCos1.SuspendLayout();
			this.grpCos2.SuspendLayout();
			this.grpCos3.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(512, 512);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// bpTest
			// 
			this.bpTest.Location = new System.Drawing.Point(530, 57);
			this.bpTest.Name = "bpTest";
			this.bpTest.Size = new System.Drawing.Size(75, 23);
			this.bpTest.TabIndex = 1;
			this.bpTest.Text = "Test";
			this.bpTest.UseVisualStyleBackColor = true;
			this.bpTest.Click += new System.EventHandler(this.bpTest_Click);
			// 
			// grpCos1
			// 
			this.grpCos1.Controls.Add(this.label10);
			this.grpCos1.Controls.Add(this.label7);
			this.grpCos1.Controls.Add(this.label2);
			this.grpCos1.Controls.Add(this.txbOffset1);
			this.grpCos1.Controls.Add(this.txbDephasage1);
			this.grpCos1.Controls.Add(this.txbAmplitude1);
			this.grpCos1.Controls.Add(this.txbPeriode1);
			this.grpCos1.Controls.Add(this.label1);
			this.grpCos1.Location = new System.Drawing.Point(530, 144);
			this.grpCos1.Name = "grpCos1";
			this.grpCos1.Size = new System.Drawing.Size(160, 130);
			this.grpCos1.TabIndex = 4;
			this.grpCos1.TabStop = false;
			this.grpCos1.Text = "Cosinus 1";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 110);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "Offset";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Déphasage";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Amplitude (y)";
			// 
			// txbOffset1
			// 
			this.txbOffset1.Location = new System.Drawing.Point(78, 107);
			this.txbOffset1.Name = "txbOffset1";
			this.txbOffset1.Size = new System.Drawing.Size(74, 20);
			this.txbOffset1.TabIndex = 2;
			this.txbOffset1.Text = "100.0";
			// 
			// txbDephasage1
			// 
			this.txbDephasage1.Location = new System.Drawing.Point(78, 77);
			this.txbDephasage1.Name = "txbDephasage1";
			this.txbDephasage1.Size = new System.Drawing.Size(74, 20);
			this.txbDephasage1.TabIndex = 2;
			this.txbDephasage1.Text = "0.0";
			// 
			// txbAmplitude1
			// 
			this.txbAmplitude1.Location = new System.Drawing.Point(78, 47);
			this.txbAmplitude1.Name = "txbAmplitude1";
			this.txbAmplitude1.Size = new System.Drawing.Size(74, 20);
			this.txbAmplitude1.TabIndex = 2;
			this.txbAmplitude1.Text = "100.0";
			// 
			// txbPeriode1
			// 
			this.txbPeriode1.Location = new System.Drawing.Point(78, 17);
			this.txbPeriode1.Name = "txbPeriode1";
			this.txbPeriode1.Size = new System.Drawing.Size(74, 20);
			this.txbPeriode1.TabIndex = 2;
			this.txbPeriode1.Text = "2.0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Période (180*)";
			// 
			// chkEnable1
			// 
			this.chkEnable1.AutoSize = true;
			this.chkEnable1.Location = new System.Drawing.Point(695, 177);
			this.chkEnable1.Name = "chkEnable1";
			this.chkEnable1.Size = new System.Drawing.Size(56, 17);
			this.chkEnable1.TabIndex = 0;
			this.chkEnable1.Text = "Activé";
			this.chkEnable1.UseVisualStyleBackColor = true;
			this.chkEnable1.CheckedChanged += new System.EventHandler(this.chkEnable1_CheckedChanged);
			// 
			// grpCos2
			// 
			this.grpCos2.Controls.Add(this.label11);
			this.grpCos2.Controls.Add(this.label8);
			this.grpCos2.Controls.Add(this.label3);
			this.grpCos2.Controls.Add(this.txbOffset2);
			this.grpCos2.Controls.Add(this.txbDephasage2);
			this.grpCos2.Controls.Add(this.txbAmplitude2);
			this.grpCos2.Controls.Add(this.txbPeriode2);
			this.grpCos2.Controls.Add(this.label4);
			this.grpCos2.Location = new System.Drawing.Point(530, 282);
			this.grpCos2.Name = "grpCos2";
			this.grpCos2.Size = new System.Drawing.Size(160, 130);
			this.grpCos2.TabIndex = 4;
			this.grpCos2.TabStop = false;
			this.grpCos2.Text = "Cosinus 1";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 114);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(35, 13);
			this.label11.TabIndex = 4;
			this.label11.Text = "Offset";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 84);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Déphasage";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Amplitude (y)";
			// 
			// txbOffset2
			// 
			this.txbOffset2.Location = new System.Drawing.Point(78, 107);
			this.txbOffset2.Name = "txbOffset2";
			this.txbOffset2.Size = new System.Drawing.Size(74, 20);
			this.txbOffset2.TabIndex = 2;
			this.txbOffset2.Text = "0.0";
			// 
			// txbDephasage2
			// 
			this.txbDephasage2.Location = new System.Drawing.Point(78, 77);
			this.txbDephasage2.Name = "txbDephasage2";
			this.txbDephasage2.Size = new System.Drawing.Size(74, 20);
			this.txbDephasage2.TabIndex = 2;
			this.txbDephasage2.Text = "0.0";
			// 
			// txbAmplitude2
			// 
			this.txbAmplitude2.Location = new System.Drawing.Point(78, 47);
			this.txbAmplitude2.Name = "txbAmplitude2";
			this.txbAmplitude2.Size = new System.Drawing.Size(74, 20);
			this.txbAmplitude2.TabIndex = 2;
			this.txbAmplitude2.Text = "200.0";
			// 
			// txbPeriode2
			// 
			this.txbPeriode2.Location = new System.Drawing.Point(78, 17);
			this.txbPeriode2.Name = "txbPeriode2";
			this.txbPeriode2.Size = new System.Drawing.Size(74, 20);
			this.txbPeriode2.TabIndex = 2;
			this.txbPeriode2.Text = "2.0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Période 180*)";
			// 
			// chkEnable2
			// 
			this.chkEnable2.AutoSize = true;
			this.chkEnable2.Location = new System.Drawing.Point(695, 315);
			this.chkEnable2.Name = "chkEnable2";
			this.chkEnable2.Size = new System.Drawing.Size(56, 17);
			this.chkEnable2.TabIndex = 0;
			this.chkEnable2.Text = "Activé";
			this.chkEnable2.UseVisualStyleBackColor = true;
			this.chkEnable2.CheckedChanged += new System.EventHandler(this.chkEnable2_CheckedChanged);
			// 
			// grpCos3
			// 
			this.grpCos3.Controls.Add(this.label12);
			this.grpCos3.Controls.Add(this.label9);
			this.grpCos3.Controls.Add(this.label5);
			this.grpCos3.Controls.Add(this.txbOffset3);
			this.grpCos3.Controls.Add(this.txbDephasage3);
			this.grpCos3.Controls.Add(this.txbAmplitude3);
			this.grpCos3.Controls.Add(this.txbPeriode3);
			this.grpCos3.Controls.Add(this.label6);
			this.grpCos3.Location = new System.Drawing.Point(530, 420);
			this.grpCos3.Name = "grpCos3";
			this.grpCos3.Size = new System.Drawing.Size(160, 130);
			this.grpCos3.TabIndex = 4;
			this.grpCos3.TabStop = false;
			this.grpCos3.Text = "Cosinus 1";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 114);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(35, 13);
			this.label12.TabIndex = 4;
			this.label12.Text = "Offset";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 84);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 13);
			this.label9.TabIndex = 4;
			this.label9.Text = "Déphasage";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Amplitude (y)";
			// 
			// txbOffset3
			// 
			this.txbOffset3.Location = new System.Drawing.Point(78, 107);
			this.txbOffset3.Name = "txbOffset3";
			this.txbOffset3.Size = new System.Drawing.Size(74, 20);
			this.txbOffset3.TabIndex = 2;
			this.txbOffset3.Text = "0.0";
			// 
			// txbDephasage3
			// 
			this.txbDephasage3.Location = new System.Drawing.Point(78, 77);
			this.txbDephasage3.Name = "txbDephasage3";
			this.txbDephasage3.Size = new System.Drawing.Size(74, 20);
			this.txbDephasage3.TabIndex = 2;
			this.txbDephasage3.Text = "0.0";
			// 
			// txbAmplitude3
			// 
			this.txbAmplitude3.Location = new System.Drawing.Point(78, 47);
			this.txbAmplitude3.Name = "txbAmplitude3";
			this.txbAmplitude3.Size = new System.Drawing.Size(74, 20);
			this.txbAmplitude3.TabIndex = 2;
			this.txbAmplitude3.Text = "200.0";
			// 
			// txbPeriode3
			// 
			this.txbPeriode3.Location = new System.Drawing.Point(78, 17);
			this.txbPeriode3.Name = "txbPeriode3";
			this.txbPeriode3.Size = new System.Drawing.Size(74, 20);
			this.txbPeriode3.TabIndex = 2;
			this.txbPeriode3.Text = "2.0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Période (180)";
			// 
			// chkEnable3
			// 
			this.chkEnable3.AutoSize = true;
			this.chkEnable3.Location = new System.Drawing.Point(695, 457);
			this.chkEnable3.Name = "chkEnable3";
			this.chkEnable3.Size = new System.Drawing.Size(56, 17);
			this.chkEnable3.TabIndex = 0;
			this.chkEnable3.Text = "Activé";
			this.chkEnable3.UseVisualStyleBackColor = true;
			this.chkEnable3.CheckedChanged += new System.EventHandler(this.chkEnable3_CheckedChanged);
			// 
			// bpExport
			// 
			this.bpExport.Location = new System.Drawing.Point(616, 57);
			this.bpExport.Name = "bpExport";
			this.bpExport.Size = new System.Drawing.Size(75, 23);
			this.bpExport.TabIndex = 1;
			this.bpExport.Text = "Export asm";
			this.bpExport.UseVisualStyleBackColor = true;
			this.bpExport.Click += new System.EventHandler(this.bpExport_Click);
			// 
			// bpRead
			// 
			this.bpRead.Location = new System.Drawing.Point(530, 12);
			this.bpRead.Name = "bpRead";
			this.bpRead.Size = new System.Drawing.Size(75, 23);
			this.bpRead.TabIndex = 5;
			this.bpRead.Text = "Lecture";
			this.bpRead.UseVisualStyleBackColor = true;
			this.bpRead.Click += new System.EventHandler(this.bpRead_Click);
			// 
			// bpSave
			// 
			this.bpSave.Location = new System.Drawing.Point(616, 12);
			this.bpSave.Name = "bpSave";
			this.bpSave.Size = new System.Drawing.Size(75, 23);
			this.bpSave.TabIndex = 5;
			this.bpSave.Text = "Sauvegarde";
			this.bpSave.UseVisualStyleBackColor = true;
			this.bpSave.Click += new System.EventHandler(this.bpSave_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(539, 116);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(110, 13);
			this.label13.TabIndex = 6;
			this.label13.Text = "Nombre de valeurs (x)";
			// 
			// txbNbPt
			// 
			this.txbNbPt.Location = new System.Drawing.Point(655, 113);
			this.txbNbPt.Name = "txbNbPt";
			this.txbNbPt.Size = new System.Drawing.Size(67, 20);
			this.txbNbPt.TabIndex = 7;
			this.txbNbPt.Text = "256";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(754, 556);
			this.Controls.Add(this.txbNbPt);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.bpSave);
			this.Controls.Add(this.bpRead);
			this.Controls.Add(this.grpCos3);
			this.Controls.Add(this.grpCos2);
			this.Controls.Add(this.grpCos1);
			this.Controls.Add(this.chkEnable3);
			this.Controls.Add(this.chkEnable2);
			this.Controls.Add(this.chkEnable1);
			this.Controls.Add(this.bpExport);
			this.Controls.Add(this.bpTest);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "CreeCosTab";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.grpCos1.ResumeLayout(false);
			this.grpCos1.PerformLayout();
			this.grpCos2.ResumeLayout(false);
			this.grpCos2.PerformLayout();
			this.grpCos3.ResumeLayout(false);
			this.grpCos3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button bpTest;
		private System.Windows.Forms.GroupBox grpCos1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbAmplitude1;
		private System.Windows.Forms.TextBox txbPeriode1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkEnable1;
		private System.Windows.Forms.GroupBox grpCos2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txbAmplitude2;
		private System.Windows.Forms.TextBox txbPeriode2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chkEnable2;
		private System.Windows.Forms.GroupBox grpCos3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txbAmplitude3;
		private System.Windows.Forms.TextBox txbPeriode3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chkEnable3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txbDephasage1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txbDephasage2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txbDephasage3;
		private System.Windows.Forms.Button bpExport;
		private System.Windows.Forms.Button bpRead;
		private System.Windows.Forms.Button bpSave;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txbOffset1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txbOffset2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txbOffset3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txbNbPt;
	}
}

