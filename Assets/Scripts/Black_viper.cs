using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black_viper : MonoBehaviour
{
    /*
    private Rigidbody2D rb;
    public float moveSpeed = 100f;
    private float direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
    }

    // Update is called once per frame
    private void fixedUpdate()
    {
        rb.velocity = Vector2.zero;
        rb.velocity = new Vector2(direction * moveSpeed * Time.fixedDeltaTime, 0);
    }
    */
    public float carSpeed;
    Vector3 position;

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
}
