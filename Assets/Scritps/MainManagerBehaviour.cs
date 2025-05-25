using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Ç±ÇÍïKê{Ç≈Ç∑

public class MainManagerBehaviour : MonoBehaviour
{
    public UICanvasBehaviour gameTitle;
    private string scene1;
    

    public void OnNewGameButtonClicked()
    {
        scene1 = "Gamejam,mainscreen";
        //gameTitle.gameObject.SetActive(false);
        SceneManager.LoadScene("SampleScene");
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
