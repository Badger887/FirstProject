using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key02 : MonoBehaviour
{
    timecontroller02 tc02;
    public SpriteRenderer opencase;

    void OnMouseDown()
    {
        Debug.Log("clicked");
        opencase.sortingOrder = 2;
        tc02 = FindObjectOfType<timecontroller02>();
        if (tc02 != null)
        {
            tc02.Success();
        }
        {

        }
        
        

    }
}
    