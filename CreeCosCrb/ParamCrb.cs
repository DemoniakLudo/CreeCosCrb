using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreeSinCrb {
	[System.Serializable]
	public class ParamCrb {
		public int nbPt = 256;
		public bool cos1Actif;
		public double periode1, periode2, periode3;
		public bool cos2Actif;
		public double amplitude1, amplitude2, amplitude3;
		public bool cos3Actif;
		public double dephasage1, dephasage2, dephasage3;
	}
}
