using UnityEngine;

//Controller for player movement and interactions
public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Movement speed
    public float rotationSpeed = 120.0f; // Rotation speed
    public float jumpForce =  5.0f; // Jump force

    private Rigidbody rb; // Reference to the Rigidbody component

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }

    private void FixedUpdate()
    {
        // Move player based on input
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movment = transform.forward * moveVertical * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movment);

        // Rotate player based on input
        float turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);


    }
}