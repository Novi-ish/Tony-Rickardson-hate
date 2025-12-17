using UnityEngine;

public class enemySpawn : MonoBehaviour
{

    public GameObject enemyPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))// vad du trycker på för att skjuta
        {
            Instantiate(enemyPrefab, transform.position, transform.rotation);//positionen den firear från
        }
    }
}
