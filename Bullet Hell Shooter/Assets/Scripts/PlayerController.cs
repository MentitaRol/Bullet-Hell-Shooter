using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float precisionSpeed = 5.0f;
    private float currentSpeed;

    public KeyCode switchKey;

    public float horizontalInput;
    public float verticalInput;
    
    public Vector2 Hrange = Vector2.zero;
    public Vector2 Vrange = Vector2.zero;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if(Input.GetKey(switchKey))
        {
            currentSpeed = precisionSpeed;
        }
        else
        {
            currentSpeed = speed;
        }

        transform.Translate(Vector3.up * Time.deltaTime * currentSpeed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * currentSpeed * horizontalInput);
    }

    void LateUpdate() 
    {
        transform.position = new Vector3
        (
            Mathf.Clamp(transform.position.x, Vrange.x, Vrange.y),
            Mathf.Clamp(transform.position.y, Hrange.x, Hrange.y),
            transform.position.z
        );
    }
}