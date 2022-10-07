using UnityEngine;

namespace Gameplay.Projectiles
{
    public abstract class GenericProjectile : MonoBehaviour
    {
        public Vector2 direction;
        public float projectileSpeed;
        public Rigidbody2D RigidBody {get;}
        public SpriteRenderer SpriteRenderer {get;}
        public Collider2D Collider2D {get;}
        private void Start()
        {
            projectileSpeed = 3;
        }
        protected virtual void Update()
        {
            Move();
        }

        protected virtual void OnTriggerEnter2D(Collider2D collider)
        {
            //TODO this should be made to deal damage instead
            if ((collider.gameObject.CompareTag("Player") & CompareTag("enemy-projectile")) ||
                (collider.gameObject.CompareTag("Enemy") & CompareTag("player-projectile")) || 
                (collider.gameObject.CompareTag("Finish")))
                Destroy(gameObject);
        }
        private void Move()
        {
            transform.Translate(direction * Time.deltaTime * projectileSpeed, Space.World);
        }

    }
   
}