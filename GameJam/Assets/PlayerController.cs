using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // public float speed;
    // public Camera cam;
    // private Vector3 lastMousePosition;

    // void Start()
    // {
    //     lastMousePosition = Input.mousePosition;
    // }

    // void Update()
    // {
    //     // Check if the mouse has moved
    //     if (Input.mousePosition != lastMousePosition)
    //     {
    //         // Update the last mouse position
    //         lastMousePosition = Input.mousePosition;

    //         // Cast a ray from the mouse position into the world
    //         Ray ray = cam.ScreenPointToRay(Input.mousePosition);
    //         RaycastHit hit;

    //         if (Physics.Raycast(ray, out hit))
    //         {
    //             // Get the position on the ground where the ray hit
    //             Vector3 targetPos = new Vector3(hit.point.x, transform.position.y, hit.point.z);

    //             // Calculate the direction from the player's current position to the target position
    //             Vector3 direction = targetPos - transform.position;

    //             // Normalize the direction vector to get a unit direction
    //             direction.Normalize();

    //             // Calculate the target position based on the direction and speed
    //             Vector3 moveTarget = transform.position + direction * speed * Time.deltaTime;

    //             // Move the player towards the target position
    //             transform.position = moveTarget;
    //         }
    //     }
    // }
// public float speed;
// public Camera cam;
// private Vector3 lastMousePosition;
// private Animator animator;

// void Start()
// {
//     lastMousePosition = Input.mousePosition;
//     animator = GetComponent<Animator>();
// }

// void Update()
// {
//     // Check if the mouse has moved
//     if (Input.mousePosition != lastMousePosition)
//     {
//         // Update the last mouse position
//         lastMousePosition = Input.mousePosition;

//         // Cast a ray from the mouse position into the world
//         Ray ray = cam.ScreenPointToRay(Input.mousePosition);
//         RaycastHit hit;

//         if (Physics.Raycast(ray, out hit))
//         {
//             // Get the position on the ground where the ray hit
//             Vector3 targetPos = new Vector3(hit.point.x, transform.position.y, hit.point.z);

//             // Calculate the direction from the player's current position to the target position
//             Vector3 direction = targetPos - transform.position;

//             // Normalize the direction vector to get a unit direction
//             direction.Normalize();

//             // Calculate the target position based on the direction and speed
//             Vector3 moveTarget = transform.position + direction * speed * Time.deltaTime;

//             // Move the player towards the target position
//             transform.position = moveTarget;

//             // Set the IsRunning parameter in the animator to true
//             animator.SetBool("isRunning", true);
//         }
//         else
//         {
//             // Set the IsRunning parameter in the animator to false
//             animator.SetBool("isRunning", false);
//         }
//     }
// }

public float speed;
public Camera cam;
private Vector3 lastMousePosition;
private Animator animator;

void Start()
{
    lastMousePosition = Input.mousePosition;
    animator = GetComponent<Animator>();
}

void Update()
{
    // Check if the left mouse button is clicked
    if (Input.GetMouseButtonDown(0))
    {
        // Change the animation to "Attack"
        animator.SetTrigger("isAttacking");
    }

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

            // Set the IsRunning parameter in the animator to true
            animator.SetBool("isRunning", true);
        }
        else
        {
            // Set the IsRunning parameter in the animator to false
            animator.SetBool("isRunning", false);
        }
    }
}
}