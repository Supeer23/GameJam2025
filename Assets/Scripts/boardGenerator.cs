using UnityEngine;
using UnityEngine.Tilemaps;

public class boardGenerator : MonoBehaviour
{
    boardGenerator instance;
    public Tilemap m_Tilemap;
    public int Width;
    public int Height;
    public Tile[] GroundTiles;
    public Tile[] WallTiles;

    // Start is called before the first frame update
    void Start()
    {
        m_Tilemap = GetComponentInChildren<Tilemap>();

        for (int y = 0; y < Height; ++y)
        {
            for (int x = 0; x < Width; x++)
            {
                Tile tiles;
                if (x==0 || x==Width-1 || y==0 || y==Height-1)
                {
                    tiles = WallTiles[Random.Range(0,WallTiles.Length)];
                }
                else
                {
                    tiles = GroundTiles[Random.Range(0,GroundTiles.Length)];
                }
                m_Tilemap.SetTile(new Vector3Int(x, y, 0), tiles);
            }
        }
    }
    public int getHeight(){
        return Height;
    }
    public int getWidth(){
        return Width;
    }
}
