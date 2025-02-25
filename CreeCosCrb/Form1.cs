using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CreeCosCrb {
	public partial class Form1 : Form {
		private readonly Graphics g;
		private ParamCrb param = new ParamCrb();
		private enum ModeData { Draw, Export };
		private readonly List<Coord> lstCoord = new List<Coord>();
		string line = "\tDB\t";
		int nbOctets = 0, nbOctetsLigne = 16;

		public Form1() {
			InitializeComponent();
			pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			pictureBox1.Refresh();
			g = Graphics.FromImage(pictureBox1.Image);
			Cls();
			chkEnable1.Checked = grpCos1.Enabled = true;
			chkEnable2.Checked = chkEnable3.Checked = grpCos2.Enabled = grpCos3.Enabled = false;
		}

		private void Cls() {
			g.Clear(Color.FromArgb(0, 0, 128));
			pictureBox1.Refresh();
		}

		private void ExportData(byte data, StreamWriter sw) {
			line += "#" + data.ToString("X2") + ",";
			if (++nbOctets >= nbOctetsLigne) {
				sw.WriteLine(line.Substring(0, line.Length - 1));
				line = "\tDB\t";
				nbOctets = 0;
			}
		}

		private StreamWriter InitExport(string fileName) {
			line = "\tDB\t";
			nbOctets = 0;
			nbOctetsLigne = 16;
			return File.CreateText(fileName);
		}

		private void EndExport(StreamWriter sw) {
			if (line.Length > 4)
				sw.WriteLine(line.Substring(0, line.Length - 1));

			sw.Close();
		}

		private void EndLineExport(StreamWriter sw) {
			if (line.Length > 4)
				sw.WriteLine(line.Substring(0, line.Length - 1));

			line = "\tDB\t";
			nbOctets = 0;
		}

		private void TestCrb(ModeData md, string fileName = null) {
			lstCoord.Clear();
			Pen p = new Pen(Color.FromArgb(255, 255, 255));
			float inc = 512 / (float)param.nbPt;
			if (chkModeXY.Checked) {
				for (float i = 0; i < 512; i += inc) {
					double ang = i * Math.PI / 512;
					float x1 = 0, y1 = 0;
					double c1 = Math.Cos((ang * param.periode1) + (param.dephasage1 * Math.PI / 180.0));
					if (grpCos1.Enabled && grpCos2.Enabled) {
						double s2 = Math.Sin((ang * param.periode2) + (param.dephasage2 * Math.PI / 180.0));
						x1 += (float)(param.offset1 + param.amplitude1 * (chkAbs1.Checked ? Math.Abs(c1) : c1));
						y1 += (float)(param.offset2 + param.amplitude2 * (chkAbs2.Checked ? Math.Abs(s2) : s2));
					}
					if (grpCos3.Enabled) {
						double c3 = Math.Cos((ang * param.periode3) + (param.dephasage3 * Math.PI / 180.0));
						double s3 = Math.Sin((ang * param.periode3) + (param.dephasage3 * Math.PI / 180.0));
						x1 += (float)(param.offset3 + param.amplitude3 * (chkAbs3.Checked ? Math.Abs(c3) : c3));
						y1 += (float)(param.offset3 + param.amplitude3 * (chkAbs3.Checked ? Math.Abs(s3) : s3));
					}
					lstCoord.Add(new Coord((int)x1, (int)y1));
					if (md == ModeData.Draw)
						g.DrawLine(p, x1, y1, x1 + inc, y1);
				}
			}
			else {
				for (float i = 0; i < 512; i += inc) {
					double ang = i * Math.PI / 512;
					float y1 = 0;
					double c1 = Math.Cos((ang * param.periode1) + (param.dephasage1 * Math.PI / 180.0));
					double c2 = Math.Cos((ang * param.periode2) + (param.dephasage2 * Math.PI / 180.0));
					double c3 = Math.Cos((ang * param.periode3) + (param.dephasage3 * Math.PI / 180.0));
					if (grpCos1.Enabled)
						y1 += (float)(param.offset1 + param.amplitude1 * (chkAbs1.Checked ? Math.Abs(c1) : c1));

					if (grpCos2.Enabled)
						y1 += (float)(param.offset2 + param.amplitude2 * (chkAbs2.Checked ? Math.Abs(c2) : c2));

					if (grpCos3.Enabled)
						y1 += (float)(param.offset3 + param.amplitude3 * (chkAbs3.Checked ? Math.Abs(c3) : c3));

					lstCoord.Add(new Coord((int)i, (int)y1));
					if (md == ModeData.Draw)
						g.DrawLine(p, i, y1, i + inc, y1);
				}
			}
			if (md == ModeData.Draw)
				pictureBox1.Refresh();
			else {
				StreamWriter sw = InitExport(fileName);
				if (chkModeXY.Checked) {
					sw.WriteLine("; Coordonnées X");

					int minx = int.MaxValue, maxx = int.MinValue;
					foreach (Coord c in lstCoord) {
						if (c.x > maxx)
							maxx = c.x;
						if (c.x < minx)
							minx = c.x;
					}
					foreach (Coord c in lstCoord)
						ExportData((byte)c.x, sw);

					if (maxx - minx > 255) {
						sw.WriteLine("; Coordonnées X (high)");
						foreach (Coord c in lstCoord)
							ExportData((byte)(c.x >> 8), sw);

					}

					EndLineExport(sw);
					sw.WriteLine("; Coordonnées Y");
					foreach (Coord c in lstCoord)
						ExportData((byte)c.y, sw);

					EndLineExport(sw);
				}
				else {
					foreach (Coord c in lstCoord) {
						if (!chkOnlyY.Checked)
							ExportData((byte)c.x, sw);

						ExportData((byte)c.y, sw);
					}
				}
				EndExport(sw);
			}
		}

		private bool CheckValues(string strPer, string strAmpl, string strDephas, string strOffset, ref double per, ref double ampl, ref double dephas, ref double offset) {
			if (double.TryParse(strPer.Replace('.', ','), out double locPer) && locPer > 0 && locPer < 30) {
				per = locPer;
				if (double.TryParse(strAmpl.Replace('.', ','), out double locAmpl) && locAmpl > -128 && locAmpl < 512) {
					ampl = locAmpl;
					if (double.TryParse(strDephas.Replace('.', ','), out double locDephas)) {
						dephas = locDephas;
						if (double.TryParse(strOffset.Replace('.', ','), out double locOffset)) {
							offset = locOffset;
							return true;
						}
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
			bool testOk = int.TryParse(txbNbPt.Text, out int locNbPt) && locNbPt >= 16 && locNbPt <= 16384;
			if (testOk) {
				param.nbPt = locNbPt;
				if (grpCos1.Enabled)
					testOk &= CheckValues(txbPeriode1.Text, txbAmplitude1.Text, txbDephasage1.Text, txbOffset1.Text, ref param.periode1, ref param.amplitude1, ref param.dephasage1, ref param.offset1);

				if (grpCos2.Enabled)
					testOk &= CheckValues(txbPeriode2.Text, txbAmplitude2.Text, txbDephasage2.Text, txbOffset2.Text, ref param.periode2, ref param.amplitude2, ref param.dephasage2, ref param.offset2);

				if (grpCos3.Enabled)
					testOk &= CheckValues(txbPeriode3.Text, txbAmplitude3.Text, txbDephasage3.Text, txbOffset3.Text, ref param.periode3, ref param.amplitude3, ref param.dephasage3, ref param.offset3);
			}
			else
				MessageBox.Show("Nombre de points pour la courbe invalide.");

			return testOk;
		}

		private void ChkEnable1_CheckedChanged(object sender, EventArgs e) {
			param.cos1Actif = grpCos1.Enabled = chkEnable1.Checked;
		}

		private void ChkEnable2_CheckedChanged(object sender, EventArgs e) {
			param.cos2Actif = grpCos2.Enabled = chkEnable2.Checked;
		}

		private void ChkEnable3_CheckedChanged(object sender, EventArgs e) {
			param.cos3Actif = grpCos3.Enabled = chkEnable3.Checked;
		}

		private void BpRead_Click(object sender, EventArgs e) {
			Enabled = false;
			OpenFileDialog dlg = new OpenFileDialog { Filter = "Données CreeCosCrb (*.xml)|*.xml" };
			DialogResult result = dlg.ShowDialog();
			if (result == DialogResult.OK) {
				FileStream fileParam = File.Open(dlg.FileName, FileMode.Open);
				try {
					param = (ParamCrb)new XmlSerializer(typeof(ParamCrb)).Deserialize(fileParam);
					chkModeXY.Checked = param.modeXY;
					chkEnable1.Checked = param.cos1Actif;
					chkAbs1.Checked = param.abs1;
					txbAmplitude1.Text = param.amplitude1.ToString();
					txbDephasage1.Text = param.dephasage1.ToString();
					txbPeriode1.Text = param.periode1.ToString();
					txbOffset1.Text = param.offset1.ToString();
					chkEnable2.Checked = param.cos2Actif;
					chkAbs2.Checked = param.abs2;
					txbAmplitude2.Text = param.amplitude2.ToString();
					txbDephasage2.Text = param.dephasage2.ToString();
					txbPeriode2.Text = param.periode2.ToString();
					txbOffset2.Text = param.offset2.ToString();
					chkEnable3.Checked = param.cos3Actif;
					chkAbs3.Checked = param.abs3;
					txbAmplitude3.Text = param.amplitude3.ToString();
					txbDephasage3.Text = param.dephasage3.ToString();
					txbPeriode3.Text = param.periode3.ToString();
					txbOffset3.Text = param.offset3.ToString();
					txbNbPt.Text = param.nbPt.ToString();
				}
				catch {
					MessageBox.Show("Erreur de lecture...");
				}
				fileParam.Close();
			}
			Enabled = true;
		}

		private void BpSave_Click(object sender, EventArgs e) {
			Enabled = false;
			SaveFileDialog dlg = new SaveFileDialog { Filter = "Données CreeCosCrb (*.xml)|*.xml" };
			DialogResult result = dlg.ShowDialog();
			if (result == DialogResult.OK) {
				FileStream file = File.Open(dlg.FileName, FileMode.Create);
				try {
					param.modeXY = chkModeXY.Checked;
					param.abs1 = chkAbs1.Checked;
					param.abs2 = chkAbs2.Checked;
					param.abs3 = chkAbs3.Checked;
					new XmlSerializer(typeof(ParamCrb)).Serialize(file, param);
				}
				catch {
					MessageBox.Show("Erreur de sauvegarde...");
				}
				file.Close();
			}
			Enabled = true;
		}

		private void BpTest_Click(object sender, EventArgs e) {
			if (TestValues()) {
				Cls();
				TestCrb(ModeData.Draw);
			}
		}

		private void BpExport_Click(object sender, EventArgs e) {
			if (TestValues()) {
				Enabled = false;
				SaveFileDialog dlg = new SaveFileDialog { Filter = "Fichier assembleur (*.asm)|*.asm" };
				DialogResult result = dlg.ShowDialog();
				Enabled = true;
				if (result == DialogResult.OK)
					TestCrb(ModeData.Export, dlg.FileName);
			}
		}
	}

	public class Coord {
		public int x, y;

		public Coord(int x, int y) {
			this.x = x;
			this.y = y;
		}
	}
}
