using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1UmlIntro
{
    internal class Yonetici : Insan
    {
		private int id;

		public int Id
		{
			get { return id; }
		}

		private string ad;

		public string Ad
		{
			get { return ad; }
			set { ad = value; }
		}

		private string parola;

		public string Parola
		{
			get { return parola; }
		}

		public Yonetici() { }

		public void CikisYap() { }
		public void GirisYap() { }

	}
}
