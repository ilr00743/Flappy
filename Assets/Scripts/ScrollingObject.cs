using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour 
{
	private Rigidbody2D _rigidbody;

	void Start() 
	{
		_rigidbody = GetComponent<Rigidbody2D>();
		_rigidbody.velocity = new Vector2(GameControl.instance.scrollSpeed, 0);
	}

	void Update()
	{
		// Stop scrolling if the game over
		if(GameControl.instance.gameOver == true)
		{
			_rigidbody.velocity = Vector2.zero;
		}
	}
}
