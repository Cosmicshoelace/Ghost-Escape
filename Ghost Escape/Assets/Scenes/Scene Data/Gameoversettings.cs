﻿


	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameoversettings : MonoBehaviour

{

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Replay()
    {
        SceneManager.LoadScene("Main Scene");
    }
}
