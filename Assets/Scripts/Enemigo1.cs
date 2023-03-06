using UnityEngine;

public class Enemigo1 : MonoBehaviour
{

    public Transform posJugador;
    public float speed = 1f;
    public float range = 100f;
    public GameObject miradaenemigo;

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
    void DondeEsta()
    {
        RaycastHit hit;
        if(Physics.Raycast(miradaenemigo.transform.position,miradaenemigo.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.tag == "humano")
            {
                Debug.Log("Me comeré a ese humano");
            }
        }
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
