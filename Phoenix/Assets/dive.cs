using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dive : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d = this.gameObject.GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.down * speed;
    }
}
