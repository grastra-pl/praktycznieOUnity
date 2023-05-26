using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour
{
    [SerializeField] private float moveDistance = 1f; // Distance to move left and right
    [SerializeField] private float moveSpeed = 1f; // Speed of movement

    private bool moveRight = true; // Flag to indicate movement direction
    private Vector3 startPosition; // Starting position of the object

    private void Start()
    {
        // Store the starting position of the object
        startPosition = transform.position;
    }

    private void Update()
    {
        // Calculate the target position for movement
        Vector3 targetPosition = moveRight ? startPosition + Vector3.right * moveDistance : startPosition + Vector3.left * moveDistance;

        // Move the object towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Check if the object has reached the target position
        if (transform.position == targetPosition)
        {
            // Reverse the movement direction
            moveRight = !moveRight;
        }
    }
}







