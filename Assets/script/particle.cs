using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
{
    public AudioClip P;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lstick" || other.tag == "Rstick")
        {
            this.GetComponent<AudioSource>().Play();
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
