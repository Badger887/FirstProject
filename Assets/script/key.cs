using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    timecontroller tc;
    public SpriteRenderer opencase;

    void OnMouseDown()
    {
        Debug.Log("clicked");
        opencase.sortingOrder = 2;
        tc = FindObjectOfType<timecontroller>();
        if (tc != null)
        {
            tc.Success();
        }
        {

        }
        
        

    }
}
    