using UnityEngine;
using System.Collections;
 
public class MoveLeft : MonoBehaviour {
    //[SerializeField] private float _speed = 2f;
    [SerializeField] private float _randomOffset = 2f;
  
    void Update ()
    {

        if(transform.position.x > 10 )
        {
            float randomHeight = UnityEngine.Random.Range(-_randomOffset, _randomOffset);
            transform.position = new Vector3(transform.position.x, randomHeight, transform.position.z);
        }
    }
}