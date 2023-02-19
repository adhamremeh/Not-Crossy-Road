using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickenCotroller : MonoBehaviour
{
    
    public GameObject Feather;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            FindObjectOfType<InterActions>().AddScore(1);
            GameObject Feathers = Instantiate(Feather, transform.parent);
            Feathers.transform.position = transform.position;
            //Feathers.transform.parent = null;
            Destroy(gameObject);
        }
    }

}
