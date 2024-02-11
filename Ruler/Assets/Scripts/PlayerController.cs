using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    
    Rigidbody rb;

    public float forceAmount = 10f;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * forceAmount);
        }

        /*
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(Vector3.back * forceAmount);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeForce(Vector3.left * forceAmount);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeForce(Vector3.right * forceAmount);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0,25,0);
        }
        */
        
    }
}
