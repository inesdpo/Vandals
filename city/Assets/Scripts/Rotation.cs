using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public float inputSmoothing = 0.1f;

    private Vector3 currentRotation;

    private void Start()
    {
        currentRotation = transform.localEulerAngles;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Apply smoothing
        mouseX *= inputSmoothing;
        mouseY *= inputSmoothing;

        currentRotation.y += mouseX * rotationSpeed;
        currentRotation.x -= mouseY * rotationSpeed;

        // Clamp the rotation if needed
        currentRotation.x = Mathf.Clamp(currentRotation.x, -90f, 90f);

        // Apply the new rotation
        transform.localEulerAngles = currentRotation;
    }
}