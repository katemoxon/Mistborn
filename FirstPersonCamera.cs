using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity;
    public Transform player;

    float xAxisClamp = 0.0f;

    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float rotX = mouseX * mouseSensitivity;
        float rotY = mouseY * mouseSensitivity;

        xAxisClamp -= rotY;

        Vector3 targetRotLook = transform.rotation.eulerAngles;
        Vector3 targetRotPlayer = player.rotation.eulerAngles;

        targetRotLook.x -= rotY;
        targetRotPlayer.y += rotX;
        targetRotLook.z = 0;

        if (xAxisClamp > 90)
        {
            xAxisClamp = 90;
            targetRotLook.x = 90;
        }
        else if (xAxisClamp < -90)
        {
            xAxisClamp = -90;
            targetRotLook.x = 270;
        }

        transform.rotation = Quaternion.Euler(targetRotLook);
        player.rotation = Quaternion.Euler(targetRotPlayer);
    }
}
