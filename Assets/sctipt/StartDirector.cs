﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartDirector : MonoBehaviour
{
      void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("CarScene");
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
