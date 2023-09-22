using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public float hight = 0f;
    public Text scoreText;
    public float gameTime = 60f;
    public Image timerGauge;

    private float timeLeft;

    void Start()
    {
        timeLeft = gameTime;
    }
        void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0f)
        {
            SceneManager.LoadScene("EndScene");
        }

        GameObject[] ves01 = GameObject.FindGameObjectsWithTag("Ves01");
        foreach (GameObject ves in ves01)
        {
            if (ves.transform.position.y > hight)
            {
                hight = ves.transform.position.y;
            }
        }

        float score = hight * 10 - 3;
        scoreText.text = "SCORE: " + score.ToString("F1");

        float fillAmount = timeLeft / gameTime;
        timerGauge.fillAmount = fillAmount;
    }
}
