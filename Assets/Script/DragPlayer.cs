using UnityEngine;

public class DragPlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool isDrag = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDrag()
    {
        isDrag = true;
    }

    private void OnMouseUp()
    {
        isDrag = false;
    }

    private void FixedUpdate()
    {
        if (isDrag)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            rb.MovePosition(mousePos + rb.position * Time.fixedDeltaTime);
        }
    }
}
