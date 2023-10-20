using System.Collections;
using UnityEngine;
using TMPro;

public class Timer1 : MonoBehaviour
{
    public TextMeshProUGUI timerText; // ���������� ��� TextMeshProUGUI ���� � ���������� Unity
    public float timeLeft = 30.0f; // ���������� ����� ��������� �������
    public LoseGameText LoseGameText;

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = timeLeft.ToString("0"); // ��������� �����

        }
        if  (timeLeft <=0)
        {
            LoseGameText.Die();
        }
    }
}
