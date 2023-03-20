using UnityEngine;

public class Enemigo3 : Enemigo1
{

    public float dmgPomberito;

    void Start()
    {
        posJugador = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        FollowP1();
        LookAtPl();
        checkDist();
        DondeEsta();
    }

    public override void BasicAttack()
    {
        Debug.Log("Recibes " + dmgPomberito + " de daño Pomberito");
    }

}
