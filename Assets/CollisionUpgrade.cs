using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionUpgrade : MonoBehaviour
{ 
    public GameObject replacementObjectPrefab; // Reference to the new object prefab

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision involves another object with the same tag
        if (collision.gameObject.CompareTag(tag))
        {
            // Destroy both colliding objects
            Destroy(collision.gameObject);
            Destroy(gameObject);

            // Instantiate a new object to replace them
            Instantiate(replacementObjectPrefab, transform.position, Quaternion.identity);
        }
    }
}
