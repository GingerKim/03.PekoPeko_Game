using UnityEngine;

public class GameEndObject : MonoBehaviour
{
    void OnMouseDown()
    {
        // ���� ���� ������ ���⿡ �ۼ��մϴ�.
        // ���� ���, ���� ���� �޽����� ����ϰ� 2�� �Ŀ� ���ø����̼��� �����ϴ� �ڵ�� ������ �����ϴ�.
        Debug.Log("���� ����");
        // ���� �޽����� ����ϰ� 2�� �Ŀ� ���ø����̼��� �����մϴ�.
        Invoke("QuitGame", 2f);
    }

    void QuitGame()
    {
        Application.Quit();
    }
}