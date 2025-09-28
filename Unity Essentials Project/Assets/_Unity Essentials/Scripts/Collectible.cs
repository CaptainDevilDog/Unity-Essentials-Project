using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float rotationSpeed;
    public GameObject OnCollectEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotationSpeed,0);
    }


    private void OnTriggerEnter(Collider other)
    {
        //Destroy collectible on player collision
        Destroy(gameObject);

        //Instantiate effect on collectible collection
        Instantiate(OnCollectEffect, transform.position, transform.rotation);
    }

}

