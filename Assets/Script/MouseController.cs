using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseController : MonoBehaviour
{
    public int sceneName = 5;
    public float speed = 2.5f;
    private static bool key;


    private void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.Lerp(transform.position, new Vector2(mousePos.x, mousePos.y), speed * Time.deltaTime);
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
