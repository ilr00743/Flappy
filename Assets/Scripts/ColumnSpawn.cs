using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawn : MonoBehaviour
{
    [SerializeField] private float _randomOffset = 2f;
    [SerializeField] private float _startDelay = 2f;
    [SerializeField] private float _repeatRate = 2f;
    [SerializeField] private float _interSpace = 2f;

    private Vector3 _spawnPosition;
     
    public GameObject obstaclePrefab;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", _startDelay, _repeatRate);
    }

    void Update() 
    {   
        float randomHeight = UnityEngine.Random.Range(-_randomOffset, _randomOffset);

        _spawnPosition += new Vector3(_interSpace * Time.deltaTime, 0, transform.position.z);
        _spawnPosition.y = randomHeight;
    }
    void SpawnObstacle()
    {
        if(GameControl.instance.gameOver == false)
        {
            Instantiate(obstaclePrefab, _spawnPosition, obstaclePrefab.transform.rotation);
        }
    }
}
