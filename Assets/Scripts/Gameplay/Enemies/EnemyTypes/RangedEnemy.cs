using Gameplay.Projectiles;
using UnityEngine;

namespace Gameplay.Enemies.EnemyTypes
{
    public abstract class RangedEnemy : GenericEnemy
    {
        [SerializeField]
        protected GenericProjectile projectile;
        protected float fireRate = 0.5F;
        protected float nextFire = 0.0F;

        protected override void Update()
        {
            Move();
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Fire();
            }
        }

        protected abstract void Fire();
    }
}
