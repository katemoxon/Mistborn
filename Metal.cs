using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metal : MonoBehaviour
{
    public enum MetalTypes
    {
        Tin,
        Pewter,
        Steel,
        Iron,

        Bronze,
        Copper,
        Zinc,
        Brass,

        Count,
    };
    
    public bool[] types;  //set to 8 in unity
    public int type;

	// Use this for initialization
	void Start ()
    {
	    type = Random.Range(0, types.Length);   //spawn as a random metal
        types[type] = true;

        Debug.Log("type = " + type);
    }
	
	// Update is called once per frame
	void Update ()
    {

	}
}
