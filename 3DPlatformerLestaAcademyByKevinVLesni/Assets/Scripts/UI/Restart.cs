using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{

    public void RestartCurrentScene()
    {
        // �������� �������� �����
        Scene currentScene = SceneManager.GetActiveScene();

        // ��������� �������� ����� ������
        SceneManager.LoadScene(currentScene.name);
    }
    

}
