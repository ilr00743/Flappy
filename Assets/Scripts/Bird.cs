using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour 
{
	[SerializeField] private float _jumpForce;
	[SerializeField] private float _speed;
	private bool _isDead = false;

	private Rigidbody2D _rigidbody;

	void Start()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		// If the bird die - turn off controller
		if(_isDead == false) 
		{
			transform.Translate(new Vector2(_speed * Time.deltaTime, 0));

			if(Input.GetMouseButtonDown(0)) 
			{
				_rigidbody.velocity = Vector2.zero;
				_rigidbody.AddForce(new Vector2(0, _jumpForce));
			}
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		_rigidbody.velocity = Vector2.zero;

		_isDead = true;

		GameControl.instance.Dying();
	}
}
