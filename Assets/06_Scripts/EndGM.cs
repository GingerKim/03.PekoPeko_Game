using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndGM : MonoBehaviour
{

    // 게임 종료 여부를 나타내는 변수
    bool isGameEnded = false;

    // Update is called once per frame
    void Update()
    {
        // 종료 조건을 설정합니다. 여기에서는 ESC 키를 누르면 게임이 종료됩니다.
        if (Input.GetKeyDown(KeyCode.Escape) && !isGameEnded)
        {
            isGameEnded = true;
        }
    }

    void EndScene()
    {
        Debug.Log("end");
        Application.Quit();
    }
}