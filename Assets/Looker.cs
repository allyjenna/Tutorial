using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
     this.GetComponent<Transform>().LookAt(target.transform); //looking for position
     this.transform.Translate(new Vector3(0, 0, 0.01f), Space.Self); // translation towards the player  

    }
    
}
