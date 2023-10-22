using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    [SerializeField] Text scoreText;

    public int score;


    private void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddScore(int num)
    {
        score += num;

        scoreText.text = "Score: " + score.ToString();
    }
}
