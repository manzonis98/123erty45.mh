using UnityEngine;

public class Movimento : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 movement;
    public float speed = 1f;
    // Start is called before the first frame update
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    /*void FixedUpdate()
    {
        rb.MovePosition(rb.position+movement*speed*Time.fixedDeltaTime);
    }*/

    //Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(movement*speed*Time.fixedDeltaTime,ForceMode2D.Force);
    }
}
