using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public float speed = 1000f;

    void Start()
    {
        rb.AddForce(speed * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
