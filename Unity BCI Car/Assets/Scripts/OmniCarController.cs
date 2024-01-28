using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OmniCarController : MonoBehaviour
{
    public float speed = 20;
    public Vector3 _rotationSpeed = new Vector3 (0, 50, 0);

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movementDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        transform.Translate(movementDirection * speed * Time.deltaTime);

        if(Input.GetKey("k")){
            transform.Rotate(_rotationSpeed * Time.deltaTime);
        }
        if(Input.GetKey("j")){
            transform.Rotate( -_rotationSpeed * Time.deltaTime);
        }
    }
}
