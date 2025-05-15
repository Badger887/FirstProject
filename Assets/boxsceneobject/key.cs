using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public SpriteRenderer opencase;

    void OnMouseDown()
    {
        Debug.Log("clicked");
        opencase.sortingOrder = 2;

    }
}
    