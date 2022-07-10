using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class HoneyComb : MonoBehaviour
{
    public Tilemap destructableTilemap;
   //  public TileCount eventSystemTileCount;
    public Grid grid;
    [SerializeField] GameObject honeyExplosionVFX;

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
            FindObjectOfType<ScoreKeeper>().addBlockScore();
            // Destroy(collision.gameObject); //might destroy the entire tilemap...
            // eventSystemTileCount.currentAmount--;
            Vector3 hitPosition = Vector3.zero;
           foreach (ContactPoint2D hit in collision.contacts)
           {
                hitPosition.x = hit.point.x - 0.01f;
                hitPosition.y = hit.point.y - 0.01f;
                destructableTilemap.SetTile(destructableTilemap.WorldToCell(hitPosition), null);
           }
            Instantiate(honeyExplosionVFX, hitPosition, Quaternion.identity);
        }
    }
}
