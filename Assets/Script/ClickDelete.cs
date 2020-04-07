using UnityEngine;

public class ClickDelete : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
