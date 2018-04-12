using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
	public List<Player> Players;
	public int index;
	public Player CurrentPlayer { get; private set; }

	private void Start()
	{
		index = 0;
		CurrentPlayer = Players[index];
		
		//Turn all the UI's off.
		foreach (var p in Players)
		{
			p.EndTurn();
		}
		
		CurrentPlayer.StartTurn();
	}

	public void NextPlayer()
	{
		CurrentPlayer.EndTurn();
		index++;
		if (index >= Players.Count)
		{
			index = 0;
		}

		CurrentPlayer = Players[index];
		CurrentPlayer.StartTurn();
		
	}
}
