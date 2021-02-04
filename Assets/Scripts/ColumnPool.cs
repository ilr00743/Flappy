using UnityEngine;
using System.Collections;

public class ColumnPool : MonoBehaviour 
{
	public GameObject _columnPrefab;
	[SerializeField] private int _columnPoolSize = 5;
	[SerializeField] private float _spawnRate = 3f;
	[SerializeField] private float _minYPosition = -1f;
	[SerializeField] private float _maxYPosition = 3.5f;

	private GameObject[] _columns;
	private int _currentColumn = 0;

	private Vector2 _objectPoolPosition = new Vector2(-15,-25);
	private float _spawnXPosition = 10f;

	private float _timeSinceLastSpawned;


	void Start()
	{
		_timeSinceLastSpawned = 0f;

		_columns = new GameObject[_columnPoolSize];

		for(int i = 0; i < _columnPoolSize; i++)
		{
			_columns[i] = (GameObject)Instantiate(_columnPrefab, _objectPoolPosition, Quaternion.identity);
		}
	}

	void Update()
	{
		_timeSinceLastSpawned += Time.deltaTime;

		if(GameControl.instance.gameOver == false && _timeSinceLastSpawned >= _spawnRate) 
		{	
			_timeSinceLastSpawned = 0f;

			float spawnYPosition = Random.Range(_minYPosition, _maxYPosition);

			_columns[_currentColumn].transform.position = new Vector2(_spawnXPosition, spawnYPosition);

			_currentColumn ++;

			if(_currentColumn >= _columnPoolSize) 
			{
				_currentColumn = 0;
			}
		}
	}
}