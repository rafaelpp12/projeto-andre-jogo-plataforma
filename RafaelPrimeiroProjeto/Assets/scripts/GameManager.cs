using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector2 posicaoPlayerInicial;

    public int contadorDeMortes;

    public int faseAtuaL;

    public PlayerMOV player; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ColocarPlayerPosicaoInicial();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ColocarPlayerPosicaoInicial()
    {
        player.gameObject.transform.position = posicaoPlayerInicial;
    }


}
