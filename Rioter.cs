using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rioter : Allomancer
{

    // Use this for initialization
    void Start()
    {
        isMisting[6] = true;
        mistingIndex = (int)Allomancer.Mistings.Rioter;
    }

    // Update is called once per frame
    void Update()
    {
        Riot();
    }
}
