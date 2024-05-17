using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1UmlIntro
{
    internal class Insan : ISomeInterface
    {
		private string ad;

		public string Ad
		{
			get { return ad; }
			set { ad = value; }
		}
		private int yash;
        public string Mail { get; set; }
		public float Zam(int maash, float oran) { return  maash / oran; }
		private int Foo() {  return yash; }

        public void SomeMethod()
        {
            throw new NotImplementedException();
        }
    }
}
