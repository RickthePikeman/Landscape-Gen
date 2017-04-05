using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MapGenerator : MonoBehaviour {

    public int width;
    public int height;

    public string seed;
    public bool useRandomSeed;

    [Range(0,100)]//The int can only be in a range of 0 to 100
    public int randomFillPercent;

    int[,] map;

    void Start()
    {
        GenerateMap();
    }

<<<<<<< HEAD
	void Update() {
		if(Input.GetMouseButtonDown(0)) {
				GenerateMap();
		}
	}

=======
>>>>>>> 7acb6702354cb7497e34b18b864c7b23aa7ad9d8
    void GenerateMap()
    {
        map = new int[width, height];
		RandomFillMap();
<<<<<<< HEAD
		for(int i = 0; i <5; i++) 
		{
			SmoothMap();
		}
=======
>>>>>>> 7acb6702354cb7497e34b18b864c7b23aa7ad9d8
    }

    void RandomFillMap()
    {
        if (useRandomSeed)
        {
            seed = Time.time.ToString();
        }
<<<<<<< HEAD
        System.Random pseudoRandom = new System.Random(seed.GetHashCode());
=======
        System.Random psuedoRandom = new System.Random(seed.GetHashCode());
>>>>>>> 7acb6702354cb7497e34b18b864c7b23aa7ad9d8

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
<<<<<<< HEAD
				if(x==0 || x == width-1 || y == 0 || y == height-1) {
					map[x, y] = 1;
				}
				else {
					map[x, y] = (pseudoRandom.Next(0, 100) < randomFillPercent) ? 1 : 0;
				}
                
=======
                map[x, y] = (psuedoRandom.Next(0, 100) < randomFillPercent) ? 1 : 0;
>>>>>>> 7acb6702354cb7497e34b18b864c7b23aa7ad9d8
            }
        }
    }

<<<<<<< HEAD
	void SmoothMap()
	{
		for (int x = 0; x < width; x++)
		{
			for (int y = 0; y < height; y++)
			{
				int neighbourWallTiles = GetSurroundingWallCount(x, y);
				if(neighbourWallTiles > 4) {
					map[x, y] = 1;
				}
				else if(neighbourWallTiles < 4) {
					map[x, y] = 0;
				}
			}
		}
	}

	int GetSurroundingWallCount(int gridX, int gridY) {
		int wallCount = 0;
		for(int neighbourX = gridX-1; neighbourX <= gridX+1; neighbourX++) {

			for (int neighbourY = gridY - 1; neighbourY <= gridY + 1; neighbourY++)
			{
				if (neighbourX >= 0 && neighbourX < width && neighbourY >= 0 && neighbourY < height)
				{
					if (neighbourX != gridX || neighbourY != gridY)
					{

						wallCount += map[neighbourX, neighbourY];
					}
				}
				else {
					wallCount++;
				}
			}
		}
		return wallCount;
	}

=======
>>>>>>> 7acb6702354cb7497e34b18b864c7b23aa7ad9d8
    void OnDrawGizmos()
    {
        if(map != null)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
					Gizmos.color = (map[x, y] == 1) ? Color.black : Color.white;
					Vector3 pos = new Vector3(-width / 2 + x + 0.5f, -height / 2 + y + 0.5f);
					Gizmos.DrawCube(pos, Vector3.one);
                }
            }
        }
    }

}
