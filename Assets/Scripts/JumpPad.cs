using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce;
    private int jumpCount;

    // Start is called before the first frame update
    void Start()
    {
        jumpCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && jumpCount < 1)
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();

            // Stop movement
            rb.velocity = new Vector3(0f, rb.velocity.y, 0f);

            // Send the player up
            rb.AddForce(Vector3.up * jumpForce);
            jumpCount++;
        }
    }
}
