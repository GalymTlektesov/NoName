
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public SpriteRenderer[] platforms;
    public Sprite[] platformSprite;

    void Start()
    {
        platforms = GetComponentsInChildren<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        for (int i = 0; i < platforms.Length; i++)
        {
            if (platforms[i].name == "11")
            {
                platforms[i].sprite = platformSprite[0];
            }
            if (platforms[i].name == "10")
            {
                platforms[i].sprite = platformSprite[1];
            }
            if (platforms[i].name == "9")
            {
                platforms[i].sprite = platformSprite[2];
            }
        }
    }
}
