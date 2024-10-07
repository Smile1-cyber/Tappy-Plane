using UnityEngine;
using TMPro;
<<<<<<< HEAD
=======

>>>>>>> 066f53e882c41c0c1cad4260f770de9f154a0537
[RequireComponent(typeof(Rigidbody2D))]
public class Fly : MonoBehaviour
{
    public float jumpForce = 10;
    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI scoreText;

    private Rigidbody2D rb;
    private int points = 0;

    private void Start() 
    {
        //Get Component - access any component on the game object
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if(rb.velocity.y < 0)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }

        //animations
        if(rb.velocity.y > 0)
        {
            //quaternion is a way to represent rotation in 3D space
            //quaternion.Euler is a way to create a quaternion from euler angles
            transform.rotation = Quaternion.Euler(0, 0, 30);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, -30);
        }
    }

<<<<<<< HEAD
   private void OnTriggerExit2D(Collision2D other)
=======

    private void OnTriggerExit2D(Collider2D other) 
>>>>>>> 066f53e882c41c0c1cad4260f770de9f154a0537
    {
        scoreText.text = (++points).ToString("D4");
    }
}
