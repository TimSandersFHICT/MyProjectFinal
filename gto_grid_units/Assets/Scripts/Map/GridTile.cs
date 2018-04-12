using UnityEngine;

public class GridTile : MonoBehaviour
{
    public bool Empty { get; private set; }
    public Unit Unit { get; private set; }

    private void Start()
    {
        Empty = true;
    }
    
    public void Place(Unit u)
    {
        if (Empty)
        {
            Unit = u;
            Empty = false;
        }
    }
}
