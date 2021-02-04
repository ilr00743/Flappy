using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawn : MonoBehaviour
{
    private float _startDelay = 2f;
    private float _repeatRate = 2f;
    private float _speedMovement = 0.1f;

    private Vector3 _spawnPosition;
    public GameObject obstaclePrefab;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", _startDelay, _repeatRate);
    }

    void Update() 
    {
        _spawnPosition += new Vector3(transform.position.x * _speedMovement * Time.deltaTime,0,0);
        transform.Translate(Vector3.right * _speedMovement * Time.deltaTime);
    }
    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, _spawnPosition, obstaclePrefab.transform.rotation);
    }
}
