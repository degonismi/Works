using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text text;
    public Text MaxScore;

    public static int LoseCount;
    public static int Score;
    public static int BestScore;
    public static bool Lose = false;

    [Header("Масса игрока:")]
    [Range(0.1f, 10.0f)]
    public float Mass;
    [Header("Сила толчка:")]
    [Range(0.1f, 10.0f)]
    public float Force;
    [Header("Скорость блоков:")]
    [Range(0.1f,10.0f)]
    public float Speed;


    private void Awake()
    {
        if (PlayerPrefs.HasKey("BestScore"))
        {
            BestScore = PlayerPrefs.GetInt("BestScore");
        }
        else
        {
            BestScore = 0;
            PlayerPrefs.SetInt("BestScore", BestScore);
        }

        if (PlayerPrefs.HasKey("LoseCount"))
        {
            LoseCount = PlayerPrefs.GetInt("LoseCount");
        }
        else
        {
            LoseCount = 0;
            PlayerPrefs.SetInt("LoseCount", LoseCount);
        }

    }

    private void Start()
    {

        Lose = false;
        Score = 0;

    }
    private void Update()
    {
        text.text = Score + " ";
        MaxScore.text = "BEST\n" + BestScore;
    }
    public static void IfLose()
    {
        if (!Lose)
        {
            LoseCount++;
            PlayerPrefs.SetInt("LoseCount", LoseCount);
            if (Score > BestScore)
            {
                BestScore = Score;
                PlayerPrefs.SetInt("BestScore", BestScore);
            }
            Lose = true;
        }
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

}
