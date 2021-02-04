using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawn : MonoBehaviour
{
    private float _randomOffset = 1f;
    private float _startDelay = 2f;
    private float _repeatRate = 2f;
    private float _interSpace = 0.1f;

    private Vector3 _spawnPosition;
    public GameObject obstaclePrefab;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", _startDelay, _repeatRate);
    }

    void Update() 
    {   
        float randomHeight = UnityEngine.Random.Range(-_randomOffset, _randomOffset);

        _spawnPosition += new Vector3(transform.position.x * _interSpace * Time.deltaTime, 0, transform.position.z);
        _spawnPosition.y = randomHeight;
        
    }
    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, _spawnPosition, obstaclePrefab.transform.rotation);
    }
}
