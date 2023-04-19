using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy Car")
        {      // Se detetar uma colisão com o gameObject com a tag "Enemy Car"
            Destroy (collision.gameObject);                // Destroi o Enemy Car
        }
    }
}
