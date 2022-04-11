using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Controller : MonoBehaviour
{
    [Header("Controller")]
    public float moveSpeed;
    public float mouseSensitivity = 1.0f;
    private Rigidbody rb;
    private Vector3 moveInput;
    private Vector2 mouseInput;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Hide and Lock cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 moveH = transform.right * moveInput.x;
        Vector3 moveV = transform.forward * moveInput.z;
        rb.velocity = (moveH + moveV) * moveSpeed;

        mouseInput = new Vector2(Input.GetAxis("Mouse x"), Input.GetAxis("Mouse Y")) * mouseSensitivity;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - mouseInput.x, transform.rotation.eulerAngles.z);
    }
}
