using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss3 : MonoBehaviour
{
    public enum State { WALKING, SHOOTING };

    public State state;

    private Rigidbody2D rb;

    [SerializeField] private Transform target;
    [SerializeField] private float speed = 2;
    private Vector3 lookDirection;


    [Header("Move")]
    [SerializeField] private float timeToMove = 5;
    [SerializeField] private float timeToWait = 3;
    private float timingToMove;
    private bool activeMove;

    [Header("Bullet")]
    [SerializeField] private float timeToSpawnBullet = 3;
    private float timingToSpawnBullet;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform spawnBullet;

    public float Invunerable = 5f;
    public float vunerable = 0;
    public bool da�orecibido;

    // Start is called before the first frame update
    void Start()
    {
        activeMove = true;
        timingToMove = 0;
        timingToSpawnBullet = 0;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        muerto();

        if (activeMove)
        {
            timingToMove += Time.deltaTime;
            MoveToTarget();
            if (timingToMove > timeToMove)
            {
                timingToMove = 0;
                state = State.SHOOTING;
                StartCoroutine(ChangeState());
            }
        }

        if (state == State.SHOOTING)
        {
            timingToSpawnBullet += Time.deltaTime;
            if (timingToSpawnBullet > timeToSpawnBullet)
            {
                timingToSpawnBullet = 0;
                GameObject clone = Instantiate(bullet, spawnBullet.position, spawnBullet.rotation);
                clone.GetComponent<BulletEnemy>().targetPos = target.position;
            }
        }

        if (VariablesGlobales.Vida_jugador == 0)
        {
            VariablesGlobales.Enemigo_fase3_existe = false;
            SceneManager.LoadScene("Living Room");
        }
    }

    IEnumerator ChangeState()
    {
        activeMove = false;
        yield return new WaitForSeconds(timeToWait);
        activeMove = true;
    }

    private void MoveToTarget()
    {
        state = State.WALKING;
        timingToSpawnBullet = 0;
        lookDirection = (target.position - transform.position).normalized;
        transform.Translate(lookDirection * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (da�orecibido == false)
        {
            if (collision.gameObject.tag == "Shoot")
            {
                VariablesGlobales.Vida_enemigo_fase3 -= 20;
                da�orecibido = true;
            }
        }
        if (da�orecibido == true)
        {
            vunerable++;
        }
        if (vunerable == Invunerable)
        {
            da�orecibido = false;
            vunerable = 0;
        }

    }

    public void muerto()
    {
        if (VariablesGlobales.Vida_enemigo_fase3 == 0)
        {
            VariablesGlobales.Enemigo_fase3_existe = false;
            SceneManager.LoadScene("God1");
        }
    }
}
