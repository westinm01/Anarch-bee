using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileCount : MonoBehaviour
{
    Tilemap tiles;
    /* public int currentAmount;

    // Start is called before the first frame update
    void Start()
    {
        currentAmount = GetTileAmount();
    } */


    void Update()
    {
        tiles = FindObjectOfType<Tilemap>();
        if(tiles.GetUsedTilesCount() <= 0)
        {
            GetComponent<PauseGame>().Pause(3);//call win
        }

        /* Debug.Log(currentAmount);
        if(currentAmount <=0)
        {
            GetComponent<PauseGame>().Pause(3);//call win.
        } */
    }
     /* public int GetTileAmount()
    {
     tiles.CompressBounds(); // To only read the tiles that we have painted
     int amount = 0;
     foreach (var pos in tiles.cellBounds.allPositionsWithin)
     {
         Tile tile = tiles.GetTile<Tile>(pos);
         if(tile != null) { amount += 1; }
     }

     return amount;
 }*/ 
}
