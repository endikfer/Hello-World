using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colortag : MonoBehaviour
{
    public GameObject[] objects;
    public Color color1;
    public Boolean FindByTag;
    public string ChoosenTag;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        colorObjeto();
    }

    private void colorObjeto()
    {
        if (FindByTag == true)
        {
            if (ChoosenTag != null && ChoosenTag != "")
            {
                objects = GameObject.FindGameObjectsWithTag(ChoosenTag);
                for (int i = 0; i < objects.Length; i++)
                {
                    objects[i].GetComponent<MeshRenderer>().material.color = color1;
                }
            }
        }
    }
}
