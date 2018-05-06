using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeker : Allomancer
{

    // Use this for initialization
    void Start()
    {
        isMisting[4] = true;
        mistingIndex = (int)Allomancer.Mistings.Seeker;
    }

    // Update is called once per frame
    void Update()
    {
        Seek();
    }
}
