using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject inimigo;
    public int tempoSpawn;
    public int temporizador;
 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawnar();
        temporizador++;
    }

    public void Spawnar()
    {
        if (temporizador >= tempoSpawn)
        {
            Instantiate(inimigo, new Vector2(Random.RandomRange(-8, 8), 3), Quaternion.identity);
            temporizador = 0;
        }

    }

}
