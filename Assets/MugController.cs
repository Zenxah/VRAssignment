using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    

        void
    Update()
    {
        if (Input.GetButtonDown("XRI_Right_TriggerButton"))
            {
                Debug.Log("Trigger down");
            }
            else if
            (Input.GetButtonUp("XRI_Right_TriggerButton"))
            {
                Debug.Log("Trigger up");
            }
    }
}