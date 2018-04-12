using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : MonoBehaviour
{
    public Map Map;
    public TurnManager TurnManager;
    public Resource GoldResource;

    public List<Unit> UnitPrefabs;
    
    public void BuildUnit(int index)
    {
        var tile = Map.getEmptyTile();

        if (tile != null)
        {
            var unit = UnitPrefabs[index];
            if (GoldResource.Remove(unit.Cost))
            {
                TurnManager.CurrentPlayer.AddUnit(unit);
                tile.Place(Instantiate(unit, tile.transform.position, Quaternion.identity));
            }
        }
    }
}
