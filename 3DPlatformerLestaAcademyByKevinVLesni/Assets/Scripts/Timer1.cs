using System.Collections;
using UnityEngine;
using TMPro;

public class Timer1 : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Перетащите ваш TextMeshProUGUI сюда в инспекторе Unity
    public float timeLeft = 30.0f; // Установите время обратного отсчета
    public LoseGameText LoseGameText;

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = timeLeft.ToString("0"); // Обновляем текст

        }
        if  (timeLeft <=0)
        {
            LoseGameText.Die();
        }
    }
}
