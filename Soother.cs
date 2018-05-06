using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soother : Allomancer
{

    // Use this for initialization
    void Start()
    {
        isMisting[7] = true;
        mistingIndex = (int)Allomancer.Mistings.Soother;
    }

    // Update is called once per frame
    void Update()
    {
        Soothe();
    }
}
