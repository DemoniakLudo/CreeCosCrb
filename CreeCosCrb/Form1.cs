using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CreeSinCrb {
	public partial class Form1 : Form {
		private Graphics g;
		private ParamCrb param = new ParamCrb();
		private enum ModeData { Draw, Export };
		public Form1() {
			InitializeComponent();
			pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			pictureBox1.Refresh();
			g = Graphics.FromImage(pictureBox1.Image);
			Cls();
			chkEnable1.Checked = true;
			chkEnable2.Checked = chkEnable3.Checked = false;
			grpCos1.Enabled = true;
			grpCos2.Enabled = grpCos3.Enabled = false;
		}

		private void Cls() {
			g.Clear(Color.FromArgb(0, 0, 128));
			pictureBox1.Refresh();
		}

		static public void GenereDatas(StreamWriter sw, byte[] tabByte, int length, int nbOctetsLigne, int ligneSepa = 0, string labelSepa = null) {
			string line = "\tDB\t";
			int nbOctets = 0, nbLigne = 0, indiceLabel = 0;
			if (labelSepa != null) {
				sw.WriteLine(labelSepa + indiceLabel.ToString("00"));
				indiceLabel++;
			}
			for (int i = 0; i < length; i++) {
				line += "#" + tabByte[i].ToString("X2") + ",";
				if (++nbOctets >= nbOctetsLigne) {
					sw.WriteLine(line.Substring(0, line.Length - 1));
					line = "\tDB\t";
					nbOctets = 0;
					if (i < length - 1 && ++nbLigne >= ligneSepa && ligneSepa > 0) {
						nbLigne = 0;
						if (labelSepa != null) {
							sw.WriteLine(labelSepa + indiceLabel.ToString("00"));
							indiceLabel++;
						}
						else
							line += "\r\n";
					}
				}
			}
			if (nbOctets > 0)
				sw.WriteLine(line.Substring(0, line.Length - 1));

			sw.WriteLine("; Taille totale " + length.ToString() + " octets");
		}

		private void TestCrb(ModeData md, string fileName = null) {
			string line = "\tDB\t";
			int nbOctets = 0, nbOctetsLigne = 16;
			StreamWriter sw = null;
			if (md == ModeData.Export)
				sw = File.CreateText(fileName);

			Pen p = new Pen(Color.FromArgb(255, 255, 255));
			int inc = 512 / param.nbPt;
			for (int i = 0; i < 512; i += inc) {
				double ang = i * Math.PI / 512;
				double y1 = 0;
				if (grpCos1.Enabled)
					y1 += param.amplitude1 + param.amplitude1 * Math.Cos((ang * param.periode1) + (param.dephasage1 * Math.PI / 180.0));

				if (grpCos2.Enabled)
					y1 += param.amplitude2 + param.amplitude2 * Math.Cos((ang * param.periode2) + (param.dephasage2 * Math.PI / 180.0));

				if (grpCos3.Enabled)
					y1 += param.amplitude3 + param.amplitude3 * Math.Cos((ang * param.periode3) + (param.dephasage3 * Math.PI / 180.0));

				if (md == ModeData.Draw)
					g.DrawLine(p, i, (int)(y1), i + inc, (int)(y1));
				else {
					line += "#" + ((byte)(y1 / 2)).ToString("X2") + ",";
					if (++nbOctets >= nbOctetsLigne) {
						sw.WriteLine(line.Substring(0, line.Length - 1));
						line = "\tDB\t";
						nbOctets = 0;
					}
				}
			}
			if (md == ModeData.Draw)
				pictureBox1.Refresh();
			else
				sw.Close();
		}

		private bool CheckValues(string strPer, string strAmpl, string strDephas, ref double per, ref double ampl, ref double dephas) {
			double locPer = 0, locAmpl = 0, locDephas = 0;
			if (double.TryParse(strPer.Replace('.', ','), out locPer) && locPer > 0 && locPer < 30) {
				per = locPer;
				if (double.TryParse(strAmpl.Replace('.', ','), out locAmpl) && locAmpl > 0 && locAmpl < 256) {
					ampl = locAmpl;
					if (double.TryParse(strDephas.Replace('.', ','), out locDephas)) {
						dephas = locDephas;
						return true;
					}
					else
						MessageBox.Show("Déphasage non valide détecté.");
				}
				else
					MessageBox.Show("Amplitude non valide détectée.");
			}
			else
				MessageBox.Show("Période non valide détectée.");

			return false;
		}

		private bool TestValues() {
			// Vérifier les valeurs
			bool testOk = true;
			if (grpCos1.Enabled)
				testOk &= CheckValues(txbPeriode1.Text, txbAmplitude1.Text, txbDephasage1.Text, ref param.periode1, ref param.amplitude1, ref param.dephasage1);

			if (grpCos2.Enabled)
				testOk &= CheckValues(txbPeriode2.Text, txbAmplitude2.Text, txbDephasage2.Text, ref param.periode2, ref param.amplitude2, ref param.dephasage2);

			if (grpCos3.Enabled)
				testOk &= CheckValues(txbPeriode3.Text, txbAmplitude3.Text, txbDephasage3.Text, ref param.periode3, ref param.amplitude3, ref param.dephasage3);

			return testOk;
		}

		private void chkEnable1_CheckedChanged(object sender, EventArgs e) {
			param.cos1Actif = grpCos1.Enabled = chkEnable1.Checked;
		}

		private void chkEnable2_CheckedChanged(object sender, EventArgs e) {
			param.cos2Actif = grpCos2.Enabled = chkEnable2.Checked;
		}

		private void chkEnable3_CheckedChanged(object sender, EventArgs e) {
			param.cos3Actif = grpCos3.Enabled = chkEnable3.Checked;
		}

		private void rb256_CheckedChanged(object sender, EventArgs e) {
			param.nbPt = 256;
		}

		private void rb512_CheckedChanged(object sender, EventArgs e) {
			param.nbPt = 512;
		}

		private void bpRead_Click(object sender, EventArgs e) {
			Enabled = false;
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Données CreeCosCrb (*.xml)|*.xml";
			DialogResult result = dlg.ShowDialog();
			if (result == DialogResult.OK) {
				FileStream fileParam = File.Open(dlg.FileName, FileMode.Open);
				try {
					param = (ParamCrb)new XmlSerializer(typeof(ParamCrb)).Deserialize(fileParam);
					chkEnable1.Checked = param.cos1Actif;
					txbAmplitude1.Text = param.amplitude1.ToString();
					txbDephasage1.Text = param.dephasage1.ToString();
					txbPeriode1.Text = param.periode1.ToString();
					chkEnable2.Checked = param.cos2Actif;
					txbAmplitude2.Text = param.amplitude2.ToString();
					txbDephasage2.Text = param.dephasage2.ToString();
					txbPeriode2.Text = param.periode2.ToString();
					chkEnable3.Checked = param.cos3Actif;
					txbAmplitude3.Text = param.amplitude3.ToString();
					txbDephasage3.Text = param.dephasage3.ToString();
					txbPeriode3.Text = param.periode3.ToString();
					if (param.nbPt == 256)
						rb256.Checked = true;
					else
						rb512.Checked = true;
				}
				catch {
					MessageBox.Show("Erreur de lecture...");
				}
				fileParam.Close();
			}
			Enabled = true;
		}

		private void bpSave_Click(object sender, EventArgs e) {
			Enabled = false;
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "Données CreeCosCrb (*.xml)|*.xml";
			DialogResult result = dlg.ShowDialog();
			if (result == DialogResult.OK) {
				FileStream file = File.Open(dlg.FileName, FileMode.Create);
				try {

					new XmlSerializer(typeof(ParamCrb)).Serialize(file, param);
				}
				catch {
					MessageBox.Show("Erreur de sauvegarde...");
				}
				file.Close();
			}
			Enabled = true;
		}

		private void bpTest_Click(object sender, EventArgs e) {
			if (TestValues()) {
				Cls();
				TestCrb(ModeData.Draw);
			}
		}

		private void bpExport_Click(object sender, EventArgs e) {
			if (TestValues()) {
				Enabled = false;
				SaveFileDialog dlg = new SaveFileDialog();
				dlg.Filter = "Fichier assembleur (*.asm)|*.asm";
				DialogResult result = dlg.ShowDialog();
				Enabled = true;
				if (result == DialogResult.OK)
					TestCrb(ModeData.Export, dlg.FileName);
			}
		}
	}
}
