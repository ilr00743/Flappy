using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour 
{
	private int _score = 0;

	public bool gameOver = false;

	public static GameControl instance;
	
	public Text _scoreText;
	public GameObject gameOvertext;

	void Awake()
	{
		if(instance == null)
		{
			instance = this;
		}
		else if(instance != this)
		{
			Destroy(gameObject);
		}
	}

	void Update()
	{
		if(gameOver && Input.GetMouseButtonDown(0)) 
		{
			// Reload the current scene.
			SceneManager.LoadScene(0);
		}
		else if(gameOver && Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}

	public void BirdScored()
	{
		// If the game is over - player can't score.
		if(gameOver)	
			return;
		// If the game is not over - increase the score
		_score++;

		_scoreText.text = "" + _score.ToString();
	}

	public void Dying()
	{
		gameOvertext.SetActive(true);
		gameOver = true;
	}
}
