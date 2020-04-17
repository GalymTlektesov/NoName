using UnityEngine;
using UnityEngine.UI;

public class KeyText : MonoBehaviour
{
    public Text text;

    private void Start()
    {
        text.gameObject.active = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        text.gameObject.active = true;
    }
}
