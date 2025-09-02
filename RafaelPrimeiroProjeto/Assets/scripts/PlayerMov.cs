using UnityEngine;

public class PlayerMOV : MonoBehaviour
{

    public GameManager Manager;
    public Rigidbody2D corpo;
    public float velocidade = 5f;
    public float velocidadeY = 10f;
    private float inputX;
    private bool noChao = false;

    void Update()
    {
        // Input horizontal (esquerda/direita)
        inputX = Input.GetAxis("Horizontal");

        // Pulo (apenas se estiver no ch�o)
        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            corpo.linearVelocity = new Vector2(corpo.linearVelocity.x, velocidadeY);
            noChao = false; 
        }
    }

    void FixedUpdate()
    {
        // Movimento lateral
        corpo.linearVelocity = new Vector2(inputX * velocidade, corpo.linearVelocity.y);
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chao"))
        {
            noChao = true; // pode pular de novo
        }

        if (collision.gameObject.CompareTag("Espinho"))
        {
            Manager.ColocarPlayerPosicaoInicial();
            
        }
    }
}