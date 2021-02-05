using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    private float _lifeTime = 30;
    void Update()
    {
        Destroy(gameObject, _lifeTime);
    }
}
