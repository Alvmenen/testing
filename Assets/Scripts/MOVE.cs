using UnityEngine;

public class MOVE : MonoBehaviour
{
    [SerializeField] float forceforward;
    [SerializeField] float forceRight;
    public float jumpForce;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float forceX = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.right * forceX * forceRight);

        float forceY = Input.GetAxis("Vertical");
        rb.AddForce(Vector3.forward * forceY * forceforward);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    } 
}
