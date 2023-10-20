using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNew : MonoBehaviour
{
    public GameObject prefabToCreate;  
    private Vector3 offset;
        private bool isDragging = false;

        private void OnMouseDown()
        {
            offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isDragging = true;

            // Create a new object when dragging starts.
            Instantiate(prefabToCreate, transform.position, Quaternion.identity);
        }

        private void OnMouseOver()
        {
            isDragging = false;
        }

        private void Update()
        {
            if (isDragging)
            {
                Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
                transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
            }
        }
}
