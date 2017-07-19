using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MapGenerator : MonoBehaviour {

    public int width, height;
    public GameObject Tile;

    int[,] map;
    public string seed;

	// Use this for initialization
	void Start () {
        GenerateMap();

    }
	
	//// Update is called once per frame
	//void Update () {
		
	//}

    void GenerateMap()
    {
        Debug.Log("Doing it");
        map = new int[width, height];
        randomiseElements();

        int borderSize = 5;
        int[,] borderedMap = new int[width + borderSize * 2, height + borderSize * 2];

        for (int x = 0; x < borderedMap.GetLength(0); x++)
        {
            for (int y = 0; y < borderedMap.GetLength(1); y++)
            {
                if (x >= borderSize && x < width + borderSize && y >= borderSize && y < height + borderSize)
                {
                    borderedMap[x, y] = map[x - borderSize, y - borderSize];
                }
                else
                {
                    borderedMap[x, y] = 1;
                }
            }
        }

        //Instantiate(Resources.Load("Tile"),)
        
        
        //public 
    }

    void randomiseElements()
    {
        
        System.Random pseudoRandom = new System.Random(seed.GetHashCode());

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                {
                    map[x, y] = 0;
                }
                else
                {
                    map[x, y] = 1;
                }
                Vector3 pos = new Vector3(x, 0, y) * 1;
                Instantiate(Tile, pos, Quaternion.identity);
            }
        }
    }

}

