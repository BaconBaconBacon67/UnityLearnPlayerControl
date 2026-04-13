using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 50f;
    private float HorizontalInput;
    private float ForwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");
        // Moves the car based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * ForwardInput);
        // Moves the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * HorizontalInput * Time.deltaTime);
    }
}
