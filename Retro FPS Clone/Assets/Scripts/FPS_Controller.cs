using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Controller : MonoBehaviour
{
    public static FPS_Controller instance;

    [Header("Controller")]
    public float moveSpeed;
    public float mouseSensitivity = 1.0f;
    private Rigidbody rb;
    private Vector3 moveInput;
    private Vector2 mouseInput;

    public Camera viewCam;

    [Header("Ammo")]
    public GameObject bulletImpact;
    public int currentAmmo;

    private void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Hide and Lock cursor
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 moveH = transform.right * moveInput.x; // Blending movement for diagonal movement
        Vector3 moveV = transform.forward * moveInput.z; // See above note
        rb.velocity = (moveH + moveV) * moveSpeed;

        mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * mouseSensitivity;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - mouseInput.x, transform.rotation.eulerAngles.z);
        
     if(Input.GetMouseButtonDown(0))
        {
         if(currentAmmo > 0)
         {
            Ray ray = viewCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f));
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                print("You hit" + hit.transform.name);
                Instantiate(bulletImpact, hit.point, transform.rotation);
            }
            else
            {
                print("You Missed, didn't hit a thing");
            }

            currentAmmo --;
         }
    
        }
    }
}
