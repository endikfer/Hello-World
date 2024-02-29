using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuscarObjeto : MonoBehaviour
{

    public GameObject cubo;
    public GameObject esfera;
    public GameObject cilindro;
    public Color color1;
    public Color color2;
    public Color color3;
    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.Find("Cube");
        esfera = GameObject.Find("Sphere");
        cilindro = GameObject.Find("Cylinder");
        color1 = Color.cyan;
        color2 = Color.black;
        color3 = Color.red;
        cubo.GetComponent<MeshRenderer>().material.color = color1;
        esfera.GetComponent<MeshRenderer>().material.color = color2;
        cilindro.GetComponent<MeshRenderer>().material.color = color3;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogFormat("Cubo encontrado: {0}", cubo);
    }
}
