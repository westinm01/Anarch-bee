using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUIShowUI : MonoBehaviour
{
    [SerializeField] GameObject[] UIToHideAndShow;

    public void HideUI()
    {
        foreach(GameObject g in UIToHideAndShow)
        {
            g.SetActive(false);
        }
    }
    public void ShowUI()
    {
        foreach (GameObject g in UIToHideAndShow)
        {
            g.SetActive(true);
        }
    }
}
