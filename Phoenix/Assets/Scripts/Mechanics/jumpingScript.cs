using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpingScript : MonoBehaviour
{
    public float jumpForce;
    public GameObject jumpEF, phoenix, player;
    public Rigidbody2D rb2d;
    public bool canjump;
    public Animator playerAnimator;
  

    // Start is called before the first frame update
    void Start()
    {
       //rb2d = this.gameObject.GetComponent<Rigidbody2D>();
        canjump = true;

    }

    // Update is called once per frame
    void Update()
    {
        /*if(rb2d.velocity.x < 0)
        {
            jumpForce = 12f;
        }
        if (rb2d.velocity.x > 0)
        {
            jumpForce = -12f;
        }*/
        if (Input.GetButtonDown("Jump") && rb2d.velocity.y < 0.1f && canjump == true)
        {
            rb2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            playerAnimator.SetBool("Jumping", true);
            playerAnimator.GetComponent<Animator>().speed = 1;
            //Extras
            playerAnimator.SetBool("Descending", false);
            playerAnimator.SetBool("Swim", false);
            canjump = false;
            Invoke("canjumpagain", 1.1f);
            phoenix.SetActive(true);
            Invoke("PhoenixVisibility", 1f);
            Instantiate(jumpEF, player.transform.position, Quaternion.identity);
        }
        //jump animation end
        if (rb2d.velocity.y <= 0.1f && rb2d.velocity.y > -0.1f)
        {
            playerAnimator.SetBool("Jumping", false);
        }
    }
    public void canjumpagain()
    {
        canjump = true;
    }
    public void PhoenixVisibility()
    {
        phoenix.SetActive(false);
    }
}
