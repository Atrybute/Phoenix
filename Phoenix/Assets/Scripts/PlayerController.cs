using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{   
    public static float movementSpeed;
    public float jumpForce;
    //public float jumpForce;
    private Rigidbody2D rb2d;

    public bool fireC;
    public bool lightningC;
    public bool flowerC;
    public bool canjump,isjumping;

    public Animator playerAnimator;

    public GameObject flowerMcg, LightMcg, FireMcg;
    public GameObject lava, water, lightenig, phoenix;
    public GameObject sprint, jumpEF;
    //public GameObject jumpEF;
    private Vector3 characterscale;

    public KeyCode jumpP;
    public KeyCode faster;
    public KeyCode quit;
    public KeyCode restart;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = this.gameObject.GetComponent<Rigidbody2D>();
        characterscale = transform.localScale;
        movementSpeed = 6;
        fireC = false;
        lightningC = false;
        flowerC = false;
        canjump = true;

    }

    // Update is called once per frame
    void Update()
    {
        //movement
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        playerAnimator.SetFloat("Speed", Mathf.Abs(movement));
        /////////////////////////////////////////////////////////////////////////////
        if (swimScript.isSwimming)
        {         
            {
                characterscale.y = 1;
            }
            if ( movement < 0 )
            {
                characterscale.y = -1;    
            }
            else if (movement > 0)
            {
                characterscale.y = 1;
            }
            characterscale.x = 1;
        }
        else
        {
            if (movement < 0)
            {
                characterscale.x = -1;

            }
            else if(movement > 0)
            {
                characterscale.x = 1;

            }
            characterscale.y = 1;
        }
        transform.localScale = characterscale;

        ////////////////////////////////////////////////////////////////////////////////////////
        /*if (Input.GetAxis("Horizontal") < 0)
        {
            characterscale.x = -1;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterscale.x = 1;
        }
        ///
        if(swimScript.isSwimming == true)
        {
            characterscale.y = -1;
        }
        if (swimScript.isSwimming == true)
        {
            characterscale.y = 1;
        }*/

        //Speed
        if (Input.GetKeyDown(faster))
        {
            movementSpeed = 9f;
            playerAnimator.GetComponent<Animator>().speed = 3;
            sprint.SetActive(true);
        }
        else if (Input.GetKeyUp(faster))
        {
            movementSpeed = 6f;
            playerAnimator.GetComponent<Animator>().speed = 1;
            sprint.SetActive(false);
        }
        if (Input.GetKey(restart))
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKey(quit))
        {
            Debug.Log("youQuit");
            SceneManager.LoadScene(0);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //mcguffins
        if (collision.tag == "Fire")
        {
            fireC = true;
            FireMcg.SetActive(false);
            lava.SetActive(true);
            TreeChanger.step1 = true;
            Debug.Log("gotfire");
        }
        if (collision.tag == "Flower")
        {
            flowerC = true;
            flowerMcg.SetActive(false);
            water.SetActive(true);
            TreeChanger.step2 = true;
            Debug.Log("gotflower");
        }
        if (collision.tag == "Light")
        {
            lightningC = true;
            LightMcg.SetActive(false);
            lightenig.SetActive(true);
            TreeChanger.step3 = true;
            Debug.Log("gotlight");
        }
    }

    private void FixedUpdate()
    {
        //Swimming
        if (swimScript.isSwimming == true)
        {
            playerAnimator.SetBool("Descending", false);
            playerAnimator.SetBool("Jumping", false);
            playerAnimator.SetBool("Swim", true);
        }
        else if(swimScript.isSwimming == false)
        {
            playerAnimator.SetBool("Swim", false);

        }
        //fall
        if (rb2d.velocity.y < -0.4f)
        {
            playerAnimator.SetBool("Descending", true);
            playerAnimator.SetBool("Jumping", false);
        }
        if (rb2d.velocity.y > 0f)
        {
            playerAnimator.SetBool("Descending", false);
        }
        //jump
       if (Input.GetKeyDown(jumpP) && rb2d.velocity.y < 0.1f && canjump == true)
        {
            rb2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            playerAnimator.SetBool("Jumping", true);
            playerAnimator.GetComponent<Animator>().speed = 1;
            isjumping = true;
            //Extras
            playerAnimator.SetBool("Descending", false);
            playerAnimator.SetBool("Swim", false);
            canjump = false;
            Invoke("canjumpagain", 1.1f);
            phoenix.SetActive(true);
            Invoke("PhoenixVisibility", 1f);
            Instantiate(jumpEF, transform.position, Quaternion.identity);
        }
        //jump animation end
        if (rb2d.velocity.y <= 0.1f && rb2d.velocity.y > -0.1f)
        {
            playerAnimator.SetBool("Jumping", false);
        }
       if(Input.GetKeyUp(jumpP))
        {
            swimScript.isSwimming = false;
            playerAnimator.SetBool("Swim", false);

        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Untagged")
        {
            playerAnimator.SetBool("Descending", false);
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
