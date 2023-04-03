using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public float speed = 1;
    public Text SpeedText;
    public HeroSounds sound;
    public HeroScript hero;
    public bool temp;
    public int theScore;

    void Update()
    {
        if(temp == false)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                restartGame();
            }
        }

        theScore = playerScore;

    }

    [ContextMenu("Increase Score")]
    public int addScore(int scoreToAdd)    //Score
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        if(playerScore%10==0)
        {
            sound.playScoreSound();
        }
        return playerScore;
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            restartGame();
        }
        temp = false;
    }

    public float difficulty(float difficultyUp)
    {
        speed = speed + difficultyUp;

        return speed;
    }

}
