using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLnR : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public bool going;
    public float intervals;
    //public SpriteRenderer visual;
    private Vector3 characterscale;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("WayToGo2", 1f);
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        characterscale = transform.localScale;
    }


    // Update is called once per frame
    void WayToGo2()
    {
        rb.velocity = Vector2.left * speed;
        characterscale.x = 1;
        Invoke("WayToGo", intervals);
        transform.localScale = characterscale;
    }
    void WayToGo()
    {
        rb.velocity = Vector2.right * speed;
        characterscale.x = -1;
        Invoke("WayToGo2", intervals);
        transform.localScale = characterscale;
    }
}
