using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moverobjeto : MonoBehaviour
{
    private Transform transformacion;
    // Start is called before the first frame update
    void Start()
    {
        transformacion = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        LogPosicion();
    }

    private void LogPosicion()
    {
        Debug.LogFormat("La posicion del objeto es: {0}", transformacion.localPosition.x);
        Debug.LogFormat("La posicion del objeto es: {0}", transformacion.localPosition.y);
        Debug.LogFormat("La posicion del objeto es: {0}", transformacion.localPosition.z);
    }
}
