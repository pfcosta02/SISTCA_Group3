using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_spawn : MonoBehaviour
{
    public GameObject car;
    public float maxPosition = 2.1f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 carPosition = new Vector3 (Random.Range(-2.1f,2.1f), transform.position.y, transform.position.z);
        Instantiate (car, carPosition, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
