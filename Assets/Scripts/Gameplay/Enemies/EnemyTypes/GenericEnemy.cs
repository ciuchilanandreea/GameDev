using UnityEngine;

namespace Gameplay.Enemies.EnemyTypes
{
    public abstract class GenericEnemy : MonoBehaviour
    {
        protected int speed;
        protected Rigidbody2D body;
        protected SpriteRenderer sprite;
        protected Collider2D hitbox;
        protected Transform _target;

        protected virtual void Start()
        {
            body = GetComponent<Rigidbody2D>();
            sprite = GetComponent<SpriteRenderer>();
            hitbox = GetComponent<Collider2D>();
            _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        }

        protected virtual void Update()
        {
            Move();
        }

        protected virtual void Move()
        {
            transform.position = Vector2.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);
        }

        protected virtual void OnTriggerEnter2D(Collider2D collider)
        {
            // TODO this will have to be implemented differently for multiple weapons
            if (collider.gameObject.CompareTag("player-projectile"))
                Destroy(gameObject);
            if (collider.gameObject.CompareTag("Player"))
                Debug.Log($"Enemy {gameObject.tag} Tagged player");
        }

    }
}