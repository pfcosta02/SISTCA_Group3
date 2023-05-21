using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_spawn : MonoBehaviour
{
    public GameObject car;
    public float maxPosition = 2.1f;
    public float delaySpawn = 1.5f;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = delaySpawn;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) {
            Vector3 carPosition = new Vector3 (Random.Range(-2.1f,2.1f), transform.position.y, transform.position.z);
            Instantiate (car, carPosition, transform.rotation);
            timer = delaySpawn;
        }
    }
}
