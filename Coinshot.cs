using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinshot : Allomancer
{

    // Use this for initialization
    void Start()
    {
        isMisting[2] = true;
        mistingIndex = (int)Allomancer.Mistings.Coinshot;
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
}
