using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public float mouseSens = 100f;

    float xRot = 0f;
    float yRot = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;    
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRot -= mouseY;

        xRot = Mathf.Clamp(xRot, -90f, 90f);

        yRot += mouseX;

        transform.localRotation = Quaternion.Euler(xRot, yRot, 0f);
    }
}
