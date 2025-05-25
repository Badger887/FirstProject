using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreenManager : MonoBehaviour
{
    public Image tutorial;
    public void OnCloseButtonClicked()
    {
        tutorial.gameObject.SetActive(false);
    }
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

