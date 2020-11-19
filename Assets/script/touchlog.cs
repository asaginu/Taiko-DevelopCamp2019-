using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchlog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		Debug.Log("start");
    }


    private void OnTriggerEnter(Collider other)
    {
		Debug.Log("touch");
    }

}
