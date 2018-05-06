using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lurcher : Allomancer
{

    // Use this for initialization
    void Start()
    {
        isMisting[3] = true;
        mistingIndex = (int)Allomancer.Mistings.Lurcher;
    }

    // Update is called once per frame
    void Update()
    {
        Lurch();
    }
}
