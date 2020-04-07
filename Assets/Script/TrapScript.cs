using UnityEngine;

public class TrapScript : MonoBehaviour
{
    public SpriteRenderer[] traps;
    public Sprite trapSpite;

    void Start()
    {
        traps = GetComponentsInChildren<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        for (int i = 0; i < traps.Length; i++)
        {
            traps[i].sprite = trapSpite;
        }
    }
}
