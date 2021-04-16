using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject enemy;
    public int countEnemy;
    private float randomCoord = 15f;

    // Start is called before the first frame update
    private void Start()
    {
        countEnemy = 20;
    }
 

    // Update is called once per frame
    void Update()
    {       
            while (countEnemy>0)
            {
                Vector3 vector = new Vector3(Random.Range(-randomCoord, randomCoord), 10, (Random.Range(-randomCoord, randomCoord)));
                Instantiate(enemy, vector, Quaternion.identity);
                countEnemy--;
            }
    }
}
