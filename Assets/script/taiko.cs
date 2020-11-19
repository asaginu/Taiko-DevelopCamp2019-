using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taiko: MonoBehaviour
{
    public AudioClip t_sound;
    OVRHapticsClip hclip;
    Vector3 speed;
    Rigidbody rigid;
    float dif;
    // Start is called before the first frame update
    void Start()
    {
        hclip = new OVRHapticsClip(t_sound);
    }

    private void OnTriggerEnter(Collider other)
    {
        rigid = other.GetComponent<Rigidbody>();

        dif = rigid.velocity.magnitude/2;
        this.GetComponent<AudioSource>().PlayOneShot(t_sound,dif);

        if(other.gameObject.tag == "Rstick")
            OVRHaptics.RightChannel.Mix(hclip);
        if(other.gameObject.tag == "Lstick")
            OVRHaptics.LeftChannel.Mix(hclip);
    }

}