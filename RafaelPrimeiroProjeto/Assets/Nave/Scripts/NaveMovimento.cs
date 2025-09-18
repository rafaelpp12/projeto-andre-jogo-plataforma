using UnityEngine;

public class NaveMovimento : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocidadeX;
    public float velocidadeY;
    private float inputX;
    private float inputY;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2 (inputX * velocidadeX, inputY * velocidadeY);

    }
}
