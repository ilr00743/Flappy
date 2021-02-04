using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour 
{
	private float _groundHorizontalLength;

	private BoxCollider2D _groundCollider;

	void Awake()
	{
		_groundCollider = GetComponent<BoxCollider2D>();

		_groundHorizontalLength = _groundCollider.size.x;
	}

	void Update()
	{
		if (transform.position.x < -_groundHorizontalLength)
		{
			LoopBackground();
		}
	}

	// Loop background effect
	public void LoopBackground()
	{
		Vector2 groundOffSet = new Vector2(_groundHorizontalLength * 2f, 0);

		transform.position = (Vector2)transform.position + groundOffSet;
	}
}