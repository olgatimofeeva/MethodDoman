using System;

namespace Core
{
    public class Sequence
    {
		protected const Int32 MinElementCount = 1;
		protected const Int32 MaxElementCount = 6;

		protected Sequence(String[] aContent // not String, new type String + mp3 + []
						, Int32 aElementCount
						)
		{
			Content = aContent ?? throw new ArgumentNullException(nameof(aContent));
			if ((aElementCount >= MinElementCount) && (aElementCount <= MaxElementCount))
				ElementCount = aElementCount;
			else throw new ArgumentOutOfRangeException(nameof(aElementCount));

		}



		public String[] Content { get; }// not String, new type String + mp3 + []
		public Int32 ElementCount { get; }


		virtual public void Sort()
		{
			Boolean[] occupated = new Boolean[ElementCount - 1];
			Int32[] newIndex = new Int32[ElementCount - 1];
			var random = new Random(ElementCount - 2);
			for (var index = 0; index < ElementCount - 1; index++)
			{
				var temp = random.Next(ElementCount - 1);
				while (occupated[temp])
				{ temp = random.Next(ElementCount - 1); }
				newIndex[index] = temp;
				occupated[temp] = true;
			}
			for (var index = 0; index < MaxElementCount - 1; index++)
			{
				var temp = Content[index];
				Content[index] = Content[newIndex[index]];
				Content[newIndex[index]] = temp;
			}
		}

		virtual public String GetNextItem(Int32 index)
		{
			if ((index < 0) || (index >= ElementCount))
				throw new ArgumentOutOfRangeException(nameof(index));
			return Content[index];
		}

	}
}
