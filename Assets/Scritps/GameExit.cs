using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameExit : MonoBehaviour
{
    // �Q�[���I�����Ăяo���֐�
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false; // �G�f�B�^�[�Œ�~
#else
        Application.Quit(); // �Q�[�����r���h����Ď��s���ꂽ�ꍇ�ɏI��
#endif

        // �R���\�[���ɏI�����b�Z�[�W
        Debug.Log("�Q�[�����I�����܂�");
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
