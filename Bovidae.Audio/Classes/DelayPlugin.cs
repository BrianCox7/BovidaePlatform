using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bovidae.Core;

namespace Bovidae.Audio
{
	public class DelayPlugin : AudioPlugin
	{
		#region Properties
		public override Guid VstProcessorUid
		{
			get
			{
				return new Guid("57f0d4dd-b4fb-4a4c-ae7f-73567e04ab49");
			}
		}

		public override Guid VstControllerUid
		{
			get
			{
				return new Guid("67d0a30e-f5cf-4a9e-8528-e00d9ead815b");
			}
		}
		#endregion

		#region Constructors/Destructor
		public DelayPlugin()
			: base("Delay Plug-in")
		{

		}
		#endregion
	}
}
