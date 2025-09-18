using UnityEngine;

public class InimigoMovimento : MonoBehaviour
{
    public Rigidbody2D corpo;
    public int velocidadeY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        corpo.linearVelocity = new Vector2(0, velocidadeY);
    }

    private void OnCollisionEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("tiro"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
}
