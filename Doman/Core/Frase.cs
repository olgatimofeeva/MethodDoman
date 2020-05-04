using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
	public class Frase : Sequence
	{
		protected Frase(String[] aContent, Int32 aElementCount = MaxElementCount) : base(aContent, aElementCount)
		{
		}
	}
}
