using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileCount : MonoBehaviour
{
    [SerializeField] Tilemap tiles;
    [SerializeField] TileBase[] TilesToCheck;
    /* public int currentAmount;

    // Start is called before the first frame update
    void Start()
    {
        currentAmount = GetTileAmount();
    } */


    void Update()
    {
        bool empty = true;
        foreach (TileBase t in TilesToCheck)
        {
            if (tiles.ContainsTile(t))
            {
                empty = false;
            }
            
        }
        if(empty)
        {
            Debug.Log("Win!");
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
