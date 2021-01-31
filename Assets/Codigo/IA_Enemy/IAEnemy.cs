using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAEnemy : MonoBehaviour
{
    public enum State { WALKING, SHOOTING};

    public State state;

    private Rigidbody2D rb;

    [SerializeField] private Transform target;
    [SerializeField] private float speed = 2;
    private Vector3 lookDirection;


    [Header ("Move")]
    [SerializeField] private float timeToMove = 5;
    [SerializeField] private float timeToWait = 3;
    private float timingToMove;
    private bool activeMove;

    [Header("Bullet")]
    [SerializeField] private float timeToSpawnBullet = 3;
    private float timingToSpawnBullet;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform spawnBullet;

    
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
}
