using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // units per second

    private Rigidbody rb;
    private Vector3 input;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("PlayerController requires a Rigidbody component.");
            enabled = false;
            return;
        }
    }

    void Update()
    {
        // Read input in Update for responsiveness
        input.x = Input.GetAxis("Horizontal");
        input.y = 0f;
        input.z = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        // Apply movement in FixedUpdate for consistent physics behaviour
        Vector3 displacement = input * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + displacement);
    }
}
//using UnityEngine;

//public class PlayerMovement : MonoBehaviour
//{
//    public float speed = 10f;

//    void Update()
//    {
//        float h = Input.GetAxis("Horizontal"); // A/D or Left/Right
//        float v = Input.GetAxis("Vertical");   // W/S or Up/Down

//        Vector3 direction = new Vector3(h, 0, v).normalized;

//        transform.Translate(direction * speed * Time.deltaTime, Space.World);
//    }
//}
