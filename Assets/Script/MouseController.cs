using UnityEngine;

public class MouseController : MonoBehaviour
{
    public Transform player;
    public int sceneName = 5;
    public float speed = 2.5f;


    private void OnMouseDown()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        player.position = Vector2.Lerp(player.position, new Vector2(mousePos.x, mousePos.y), speed * Time.deltaTime);
    }
}
