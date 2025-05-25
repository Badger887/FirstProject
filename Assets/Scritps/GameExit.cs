using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameExit : MonoBehaviour
{
    // ゲーム終了を呼び出す関数
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false; // エディターで停止
#else
        Application.Quit(); // ゲームがビルドされて実行された場合に終了
#endif

        // コンソールに終了メッセージ
        Debug.Log("ゲームを終了します");
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
