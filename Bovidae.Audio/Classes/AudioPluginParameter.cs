using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bovidae.Core;

namespace Bovidae.Audio
{
	public abstract class AudioPluginParameter
	{
		#region Properties
		public UInt32 Id { get; private set; }

		public string Name { get; private set; }

		public string UnitsLabel { get; private set; }

		public double DefaultValue { get; private set; }

		public int StepCount { get; private set; }

		public AudioPluginParameterFlags Flags { get; private set; }

		public abstract double Value { get; }

		public abstract string ValueText { get; }
		#endregion

		#region Constructor/Destructors
		public AudioPluginParameter(UInt32 id, string name, string unitsLabel, double defaultValue, int stepCount, AudioPluginParameterFlags flags)
		{
			Id = id;
			Name = name;
			UnitsLabel = unitsLabel;
			DefaultValue = defaultValue;
			StepCount = stepCount;
			Flags = flags;
		}
		#endregion
	}

	[Flags()]
	public enum AudioPluginParameterFlags
	{
		Automatable = 1,
		ReadOnly = 2,
		List = 4
	}

	public enum AudioPluginParameterUnits
	{
		Generic = 0,
		Decibels,
		Hertz,
		Seconds
	}
}
