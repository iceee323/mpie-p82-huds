using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectAmmo : MonoBehaviour
{
    public float ammoLevel;
    AudioSource gs;
    public AudioClip t1_noammo;
    public AudioClip t4_reload;
    public AudioClip t6_gunshot;
    public AudioClip t7_bridge;

    // Start is called before the first frame update
    void Start()
    {
        gs = GetComponent<AudioSource>();
        //crosshair = GetComponent<Image>();
        //Color c = image.color;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && ammoLevel > 0)
        {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f));
            RaycastHit result;
            Physics.Raycast(ray, out result);
            gs.clip = t6_gunshot;
            gs.Play();

            if (result.collider.gameObject.name == "Target")
            {
                GameObject g = result.collider.gameObject;
                Animation a = g.transform.parent.GetComponent<Animation>();
                a.Play("LowerBridge");
                gs.clip = t7_bridge;
                gs.Play();
            }
        }

        else if (Input.GetKey(KeyCode.Mouse0) && ammoLevel <= 0) // && gs != null)
        {
            // Debug.Log("play");
            gs.clip = t1_noammo;
            gs.Play();
        }
        
        /*if (ammoLevel <= 0)
        {
            c.a = 0.3f;
            crosshair.color = c;
            Debug.Log("0");
        }
        else if (ammoLevel >= 1)
        {
            c.a = 1;
            crosshair.color = c;
            Debug.Log("0");
        }*/
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == ("AmmoBox"))
        {
            other.gameObject.SetActive(false);
            ammoLevel += 20;
            gs.clip = t4_reload;
            gs.Play();
        }
    }
}
