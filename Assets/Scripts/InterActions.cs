using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterActions : MonoBehaviour
{
    private int Score;
    private Text ScoreTXT;
    private Text ScoreTXT1;

    public bool StartBool;

    public GameObject Camera;
    public GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
        ScoreTXT = GameObject.Find("Score").GetComponent<Text>();
        ScoreTXT1 = GameObject.Find("Score (1)").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            StartB();
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void AddScore(int Addition)
    {
        Score += Addition;
        ScoreTXT.text = Score.ToString();
        ScoreTXT1.text = Score.ToString();
    }

    public void StartB()
    {
        StartBool = true;
        Camera.GetComponent<Animator>().SetTrigger("Start");
        UI.GetComponent<Animator>().SetTrigger("Start");
    }
}
