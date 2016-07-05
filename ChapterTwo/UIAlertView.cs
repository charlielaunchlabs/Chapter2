using System;

namespace ChapterTwo
{
	class UIAlertView
	{
		object p1;
		object p2;
		string v1;
		string v2;
		string v3;

		public UIAlertView(string v1, string v2, object p1, string v3, object p2)
		{
			this.v1 = v1;
			this.v2 = v2;
			this.p1 = p1;
			this.v3 = v3;
			this.p2 = p2;
		}

		internal void Show()
		{
			throw new NotImplementedException();
		}
	}
}