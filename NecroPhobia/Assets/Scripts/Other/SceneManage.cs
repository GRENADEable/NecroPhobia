﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameV2");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game Exited");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void OnTriggerEnter(Collider kill)
    {
        if (kill.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("DeathScene");
            Debug.Log("Player is Dead");
        }
    }
}
