using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgedistruction : MonoBehaviour
{
    public GameObject bridgeBox, explosions, bridgeVisual, diveBird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            bridgeBox.SetActive(false);
            explosions.SetActive(true);
            diveBird.SetActive(true);
            bridgeVisual.SetActive(false);

            Destroy(explosions, 1f);
            Destroy(diveBird, 2.4f);
        }
    }
}
