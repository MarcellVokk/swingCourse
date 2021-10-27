using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwingLauncher
{
	class Version
	{
		public string name;
		public bool isSnapshot;

		public Version(string _name, bool _isSnapshot)
		{
			name = _name;
			isSnapshot = _isSnapshot;
		}
	}
}
