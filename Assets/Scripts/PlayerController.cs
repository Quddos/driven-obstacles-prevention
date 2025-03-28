using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        // verticalInput = Input.GetAxis("Vertical");
        // We'll move our vehicle here
        // transform.Translate(0,0,1);
        // transform.Translate(Vector3.forward);
        transform.Translate(Vector3.forward * Time.deltaTime * speed );
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput );
    }
}
