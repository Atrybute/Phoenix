using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armorChanger : MonoBehaviour
{
    public GameObject fireArmor1, fireArmor2, fireArmor3, fireArmor4, fireArmor5, fireArmor6, fireArmor7, fireArmor8, fireArmor9, fireArmor10, fireArmor11, fireArmor12, fireArmor13, fireArmor14, fireArmor15, fireArmor16;
    public GameObject stoneArmor1, stoneArmor2, stoneArmor3, stoneArmor4,stoneArmor5, stoneArmor6, stoneArmor7, stoneArmor8, stoneArmor9, stoneArmor10, stoneArmor11, stoneArmor12, stoneArmor13;
    public GameObject lightningArmor1, lightningArmor2, lightningArmor3, lightningArmor4, lightningArmor5, lightningArmor6, lightningArmor7, lightningArmor8, lightningArmor9, lightningArmor10, lightningArmor11, lightningArmor12; /*lightningArmor12, lightningArmor13*/ //parent armor asset
    public GameObject default1, default2, default3, default4, default5;

    public GameObject stonecube, firecube, lightcube; //pickup location

    public GameObject waterDenial, lightDenial, fireDenial;
    // Start is called before the first frame update
    void Start()
    {
        default1.SetActive(true);
        default2.SetActive(true);
        default3.SetActive(true);
        default4.SetActive(true);
        default5.SetActive(true);
        //default6.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Stonearmor")
        {
            stoneArmor1.SetActive(true);
            stoneArmor2.SetActive(true);
            stoneArmor3.SetActive(true);
            stoneArmor4.SetActive(true);
            stoneArmor5.SetActive(true);
            stoneArmor6.SetActive(true);
            stoneArmor7.SetActive(true);
            stoneArmor8.SetActive(true);
            stoneArmor9.SetActive(true);
            stoneArmor10.SetActive(true);
            stoneArmor11.SetActive(true);
            stoneArmor12.SetActive(true);
            stoneArmor13.SetActive(true);

            lightningArmor1.SetActive(false);
            lightningArmor2.SetActive(false);
            lightningArmor3.SetActive(false);
            lightningArmor4.SetActive(false);
            lightningArmor5.SetActive(false);
            lightningArmor6.SetActive(false);
            lightningArmor7.SetActive(false);
            lightningArmor8.SetActive(false);
            lightningArmor9.SetActive(false);
            lightningArmor10.SetActive(false);
            lightningArmor11.SetActive(false);
            lightningArmor12.SetActive(false);


            fireArmor1.SetActive(false);
            fireArmor2.SetActive(false);
            fireArmor3.SetActive(false);
            fireArmor4.SetActive(false);
            fireArmor5.SetActive(false);
            fireArmor6.SetActive(false);
            fireArmor7.SetActive(false);
            fireArmor8.SetActive(false);
            fireArmor9.SetActive(false);
            fireArmor10.SetActive(false);
            fireArmor11.SetActive(false);
            fireArmor12.SetActive(false);
            fireArmor13.SetActive(false);
            fireArmor14.SetActive(false);
            fireArmor15.SetActive(false);
            fireArmor16.SetActive(false);

            fireArmor10.SetActive(false);
            default1.SetActive(false);
            default2.SetActive(false);
            default3.SetActive(false);
            default4.SetActive(false);
            default5.SetActive(false);
            //default6.SetActive(false);

            stonecube.SetActive(false);
            waterDenial.SetActive(false);
            fireDenial.SetActive(true);
            lightDenial.SetActive(true);
            Invoke("ActiveAgain", 3f);
        }

        if (collision.tag == "Lightningarmor")
        {
            stoneArmor1.SetActive(false);
            stoneArmor2.SetActive(false);
            stoneArmor3.SetActive(false);
            stoneArmor4.SetActive(false);
            stoneArmor5.SetActive(false);
            stoneArmor6.SetActive(false);
            stoneArmor7.SetActive(false);
            stoneArmor8.SetActive(false);
            stoneArmor9.SetActive(false);
            stoneArmor10.SetActive(false);
            stoneArmor11.SetActive(false);
            stoneArmor12.SetActive(false);
            stoneArmor13.SetActive(false);

            lightningArmor1.SetActive(true);
            lightningArmor2.SetActive(true);
            lightningArmor3.SetActive(true);
            lightningArmor4.SetActive(true);
            lightningArmor5.SetActive(true);
            lightningArmor6.SetActive(true);
            lightningArmor7.SetActive(true);
            lightningArmor8.SetActive(true);
            lightningArmor9.SetActive(true);
            lightningArmor10.SetActive(true);
            lightningArmor11.SetActive(true);
            lightningArmor12.SetActive(true);

            fireArmor1.SetActive(false);
            fireArmor2.SetActive(false);
            fireArmor3.SetActive(false);
            fireArmor4.SetActive(false);
            fireArmor5.SetActive(false);
            fireArmor6.SetActive(false);
            fireArmor7.SetActive(false);
            fireArmor8.SetActive(false);
            fireArmor9.SetActive(false);
            fireArmor10.SetActive(false);
            fireArmor11.SetActive(false);
            fireArmor12.SetActive(false);
            fireArmor13.SetActive(false);
            fireArmor14.SetActive(false);
            fireArmor15.SetActive(false);
            fireArmor16.SetActive(false);

            default1.SetActive(false);
            default2.SetActive(false);
            default3.SetActive(false);
            default4.SetActive(false);
            default5.SetActive(false);
            //default6.SetActive(false);

            lightcube.SetActive(false);
            lightDenial.SetActive(false); //deactivate collider blocking the lightning area
            waterDenial.SetActive(true);
            fireDenial.SetActive(true);
            Invoke("ActiveAgain", 3f);
        }

        if (collision.tag == "Firearmor")
        {
            stoneArmor1.SetActive(false);
            stoneArmor2.SetActive(false);
            stoneArmor3.SetActive(false);
            stoneArmor4.SetActive(false);
            stoneArmor5.SetActive(false);
            stoneArmor6.SetActive(false);
            stoneArmor7.SetActive(false);
            stoneArmor8.SetActive(false);
            stoneArmor9.SetActive(false);
            stoneArmor10.SetActive(false);
            stoneArmor11.SetActive(false);
            stoneArmor12.SetActive(false);
            stoneArmor13.SetActive(false);

            lightningArmor1.SetActive(false);
            lightningArmor2.SetActive(false);
            lightningArmor3.SetActive(false);
            lightningArmor4.SetActive(false);
            lightningArmor5.SetActive(false);
            lightningArmor6.SetActive(false);
            lightningArmor7.SetActive(false);
            lightningArmor8.SetActive(false);
            lightningArmor9.SetActive(false);
            lightningArmor10.SetActive(false);
            lightningArmor11.SetActive(false);
            lightningArmor12.SetActive(false);

            fireArmor1.SetActive(true);
            fireArmor2.SetActive(true);
            fireArmor3.SetActive(true);
            fireArmor4.SetActive(true);
            fireArmor5.SetActive(true);
            fireArmor6.SetActive(true);
            fireArmor7.SetActive(true);
            fireArmor8.SetActive(true);
            fireArmor9.SetActive(true);
            fireArmor10.SetActive(true);
            fireArmor11.SetActive(true);
            fireArmor12.SetActive(true);
            fireArmor13.SetActive(true);
            fireArmor14.SetActive(true);
            fireArmor15.SetActive(true);
            fireArmor16.SetActive(true);

            default1.SetActive(false);
            default2.SetActive(false);
            default3.SetActive(false);
            default4.SetActive(false);
            default5.SetActive(false);
            //default6.SetActive(false);

            firecube.SetActive(false);
            fireDenial.SetActive(false); // deactivate colliders blocking fire area
            lightDenial.SetActive(true);
            waterDenial.SetActive(true);
            Invoke("ActiveAgain", 3f);
        }

    }
    void ActiveAgain() // make armor pickup block reappear
    {
        stonecube.SetActive(true);
        //follow up pieces
        lightcube.SetActive(true);
        //follow up pieces
        firecube.SetActive(true);
        //follow up pieces
    }
}

