using System;

public class Enemy: Caracter{

	public Enemy(string nombre, int vida, Boolean vivo):base(nombre, vida, vivo){
        string nom_ene = nombre;
        int vida_ene = vida;
        Boolean vivo_ene = vivo;
	}

}

public class Player : Caracter
{
    public Player(string nombre, int vida, Boolean vivo) : base(nombre, vida, vivo)
    {
        string nom_player = nombre;
        int vida_player = vida;
        Boolean vivo_player = vivo;
    }
}
