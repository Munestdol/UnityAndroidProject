using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image bar;
    public float fill;
    public GameObject deathScreen;
    public CharacterMechanics cm;
    public RandomSpawn randomSpawn;
    

    // Start is called before the first frame update
    void Start()
    {
        fill = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        fill -= Time.deltaTime * 0.1f;
        bar.fillAmount = fill;

        if (fill <= 0)
        {
            cm.speedMove = 0;
            deathScreen.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        //randomSpawn = new RandomSpawn();
        if (other.gameObject.tag == "HPAdd")
        {
            Destroy(other.gameObject);
            fill += 0.3f;
            if (fill > 1)
                fill = 1;
            randomSpawn.countEnemy++;
        }
        
    }
}
