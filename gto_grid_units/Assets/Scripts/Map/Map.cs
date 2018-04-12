using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
	public int Height;
	public int Width;
	
	public GridTile TilePrefab;

	private GridTile[,] grid;

	private void Start ()
	{
		grid = new GridTile[Width, Height];
		
		for (int x = 0; x < Width; x++)
		{
			for (int y = 0; y < Height; y++)
			{
				grid[x, y] = Instantiate(TilePrefab, new Vector3(x, 0, y), Quaternion.identity, gameObject.transform);
			}
		}
	}

	public GridTile getEmptyTile()
	{
		var tiles = new List<GridTile>();
		
		foreach (var tile in grid)
		{
			if (tile.Empty) tiles.Add(tile);
		}

		if (tiles.Count != 0)
		{
			return tiles[Random.Range(0, tiles.Count)];
		}

		Debug.Log("No empty tiles left");
		return null;
	}
}