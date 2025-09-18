using UnityEngine;

public class NaveCombate : MonoBehaviour
{
    public GameObject tiroNave;
    public float inputTiro;
    public int tempoParaAtirar;
    public int Contador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Contador++;
        inputTiro = Input.GetAxis("Jump");
        Atirar();
    }

    public void Atirar()
    {
        if (Contador >= tempoParaAtirar && inputTiro != 0)
        {
            Instantiate(tiroNave, transform.position, Quaternion.identity );
            Contador = 0;
        }
    }

}


