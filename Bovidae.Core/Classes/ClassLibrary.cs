using System;
using System.Reflection;

namespace Bovidae.Core
{
	public abstract class ClassLibrary
	{
		public static Version GetVersion()
		{
			return Assembly.GetExecutingAssembly().GetName().Version;
		}
	}
}
