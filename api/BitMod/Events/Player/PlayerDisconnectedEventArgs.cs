﻿using BitMod.Compatibility;
using BitMod.Events.Accessors;
using BitMod.Events.Base;

namespace BitMod.Events.Player;

public class PlayerDisconnectedEventArgs : IEventArgs, IResponsiblePlayerEvent
{
	public PlayerDisconnectedEventArgs(BitServer server, BitPlayer player)
	{
		Player = player;
		Server = server;
	}

	/// <summary>
	/// The player that just disconnected.
	/// </summary>
	public BitPlayer Player { get; }

	/// <inheritdoc />
	public BitPlayer ResponsiblePlayer => Player;

	/// <inheritdoc />
	public BitServer Server { get; }
}
