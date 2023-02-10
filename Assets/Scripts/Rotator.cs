using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float rotationSpeed = 0.3f;
    public PickerUpper player;
    private bool rotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
        rotate = true;
        }
        else 
        {
        rotate = false;
        }
    }

    //FixedUpdate is used to run at a fixed interval - not related to input
    void FixedUpdate()
    {
        if(player != null)
        {
        if (rotate && player.count >= 3)
            {  
            this.GetComponent<Transform>().Rotate(0, rotationSpeed ,0); //floating point ends in f 
            }
        }   
    }
}


 