using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayDeletion());
    }

    IEnumerator DelayDeletion()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
