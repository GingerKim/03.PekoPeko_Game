using UnityEngine;

public class GameEndObject : MonoBehaviour
{
    void OnMouseDown()
    {
        // 게임 종료 로직을 여기에 작성합니다.
        // 예를 들어, 게임 종료 메시지를 출력하고 2초 후에 애플리케이션을 종료하는 코드는 다음과 같습니다.
        Debug.Log("게임 종료");
        // 종료 메시지를 출력하고 2초 후에 애플리케이션을 종료합니다.
        Invoke("QuitGame", 2f);
    }

    void QuitGame()
    {
        Application.Quit();
    }
}