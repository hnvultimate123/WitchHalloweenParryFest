using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parry : MonoBehaviour
{

    public GameObject objectToActivateAndDeactivate;

    // Start is called before the first frame update
    void Start()
    {
        objectToActivateAndDeactivate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //objectToActivateAndDeactivate.SetActive(false);
        if (Input.GetKeyDown("space"))
        {
            objectToActivateAndDeactivate.SetActive(true);
        }
    }
}
