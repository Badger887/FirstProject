using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timecontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public float countdown = 5f;
    private bool isSuccess = false;
    void Start()
    {
        Invoke("Failure", countdown);
    }

    // Update is called once per frame
    public void Success()
    { if (!isSuccess)
        {
            isSuccess = true;
            CancelInvoke("failurecheck");
            Debug.Log("success");
            SceneManager.LoadScene("SampleScene 2");
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
