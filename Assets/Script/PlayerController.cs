using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float nextJump;
    public float delayJump;
    private Rigidbody2D rb;
    private bool isAir;
    private static bool key;
    public int sceneName = 0;
     
    void Start()
    {
        key = false;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
    }

    private void Update()
    {
        bool jump = Time.time > nextJump;
        if (Input.GetKeyDown(KeyCode.Space) && !isAir && jump)
        {
            Jump();
        }
    }

    private void Jump()
    {
        isAir = true;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        nextJump = delayJump + Time.time;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isAir = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Respawn"))
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
            key = false;
        }
        if (collision.CompareTag("Key"))
        {
            key = true;
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Door") && key)
        {
            SceneManager.LoadScene(++sceneName, LoadSceneMode.Single);
            key = false;
        }
    }
}
