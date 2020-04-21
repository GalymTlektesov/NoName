using UnityEngine;

public class MouseController : MonoBehaviour
{
    public int sceneName = 5;
    public float speed = 2.5f;
    private static bool key;


    private void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(mousePos.x, mousePos.y), speed * Time.deltaTime);
    }
}
