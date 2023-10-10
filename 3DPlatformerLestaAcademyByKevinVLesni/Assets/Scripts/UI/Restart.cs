using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{

    public void RestartCurrentScene()
    {
        // Получаем активную сцену
        Scene currentScene = SceneManager.GetActiveScene();

        // Загружаем активную сцену заново
        SceneManager.LoadScene(currentScene.name);
    }
    

}
