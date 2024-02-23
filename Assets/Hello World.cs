using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update

    Enemy Enemigo;
    Player Jugador;
    void Start()
    {
        Enemigo = new Enemy("Darth Vader", 10, true);
        Jugador = new Player("Luke Skywalker", 10, true);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("El nombre es "+Enemigo.nombre+", vida "+Enemigo.HealthPoints1);
        Enemigo.TakeDamage(Enemigo.HealthPoints1);
    }
}
