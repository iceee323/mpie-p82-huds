using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammoText : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ammoVal = player.GetComponent<collectAmmo>().ammoLevel;
        Text text = GetComponent<ammoText>();
    }

}
