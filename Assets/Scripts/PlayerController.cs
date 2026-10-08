using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private int speed = 5;
    private int jumpPower = 10;
    [SerializeField] GameObject player;

    private void Start()
    {
        rigidbody = player.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        updateMovement();
    }

    private void updateMovement()
    {
        if (Input.GetKeyDown(KeyCode.D)) {
            rigidbody.AddForceX(speed);
        }  else if (Input.GetKeyDown(KeyCode.A))
        {
            rigidbody.AddForceX(-speed);
        } else if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.linearVelocityX = jumpPower;
        }
    }
}
