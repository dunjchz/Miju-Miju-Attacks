using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PointManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    public GameObject gameOverPanel;


    void Start()
    {
        // connecting text component with score value
        scoreText.text = "Score: " + score;
        gameOverPanel.SetActive(false);

    }

    // method created to count scores
    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
        // checking if winning conditions are satisfied
        GameOver();
    }

    // adding winning condition and game over panel
    void GameOver()
    {
        if (score == 27)
        {
            gameOverPanel.SetActive(true);
        }
    }
    // Method for loading game again on click
    public void RestartButton()
    {
        SceneManager.LoadScene("SpaceInvaders");
    }
    // Method for loading main menu on click
    public void MainMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }

}

