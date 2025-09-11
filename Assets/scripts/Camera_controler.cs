using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_controler : MonoBehaviour
{
    [SerializeField] float mouseSensitive = 100f;

    Transform playerBody;
    float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerBody = transform.parent;
    }

    void Update()
    {
        CameraRotation();
    }
    void CameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitive * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitive * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 80f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
