using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bee : MonoBehaviour {            //rename "bee" and "other" as needed
  private void OnTriggerEnter2D(Collision2D other){
    Debug.Log("Hit Detected");        //remove Debug if desired
    Destroy(other.gameObject);
    this.gameObject.SetActive(false);
  }
}
