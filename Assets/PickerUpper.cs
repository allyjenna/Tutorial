using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerUpper : MonoBehaviour
{
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Pickup"))
        {
            GameObject.Destroy(collision.collider.gameObject);

            count = count + 1;
            Debug.Log("Pickup counter: " + count);

            this.GetComponent<AudioSource>().Play();

            Debug.Log(count);
        }
    }
}
