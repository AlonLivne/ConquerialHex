using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBuilder : MonoBehaviour {
    public HexTile HexTilePrefab;
    public int gridX = 11;
    public int gridY = 11;
    float tileWidth = 1.01f;
    public float gap = 0.0f;
    public HexTile[,] HexArray;
    void BuildGrid()
    {
        int y = 0;
        int x = 0;
        for (y = (-gridY); y <= (gridY - x); y++)
        {
            TileBuild(x, y);
        }
        for (x = 1; x <= gridX; x++)
        {
            for (y = (-gridY); y <= (gridY - x); y++)
            {
                TileBuild(x, y);
                TileBuild(-x, -y);
            }
        }
    }
    HexTile TileBuild(int x, int y)
    {
        var tile = Instantiate(HexTilePrefab);
        var indx = IndexTranslator(x, y);
        HexArray[indx.x,indx.y]=tile;
        tile.transform.position = CalcWorldPos(x, y);
        tile.Init(x, y);
        tile.transform.parent = this.transform;
        tile.name = "Tile " + x + "|" + y;
        return tile;
    }
    Vector3 CalcWorldPos(int Ax, int By)
    {
        float xx;
        float yy;
        xx =   tileWidth *(Mathf.Sqrt(3)* Ax + Mathf.Sqrt(3)*By/2);
        yy =  tileWidth * 3 * By / 2;
        return new Vector3(xx, 0f, yy);
    }
    public static HexTile homeBase;

    private void Awake()
    {
        HexArray = new HexTile[(gridX * 2 + 1), (gridY * 2 + 1)];
        BuildGrid();
        homeBase = HexFinder(0, gridY - 2);
        homeBase.owner = Players.player1;
    }
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

    }

    HexTile HexFinder(int x, int y)
    {
        x = x + gridX;
        y = y + gridY;
        return  HexArray[x, y];
    }
    Vector2Int IndexTranslator(int x, int y)
    {
        x = x + gridX;
        y = y + gridY;
        return new Vector2Int(x, y);
    }
}
