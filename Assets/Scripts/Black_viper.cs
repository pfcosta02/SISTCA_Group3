using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black_viper : MonoBehaviour
{
    public float carSpeed;
    Vector3 position;
    public uiManager ui;

    public float limitRight = 2.4f;
    public float limitLeft = 2.24f;

    void Start() {
        position = transform.position;
    }

    void Update() {
        position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -limitLeft, limitRight);

        transform.position = position;
    }

    // Colisions
    void OnCollisionEnter2D(Collision2D colision) {
        if (colision.gameObject.tag == "Enemy Car") {      // Se detetar uma colisão com o gameObject com a tag "Enemy Car"
            Destroy (gameObject);                          // Destroi o nosso gameObject
            ui.gameOverActivated();
        }
    }
}
