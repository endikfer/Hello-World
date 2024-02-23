using System;
using UnityEngine;

public class Caracter
{
	public string nombre;
	private int HealthPoints = 10;

    public Caracter(string nombre, int vida, Boolean vivo)
	{
		this.nombre = nombre;
		Debug.Log("Hola, soy " + this.nombre);
	}

//	~Caracter{
//		Debug.Log("Destroy");
//	}

    public int HealthPoints1 { get => HealthPoints; set => HealthPoints = value; }

	public int TakeDamage(int vida)
	{
		vida--;
		return vida;
	}
}
