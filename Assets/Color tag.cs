using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colortag : MonoBehaviour
{
    public GameObject cubo;
    public Color color1;
    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.FindWithTag("objeto");
        color1 = Color.cyan;
        cubo.GetComponent<MeshRenderer>().material.color = color1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
