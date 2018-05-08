using System;

namespace NumGen
{
    public class NumGen
    {
		public int Generate()
		{
			Random rand = new Random();
			return rand.Next(100);
		}
    }
}
