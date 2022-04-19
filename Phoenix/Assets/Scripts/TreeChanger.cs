using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeChanger : MonoBehaviour
{
    public GameObject swamplights;
    public GameObject treeflowers;
    public GameObject waterfalls;
    public GameObject winScreen;


    public static bool step1, step2, step3;
    public bool prog1, prog2, prog3;
    // Start is called before the first frame update
    void Start()
    {
        step1 = false;
        step2 = false;
        step3 = false;
    }

    // Update is called once per frame
    void Update()
    {
      if (prog1 && prog2 && prog3 == true)
        {
            winScreen.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController crystalbool = collision.gameObject.GetComponent<PlayerController>();
     
        if ((collision.tag == "player") && (step1 == true))
        {
            swamplights.SetActive(true);
            step1 = true;
        }
        if ((collision.tag == "player") && (step2 == true))
        {
            treeflowers.SetActive(true);
            step2 = true;
        }
        if ((collision.tag == "player") && (step3 == true))
        {
            swamplights.SetActive(true);
            step3 = true;
        }
    }

}
