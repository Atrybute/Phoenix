using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swimScript : MonoBehaviour
{
    public static bool isSwimming;
    public Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        isSwimming = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log($"Is Swimming: {isSwimming}");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            isSwimming = true;
            //PlayerController.movementSpeed = 0;
            //Invoke("DefaultSpeed", 005f);
            //PlayerController.playerAnimator.SetBool("Descending", false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            isSwimming = false;
            playerAnimator.Play("Idle");
            playerAnimator.StopPlayback();
        }
    }
    public void DefaultSpeed()
    {
        PlayerController.movementSpeed = 6;
    }
}
