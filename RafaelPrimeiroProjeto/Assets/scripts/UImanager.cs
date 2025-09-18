using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public GameManager manager;
    public TMP_Text textoFase;
    public TMP_Text textoMortes;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void AtualizarTextoFase()
    {
        textoFase.text = manager.faseAtual + "/5";
    }
    public void AtualizarTextoMortes()
    {
        textoMortes.text = "mortes: " + manager.contadorDeMortes;
    }
    public void VoltarAoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
