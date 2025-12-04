using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BirdScript : MonoBehaviour
{
    // Add a speed variable for control
    public float moveSpeed = 5.0f;

    void Update()
    {
        // Get the raw input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the translation vector
        Vector3 translation = new Vector3(horizontalInput, verticalInput, 0);

        // Apply movement: Input * Speed * Time.deltaTime
        // This ensures movement is in units per second (e.g., 5 units/second)
        transform.position += translation * moveSpeed * Time.deltaTime;
    }
}
