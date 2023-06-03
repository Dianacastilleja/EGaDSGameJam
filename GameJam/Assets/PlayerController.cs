using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Camera cam;
    private Vector3 lastMousePosition;
// this is a note to see if Unity will finally recognize the file. It be acting sus for some reason 
    void Start()
    {
        lastMousePosition = Input.mousePosition;
    }

    void Update()
    {
        // Check if the mouse has moved
        if (Input.mousePosition != lastMousePosition)
        {
            // Update the last mouse position
            lastMousePosition = Input.mousePosition;

            // Cast a ray from the mouse position into the world
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Get the position on the ground where the ray hit
                Vector3 targetPos = new Vector3(hit.point.x, transform.position.y, hit.point.z);

                // Calculate the direction from the player's current position to the target position
                Vector3 direction = targetPos - transform.position;

                // Normalize the direction vector to get a unit direction
                direction.Normalize();

                // Calculate the target position based on the direction and speed
                Vector3 moveTarget = transform.position + direction * speed * Time.deltaTime;

                // Move the player towards the target position
                transform.position = moveTarget;
            }
        }
    }
}
