using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
	public class Word : Sequence
	{
		public Word(String[] aContent, Int32 aElementCount = MaxElementCount) : base(aContent, aElementCount) { }
	}
}
