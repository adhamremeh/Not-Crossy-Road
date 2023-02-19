using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawningCar : MonoBehaviour
{

    public GameObject Car;
    public GameObject Car2;

    public GameObject ImageNum1;
    public GameObject ImageCar1;

    public GameObject ImageNum2;
    public GameObject ImageCar2;

    private bool Car1 = true;

    public Color Choice;   
    public Color NotChoice;

    public GameObject[] CarPlaces;

    public GameObject[] CarArrows;

    private int CarIndex = 0;

    private float Timer;
    public float TImerThrust;
    public float TimerDiff;

    // Start is called before the first frame update
    void Start()
    {
        GameObject StartCar = Instantiate(Car, CarPlaces[2].transform);
        StartCar.transform.localPosition = new Vector3(-1.3f, StartCar.transform.localPosition.y, 31.2f);
        Timer = TImerThrust;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            CarIndex += 1;
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            CarIndex -= 1;
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
            Car1 = true;
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            Car1 = false;

        if (Car1)   
        {
            ImageCar1.GetComponent<RawImage>().color = Choice;
            ImageNum1.GetComponent<RawImage>().color = Choice;
            ImageCar2.GetComponent<RawImage>().color = NotChoice;
            ImageNum2.GetComponent<RawImage>().color = NotChoice;
        }
        else
        {
            ImageCar2.GetComponent<RawImage>().color = Choice;
            ImageNum2.GetComponent<RawImage>().color = Choice;
            ImageCar1.GetComponent<RawImage>().color = NotChoice;
            ImageNum1.GetComponent<RawImage>().color = NotChoice;
        }


        if (CarIndex > 2)
            CarIndex = 2;
        else if (CarIndex < 0)
            CarIndex = 0;

        for (int i = 0; i < 3; i++)
        {
            if (i == CarIndex)
                CarArrows[i].SetActive(true);
            else
                CarArrows[i].SetActive(false);
        }

        if (Timer > 0)
        {
            Timer -= TimerDiff;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Timer < 0)
            {
                if (Car1)
                    Instantiate(Car, CarPlaces[CarIndex].transform);
                else
                    Instantiate(Car2, CarPlaces[CarIndex].transform);
                Timer = TImerThrust;
            }
        }
    }
}
