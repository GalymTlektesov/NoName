using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;
    public float xMin = -0.53f;
    public float xMax = 1.71f;
    private float distance;

    void Start()
    {
        distance = player.position.x - transform.position.x;
    }

    void Update()
    {
        transform.position = new Vector3(player.position.x - distance, transform.position.y, -10.0f);
        if (transform.position.x < xMin)
        {
            transform.position = new Vector3(xMin, transform.position.y, -10.0f);
        }
        if (transform.position.x > xMax)
        {
            transform.position = new Vector3(xMax, transform.position.y, -10.0f);
        }
    }
}
