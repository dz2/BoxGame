using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    // Start is called before the first frame update
    //bool isFlat = true;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
    float dirX;
    //float speed = 20f;

    // Update is called once per frame
    // void Update() 
    // {
    //      Vector3 acc = Input.acceleration;
    //      rb.AddForce(0, 0, forwardForce * Time.deltaTime);

    //      rb.AddForce(acc.x * speed, 0, acc.y * speed);

            
    // }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        dirX = Input.acceleration.x * sidewayForce;

        rb.AddForce(dirX * Time.deltaTime,0,0, ForceMode.VelocityChange);

        // if (Input.GetKey("d"))
        // {
        //     rb.AddForce(sidewayForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);
        // }

        // if (Input.GetKey("a"))
        // {
        //     rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        // }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

