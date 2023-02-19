using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingChicken : MonoBehaviour
{
    private Rigidbody rb;
    private Animator anim;

    public int Speed;

    public float[] Speeds;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        anim.SetBool("Run", true);

        Speed = Random.Range(0,3);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0,0, Speeds[Speed]);
    }
}
