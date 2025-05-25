using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timecontroller03 : MonoBehaviour
{
    // Start is called before the first frame update
    public float countdown = 5f;
    private bool isSuccess = false;
    private bool redchecked = false;
    private bool bluechecked = false;
    public SpriteRenderer opencase;
    void Start()
    {
        Invoke("Failure", countdown);
    }

    // Update is called once per frame
    public void redChecked()
    {
        if (!redchecked)
        {
            redchecked = true;
            Success();
        }
    }

    public void blueChecked()
    {
        if (!bluechecked)
        {
            bluechecked = true;
            Success();
        }
    }

    public void Success()
    { if (!isSuccess && redchecked && bluechecked )
        {
            isSuccess = true;
            CancelInvoke("failurecheck");
            Debug.Log("success");
            opencase.sortingOrder = 2;
            
        }

    }

    void Failure()
    {
        if (!isSuccess)
        {
            Debug.Log("fail");
            SceneManager.LoadScene("failscene");
        }


    }


}
