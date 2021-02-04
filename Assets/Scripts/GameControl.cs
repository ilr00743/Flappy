using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour 
{
	private int _score = 0;

	public bool gameOver = false;
	public float scrollSpeed = -1.5f;

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
	}

	public void BirdScored()
	{
		// If the game is over - player can't _score.
		if(gameOver)	
			return;
		// If the game is not over - increase the _score
		_score++;

		_scoreText.text = "Score: " + _score.ToString();
	}

	public void Dying()
	{
		gameOvertext.SetActive(true);
		gameOver = true;
	}
}
