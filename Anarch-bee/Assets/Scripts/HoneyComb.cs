using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class HoneyComb : MonoBehaviour
{
    public Tilemap destructableTilemap;
    public TileCount eventSystemTileCount;
    // Start is called before the first frame update
    void Start()
    {
        destructableTilemap = GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Bee")
        {
           // Destroy(collision.gameObject); //might destroy the entire tilemap...
           Vector3 hitPosition = Vector3.zero;
           foreach (ContactPoint2D hit in collision.contacts)
           {
                hitPosition.x = hit.point.x - 0.01f * hit.normal.x;
                hitPosition.y = hit.point.y - 0.01f * hit.normal.y;
                destructableTilemap.SetTile(destructableTilemap.WorldToCell(hitPosition), null);
                eventSystemTileCount.currentAmount--;
           }
        }
    }
}
