using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetsButton : MonoBehaviour
{
    public GameObject[] TargetArray;

    public void ResetTargets()
    {
        TargetArray = GameObject.FindGameObjectsWithTag("Target");

        foreach (GameObject target in TargetArray) 
        { 
            target.SetActive(true);
        }
    }
}
