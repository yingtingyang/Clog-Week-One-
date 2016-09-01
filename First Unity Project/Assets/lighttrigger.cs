using UnityEngine;
using System.Collections;

public class lighttrigger : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // when something enters the Trigger attached to this game object
    void OnTriggerEnter()
    {
        // get the light attached to this object
        // turn that light on
        GetComponent<Light>().enabled = true;
        GetComponent<Light>().color = Color.cyan;
    }
    void OnTriggerExit()
    {
        //turn the light off when you leave
        GetComponent<Light>().enabled = true;
        GetComponent<Light>().color = Color.red;
    }
}

