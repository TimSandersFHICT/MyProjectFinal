using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Unit> Units;
    public GameObject Canvas;
    public Color Color;

    public void StartTurn()
    {
        Canvas.SetActive(true);
    }

    public void EndTurn()
    {
        Canvas.SetActive(false);
    }

    public void AddUnit(Unit u)
    {
        Units.Add(u);
        u.SetPlayer(this);
    }
}
