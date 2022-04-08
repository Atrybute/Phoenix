using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public class Boundary
{
    //public float xMin, xMax;
    //public float yMin, yMax;
}

public class Control : MonoBehaviour
{
    //public Joystick joystick;
    //public Boundary boundary;
    public Rigidbody2D myRigidBody;
    

   // [SerializeField]
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");
        HandleMovement(horizontal, vertical);
       // myRigidBody.position = new Vector2
            //(Mathf.Clamp(myRigidBody.position.x, boundary.xMin, boundary.xMax),
            //Mathf.Clamp(myRigidBody.position.y, boundary.yMin, boundary.yMax));
    }
    private void HandleMovement(float horizontal, float vertical)
    {

        myRigidBody.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
