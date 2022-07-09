using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public bool freezeAtEnd = false;// if  you want something to freeze at the end.
    public List<Transform> positions;
    public int positionsIndex=0;
    public float speed;
    public Transform startPos;

    Vector3 nextPos;
    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position == positions[positionsIndex].position)
        {
            
            if(positionsIndex < positions.Count - 1)
            {
                //Debug.Log("index increased to " + positionsIndex);
                positionsIndex++;
            }
            else{
                //Debug.Log("Hit else");
                if (!freezeAtEnd){
                    positionsIndex = 0;//Goes back to start
                }
            }
            nextPos = positions[positionsIndex].position;
        }
        
        
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

}
