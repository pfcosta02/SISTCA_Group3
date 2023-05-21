using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    Renderer rend;
    public float speed = 0.2f;
    public bool xAxis;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        float offset = Time.time * speed;

        if(!xAxis) {
            rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
        } else {
            rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        }
    }
}
