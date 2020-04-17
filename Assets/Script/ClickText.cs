using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickText : MonoBehaviour
{
    private RectTransform rect;
    private Text text;
    public float speed;
    public PlayerController player;
    private bool isEnd = false;

    private void Start()
    {
        rect = GetComponent<RectTransform>();
        text = GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isEnd)
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }

    private void OnMouseDown()
    {
        isEnd = true;
        player.enabled = false;
        rect.anchorMax = new Vector2(1, 1);
        text.fontSize = 150;
    }
}
