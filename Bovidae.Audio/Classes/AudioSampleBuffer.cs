using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bovidae.Core;

namespace Bovidae.Audio
{
	public class AudioSampleBuffer
	{
		#region Properties
		public int ChannelCount { get; private set; }

		public int Length { get; private set; }

		public double[] Data { get; private set; }
		#endregion

		#region Constructors/Destructor
		public AudioSampleBuffer(int channelCount, int length)
		{
			ChannelCount = channelCount;
			Length = length;
		}
		#endregion
	}
}
