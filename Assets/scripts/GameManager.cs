using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    [SerializeField] int TimeToEnd;
    bool gamePaused = false;
    bool endGame = false;
    bool win = false;
    public int Points = 0;
    public int redKey = 0;
    public int goldKey = 0;
    public int greenKey = 0;

    void Start()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }
        if (TimeToEnd <= 0)
        {
            TimeToEnd = 100;

        }
        Debug.Log("time: " + TimeToEnd + " s");
        InvokeRepeating("Stopper", 2, 1);
    }

    void Update()
    {
        PauseCheck();
    }
    void Stopper()
    {
        TimeToEnd--;
        Debug.Log("time: " + TimeToEnd + " s");

        if (TimeToEnd <= 0)
        {
            TimeToEnd = 0;
            endGame = true;

        }

        if (endGame)
        {
            EndGame();

        }

    }
    public void PauseGame()
    {
        Debug.Log("Pause Game");
        Time.timeScale = 0f;
        gamePaused = true;
    }
    public void ResumeGame()
    {
        Debug.Log("Resume Game");
        Time.timeScale = 1f;
        gamePaused = false;

    }
    public void EndGame()
    {
        CancelInvoke("Stopper");
        if (win)
        {
            Debug.Log("You Win! Reload");

        }
        else
        {
            Debug.Log("You lose, Reload?");
        }

    }
    void PauseCheck()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (gamePaused)
            {
                ResumeGame();

            }
            else
            {
                PauseGame();
            }
        }
        PickUpCheck();
    }
    public void AddPoints(int Points)
    {
        Points += Points;

    }
    public void AddTime(int AddTime)
    {

        TimeToEnd += AddTime;
    }
    public void FreezeTime(int freezeTime)
    {
        CancelInvoke("Stopper");
        InvokeRepeating("Stopper", freezeTime, 1);
    }
    public void AddKey(KeyColor color)
    {
        if (color == KeyColor.Red) redKey++;
        else if (color == KeyColor.Green) greenKey++;
        else if (color == KeyColor.Gold) goldKey++;

    }
void PickUpCheck()
{
if(Input.GetKeyDown(KeyCode.L))
{
Debug.Log("Actual Time: " + TimeToEnd);
Debug.Log("Key red: " + redKey + " green: " + greenKey + " gold: " + goldKey);
Debug.Log("Points: " + Points);
}
}
}
