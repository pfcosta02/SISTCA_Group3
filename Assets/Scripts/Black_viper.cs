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

    bool currentPlatformAndroid = false;
    Rigidbody2D rb;


    void Awake () {
        rb = GetComponent<Rigidbody2D> ();

        #if UNITY_ANDROID
                currentPlatformAndroid = true;
        #else
                currentPlatformAndroid = false;
        #endif
    }

    void Start() {
        position = transform.position;
    }

    void Update() {

        if (currentPlatformAndroid == true) {
            Accelerometer();
        } else {
            position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
            position.x = Mathf.Clamp(position.x, -limitLeft, limitRight);

            transform.position = position;
        }

        position = transform.position;
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


    // Accelerometer

    void Accelerometer() {
        float x = Input.acceleration.x;
        if (x < -0.1f) {
            MoveLeft();
        }
        else if (x > 0.1f) {
            MoveRight();
        }
        else {
            SetVelocityZero();
        }
    }

    public void MoveLeft () {
        rb.velocity = new Vector2 (-carSpeed, 0);
    }

    public void MoveRight () {
        rb.velocity = new Vector2 (carSpeed, 0);
    }

    public void SetVelocityZero () {
        rb.velocity = Vector2.zero;
    }
}
