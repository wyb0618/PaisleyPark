﻿using System.ComponentModel;

namespace PaisleyPark.Models
{
	/// <summary>
	/// Memory model holds information pulled from the game.
	/// </summary>
	public class Memory : INotifyPropertyChanged
	{
		/// <summary>
		/// Current Map ID.
		/// </summary>
		public uint MapID { get; set; }

		/// <summary>
		/// Player coordinates in game.
		/// </summary>
		public float PlayerX { get; set; }
		public float PlayerY { get; set; }
		public float PlayerZ { get; set; }

		/// <summary>
		/// Waymark coordinates in game.
		/// </summary>
		public Waymark A { get; set; }
		public Waymark B { get; set; }
		public Waymark C { get; set; }
		public Waymark D { get; set; }
		public Waymark One { get; set; }
		public Waymark Two { get; set; }
		public Waymark Three { get; set; }
		public Waymark Four { get; set; }

		/// <summary>
		/// Property Changed event handler for this model.
		/// </summary>
#pragma warning disable 67
		public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 67
	}
}
