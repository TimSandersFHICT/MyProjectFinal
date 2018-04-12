using UnityEngine;

public class Unit : MonoBehaviour
{
    public int Cost;
    public Player Player;

    public void SetPlayer(Player player)
    {
        Player = player;
    }
}
