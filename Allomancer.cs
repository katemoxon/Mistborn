using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Allomancer : MonoBehaviour
{
    //PLAYER
    protected bool isMistborn;
    public Transform lasso;
    public Light light;

    //ENEMY MISTINGS
    [SerializeField] protected bool[] isMisting = new bool[8];

    protected int mistingIndex;
    protected enum Mistings
    {
        TinEye,     //enhanced senses
        PewterArm,  //enhanced strength
        Coinshot,   //telekinetic push on metals
        Lurcher,    //telekinetic pull on metals

        Seeker,     //detects allomancy
        Smoker,     //hides allomancy
        Rioter,     //inflames emotion
        Soother,    //soothes emotion

        Count,
    }
    
    
    private Metal node = new Metal();
    private Metal weapon = new Metal();

    //METALS - TIN | PEWTER | STEEL | IRON | BRONZE | COPPER | ZINC | BRASS
    [SerializeField] protected float[] metalStores = new float[8];

    public float baseStrength;
    public float baseSpeed;

    // Use this for initialization
    void Start()
    {
        light = GetComponent<Light>();

        for (int i = 0; i < metalStores.Length; i++)
            metalStores[i] = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected bool CanInteract()
    {
        if (isMistborn)     //mistborn can use all metals
            return true;
        else
            for (int i = 0; i < (int)Metal.MetalTypes.Count; i++)
                if (mistingIndex == node.type)     //mistings will be able to use their 'type' of metal
                    return true;
                else
                    return false;

        return false;
    }





    protected void BurnTin()
    {
        bool burning = false;
        float originalIntensity = light.intensity;

        if (isMistborn | mistingIndex == 0)
        {
            if (metalStores[(int)Mistings.TinEye] > 0)
            {
                if (Input.GetKey(KeyCode.T) && !burning)    //add a player check so AI can automatically burn their metals
                {
                    light.intensity *= 1.5f;
                    burning = true;

                    while (burning)
                    {
                        metalStores[(int)Mistings.TinEye] -= 0.1f / Time.deltaTime;
                        if (metalStores[(int)Mistings.TinEye] <= 0)
                        {
                            light.intensity = originalIntensity;
                            burning = false;
                        }
                    }
                }

                if (Input.GetKey(KeyCode.T) && burning)
                {
                    light.intensity = originalIntensity;
                    burning = false;
                }
            }
        }
    }


    protected void Thug()
    {
        bool burning = false;

        if (isMistborn | mistingIndex == 1)
        {
            if (Input.GetKey(KeyCode.Alpha1) && !burning)
            {
                if (metalStores[(int)Mistings.PewterArm] > 0)
                {
                    baseStrength *= 3.5f;
                    baseSpeed *= 3.5f;

                    burning = true;

                    while (burning)
                    {
                        metalStores[(int)Mistings.PewterArm] -= 0.1f / Time.deltaTime;
                        if (metalStores[(int)Mistings.PewterArm] <= 0)
                        {
                            baseStrength /= 3.5f;
                            baseSpeed /= 3.5f;

                            burning = false;
                        }

                    }
                }
            }
            else if (Input.GetKey(KeyCode.Alpha1) && burning)
            {
                baseStrength /= 3.5f;
                baseSpeed /= 3.5f;

                burning = false;
            }
        }
    }

    protected void Shoot()
    {
        if (isMistborn | mistingIndex == 2)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                






            }
        }
    }

    protected void Lurch()
    {
        if (isMistborn | mistingIndex == 3)
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                Instantiate(lasso, transform.position, lasso.rotation);






            }
        }
    }

    protected void Seek()
    {
        if (isMistborn | mistingIndex == 4)
        {
            //todo
        }
    }

    protected void CopperCloud()
    {
        if (isMistborn | mistingIndex == 5)
        {
            //todo
        }
    }

    protected void Riot()
    {
        if (isMistborn | mistingIndex == 6)
        {
            //todo
        }
    }

    protected void Soothe()
    {
        if (isMistborn | mistingIndex == 7)
        {
            //todo
        }
    }




}
