using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] Vector3 angV, torque;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.angularVelocity = angV;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            rb.AddTorque(torque);
        }
        else if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
