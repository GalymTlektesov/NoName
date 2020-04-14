using UnityEngine;

public class LiftScript : MonoBehaviour
{
    public Vector2[] Points;
    private Transform _plat;
    public float speed;
    public int number = 0;

    private void Start()
    {
        _plat = GetComponent<Transform>();
        Points[0] = _plat.position;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Points[number], speed);

        if(transform.position.x == Points[number].x && transform.position.y == Points[number].y)
        {
            number++;
            if(number == Points.Length)
            {
                number = 0;
            }
        }
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        coll.transform.parent = transform;
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        coll.transform.parent = null;
    }
}
