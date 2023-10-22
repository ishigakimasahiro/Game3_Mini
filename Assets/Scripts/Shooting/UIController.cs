using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
	int score = 0;
	[SerializeField] GameObject scoreText;

	[SerializeField] GameObject gameOverText;

	public void AddScore()
	{
		this.score += 10;
	}

    private void Start()
    {
		gameOverText.SetActive(false);
    }

    void Update()
	{
		scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");

		if (GameOver.isGameOver)
		{
			Debug.Log("isGameOver");
			gameOverText.SetActive(true);
		}

		if (gameOverText.activeSelf == true)
		{
			if (Input.GetKeyDown(KeyCode.Return))
			{
				SceneManager.LoadScene("Game1");
			}
		}
	}
}
