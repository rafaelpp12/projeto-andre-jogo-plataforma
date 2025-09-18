using Unity.VisualScripting;
using UnityEngine;

public class InimigoMOV : MonoBehaviour
{
    public Rigidbody2D corpo;
    public int velocidadeX;
    public int velocidadeY;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        corpo.linearVelocity = new Vector2(velocidadeX, velocidadeY);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.CompareTag("parede"))
        {
            velocidadeX = velocidadeX * -1;
        }
        if (collision.gameObject.CompareTag("chao"))
        {
            velocidadeY = velocidadeY * -1;
        }    
       


    }
}
