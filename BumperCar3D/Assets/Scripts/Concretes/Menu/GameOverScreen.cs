﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void GoMenu()
    {       
        SceneManager.LoadScene("MainMenu");
    }
}
