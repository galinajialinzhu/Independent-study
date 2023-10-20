using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed = 5.0f; // Adjust the speed as needed 
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ApplyRandomMovement();
    }

    void ApplyRandomMovement()
    {
        Vector2 randomDirection = Random.insideUnitCircle.normalized; // Random direction vector
        Vector2 movement = randomDirection * speed; // Apply speed to the direction
        rb.velocity = movement;

        Invoke("ApplyRandomMovement", Random.Range(1.0f, 3.0f)); // Schedule the next direction change
    }
}
