using System;
using System.Collections.Generic;

namespace LemonadeStand
{
	class Program
	{
		static void Main(string[] args)
		{
			RefreshmentsHQ Corp = new RefreshmentsHQ();
			Corp.makeLemonStands();
			Corp.LemonCashReport();
			Corp.makePopStands();
			Corp.PopCashReport();
			Corp.FinishParagraph();
			
		}
	}
}



