using UnityEngine;
using UnityEngine.UI;

public class HintScript : MonoBehaviour
{
    public Text Hint;
    public string text;
    public float life;
    private float alive;

    private void Start()
    {
        alive = 0;
    }

    private void OnMouseDown()
    {
        alive = life;
        Hint.text = text;
    }

    private void Update()
    {
        alive -= Time.deltaTime;
        if (alive < 1)
        {
            alive = 0;
            Hint.text = "";
        }
    }
}
