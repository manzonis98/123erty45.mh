using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;

    void Start()
    {
        rb.AddForce(1000 * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
