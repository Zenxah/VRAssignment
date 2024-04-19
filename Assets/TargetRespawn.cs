using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRespawn : MonoBehaviour
{
    public GameObject targetPref1;
    public GameObject targetPref2;
    public GameObject targetPref3;
    public GameObject targetPref4;
    public GameObject targetPref5;
    public GameObject targetPref6;
    public GameObject targetPref7;
    public GameObject targetPref8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespawnTargets()
    {
        targetPref1.SetActive(true);
        targetPref2.SetActive(true);
        targetPref3.SetActive(true);
        targetPref4.SetActive(true);
        targetPref5.SetActive(true);
        targetPref6.SetActive(true);
        targetPref7.SetActive(true);
        targetPref8.SetActive(true);
    }
}
