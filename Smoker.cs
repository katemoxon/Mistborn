using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoker : Allomancer
{

    // Use this for initialization
    void Start()
    {
        isMisting[5] = true;
        mistingIndex = (int)Allomancer.Mistings.Smoker;
    }

    // Update is called once per frame
    void Update()
    {
        CopperCloud();
    }
}
