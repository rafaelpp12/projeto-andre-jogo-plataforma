using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject posicaoPlayerFase2;

    public GameObject posicaoCameraFase2;

    public GameObject cam;

    public Vector2 posicaoPlayerInicial;

    public int contadorDeMortes;

    public int faseAtual;

    public PlayerMOV player;

    public UImanager uiManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ColocarPlayerPosicaoInicial();
        uiManager.AtualizarTextoFase();
        uiManager.AtualizarTextoMortes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ColocarPlayerPosicaoInicial()
    {
        player.gameObject.transform.position = posicaoPlayerInicial;
    }
    public void AtualizarMortePlayer()
    {
        contadorDeMortes++;
        uiManager.AtualizarTextoMortes();
        ColocarPlayerPosicaoInicial();
    }
    public void passarDeFase()
    {
        faseAtual++;
        switch(faseAtual)
        {
            case 2:
                IrParaFase2();
                break;
        }
    }


    public void IrParaFase2()
    {
        //teletransportando o player
        player.gameObject.transform.position = posicaoPlayerFase2.transform.position;

        //teletransportando a camera
        cam.transform.position = posicaoCameraFase2.transform.position;

        //mudando local de renacimento
        posicaoPlayerInicial = posicaoPlayerFase2.transform.position;
    }


}
