using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    //Singleton
    public static ScoreManager instance { get; private set; }

    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(this);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    //Stats
    public Text scoreText;
    public int Lives = 0;
    public int Score = 0;
    void Start()
    {
        scoreText.text = Score.ToString() + " POINTS";
    }
    public void StartNewGame()
    {
        Lives = 3;
        Score = 0;
    }
    public void AddScore()
    {
        Score++;
    }
    public void RemoveLife()
    {
        Lives--;
    }


}
