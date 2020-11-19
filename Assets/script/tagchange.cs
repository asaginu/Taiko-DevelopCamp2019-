using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tagchange : MonoBehaviour
{
	OVRGrabber obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public OVRGrabber grabbedBy
    {
        get { return obj; }
    }
    void Updata()
	{
		if (obj.tag == "Lcon") this.tag = "Lstick";
		if (obj.gameObject.tag == "Rcon") this.tag = "Rstick";
	}
}
