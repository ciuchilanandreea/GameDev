using UnityEngine;

public class PlaceholderEnemy : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
    public Transform player;

    void Start()
    {
        speed = 3;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        direction = new Vector2(player.position.x,player.position.y);
        Debug.Log("Projectile Start");
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, direction, speed * Time.deltaTime);
        if(transform.position.x==direction.x && transform.position.y==direction.y)
        { onColliderEnter(); }
    
    
    }
    void onColliderEnter()
    { 
            Destroy(gameObject);
    }
}
