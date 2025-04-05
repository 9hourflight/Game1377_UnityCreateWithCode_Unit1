using UnityEngine;

public class AIController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private float vehicleSpeed;
    private float lifeTime = 10f;
    void Start()
    {
        Destroy(this.gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector3.forward * vehicleSpeed) * Time.deltaTime);
    }
}
