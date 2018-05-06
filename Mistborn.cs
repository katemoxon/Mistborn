using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mistborn : Allomancer
{
	// Use this for initialization
	void Start ()
    {
        isMistborn = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        BurnTin();
        Thug();
        Shoot();
        Lurch();

        Seek();
        CopperCloud();
        Riot();
        Soothe();
    }
}
