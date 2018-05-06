using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewterArm : Allomancer
{

    // Use this for initialization
    void Start()
    {
        isMisting[1] = true;
        mistingIndex = (int)Allomancer.Mistings.PewterArm;
    }

    // Update is called once per frame
    void Update()
    {
        Thug();
    }
}
