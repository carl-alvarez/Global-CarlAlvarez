using UnityEngine;

public class Enemigo3 : MonoBehaviour
{

    public Transform posJugador;
    public float speed = 1f;

    void Start()
    {
        
    }
    void Update()
    {
        FollowP1();
        LookAtPl();
        checkDist();
    }
    void checkDist()
    {
        float dist = Vector3.Distance(posJugador.position, transform.position);
    }
    void LookAtPl()
    {
        Quaternion lookOnLook = Quaternion.LookRotation(posJugador.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookOnLook, Time.deltaTime);
    }
    void FollowP1()
    {
        transform.position = Vector3.MoveTowards(transform.position, posJugador.position, speed * Time.deltaTime);
        //transform.position = Vector3.MoveTowards(transform.position , posJugador.position, Time.deltaTime);
    }

}
