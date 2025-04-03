using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private float vehicleSpeed;
    [SerializeField]
    private float turnSpeed;
    [SerializeField]
    private float horizontalInput;
    [SerializeField]
    private float verticalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate((Vector3.forward * vehicleSpeed) *Time.deltaTime * verticalInput);
        transform.Translate((Vector3.right * turnSpeed) * Time.deltaTime *horizontalInput);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
    }
}
