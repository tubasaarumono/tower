using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameDirector : MonoBehaviour
{
    float hight = 0f;
    GameObject scoreText;
    // public TextMeshProUGUI scoreText;
    float gameTime = 60f;
    Image timerGauge;
    float timeLeft;

    void Start()
    {
        timeLeft = gameTime;
        this.scoreText = GameObject.Find("Score");
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
        scoreText.GetComponent<Text>().text = "SCORE: " + score.ToString("F1");

        float fillAmount = timeLeft / gameTime;
        timerGauge.fillAmount = fillAmount;
    }
}
