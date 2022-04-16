using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;


public class VfxLightning : MonoBehaviour
{   
   [SerializeField] VisualEffect lightningEffect;



  
    void Start()
    {
       PlayLightning();
    }


    void PlayLightning()
    {
      lightningEffect.Play();
      

    }

    
    void Update()
    {  
        
     // StartCoroutine(delay());



    }

 /* public IEnumerator delay()
  { 
    yield return new WaitForSeconds(4f);

    PlayLightning();

  } */




}
