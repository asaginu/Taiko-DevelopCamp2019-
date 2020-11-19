using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newtaiko: MonoBehaviour
{
	public AudioClip s1;
	public AudioClip s2;
	AudioSource audiosource;

	OVRHapticsClip hclip;
	Vector3 speed;
	Rigidbody rigid;
	float dif;

    public GameObject Par;
	// Start is called before the first frame update
	void Start()
	{
        
    }

	private void OnTriggerEnter(Collider other)
	{
		rigid = other.GetComponent<Rigidbody>();
        Instantiate(Par);
        dif = rigid.velocity.magnitude / 2.0f;
		if (dif >= 1.0f)
		{
            hclip = new OVRHapticsClip(s1);
            if (other.gameObject.tag == "Rstick")
                OVRHaptics.RightChannel.Mix(hclip);
            if (other.gameObject.tag == "Lstick")
                OVRHaptics.LeftChannel.Mix(hclip);
            this.GetComponent<AudioSource>().PlayOneShot(s1, 1.0f);
		}
		else
		{
            hclip = new OVRHapticsClip(s2);
            if (other.gameObject.tag == "Rstick")
                OVRHaptics.RightChannel.Mix(hclip);
            if (other.gameObject.tag == "Lstick")
                OVRHaptics.LeftChannel.Mix(hclip);
            this.GetComponent<AudioSource>().PlayOneShot(s2, dif);
		}
	}

}
