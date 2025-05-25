using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key03red : MonoBehaviour
{
    timecontroller03 tc03;
    

    void OnMouseDown()
    {
        Debug.Log("clicked");
       
        tc03 = FindObjectOfType<timecontroller03>();
        if (tc03 != null)
        {
            tc03.redChecked();
        }
        {

        }
        
        

    }
}
    