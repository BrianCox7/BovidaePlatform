using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bovidae.Core;

namespace Bovidae.Audio
{
	public abstract class AudioPlugin
	{
		#region Properties
		public string Name { get; private set; }

		/// <summary>
		/// Gets the sample rate of the audio plug-in (in samples per second).
		/// </summary>
		public virtual double SampleRate { get; private set; }

		public virtual int InputChannelCount { get; private set; }

		public virtual int OutputChannelCount { get; private set; }

		/// <summary>
		/// Gets the latency of the audio plug-in (in number of samples).
		/// </summary>
		public virtual int Latency { get; private set; }

		/// <summary>
		/// Gets the tail length of the audio plug-in (in seconds).
		/// </summary>
		public virtual double TailLength { get; private set; }

		public List<AudioPluginParameter> Parameters
		{
			get
			{
				return _parameters;
			}
		}

		public abstract Guid VstProcessorUid { get; }

		public abstract Guid VstControllerUid { get; }
		#endregion

		#region Fields
		private List<AudioPluginParameter> _parameters = new List<AudioPluginParameter>();
		#endregion

		#region Constructors/Destructor
		public AudioPlugin()
		{
			SampleRate = 0.0;
			InputChannelCount = 0;
			OutputChannelCount = 0;
			Latency = 0;
			TailLength = 0.0;
		}

		public AudioPlugin(string name) : base()
		{
			Name = name;
		}
		#endregion
	}
}
