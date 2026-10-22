using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
      
      horizontalInput = Input.GetAxis("Horizontal");
      verticalInput = Input.GetAxis("Vertical");

      //move the ball forward
       if(verticalInput> 0)
      {
        rigid.AddForce(Vector3.forward*Time.deltaTime*speed);
      }
      else if(verticalInput<0)
      {
        rigid.AddForce(Vector3.back*Time.deltaTime*speed);
      }
      //Ball turning
      if(horizontalInput> 0)
      {
        rigid.AddForce(Vector3.right*Time.deltaTime*speed);
      }
      else if(horizontalInput<0)
      {
        rigid.AddForce(Vector3.left*Time.deltaTime*speed);
      }
    }
}
