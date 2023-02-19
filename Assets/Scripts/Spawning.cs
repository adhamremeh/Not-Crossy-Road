using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    private float Timer;
    public float TImerThrust;
    public float TimerDiff;

    public int Place;

    public GameObject[] SpawnPlaces;

    public GameObject[] SpawnArrows;

    public GameObject Chicken;

    // Start is called before the first frame update
    void Start()
    {
        Timer = TImerThrust;
    }

    // Update is called once per frame
    void Update()
    {
        if (!FindObjectOfType<InterActions>().StartBool)
            return;
        if (Timer > 0)
        {
            Timer -= TimerDiff;
        }
        else 
        {
            Place = Random.Range(0, 10);
            Instantiate(Chicken, SpawnPlaces[Place].GetComponent<Transform>());
            for (int i = 0; i < 10; i++)
            {
                if (i == Place)
                    SpawnArrows[Place].SetActive(true);
                else
                    SpawnArrows[i].SetActive(false);
            }   
            Timer = TImerThrust;
        }

    }
}
