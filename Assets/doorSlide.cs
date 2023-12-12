using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorSlide : MonoBehaviour
{
    AudioSource gs;
    public AudioClip t2_dooropen;

    // Start is called before the first frame update
    void Start()
    {
        gs = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        GameObject parent = transform.parent.gameObject;
        Animation animation = parent.GetComponent<Animation>();
        animation.Play("OpenDoor");
        gs.clip = t2_dooropen;
        gs.Play();
    }
}
