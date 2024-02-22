using System;
using UnityEngine;

public class Caracter
{
	public string nombre;
	private int HealthPoints = 1;

    public Caracter(string nombre)
	{
		this.nombre = nombre;
		Debug.Log("Hola, soy " + this.nombre);
	}

	~Caracter{
		Debug.Log("Destroy");
	}

    public int HealthPoints1 { get => HealthPoints; set => HealthPoints = value; }
}
