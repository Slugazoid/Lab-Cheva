using UnityEngine;

public class playerCamera : MonoBehaviour
{
    [SerializeField] public float mouseSensitivity;
    public Transform playerBody;
    float xRotation = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        camera();
    }

    public void camera()
    {
        if (Input.GetMouseButton(1))
        {

            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * 1.5f;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * 1.5f;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}
