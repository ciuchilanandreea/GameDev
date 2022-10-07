using UnityEngine;

namespace Gameplay.Projectiles
{
    public class PlaceHolderEnemyProjectile : GenericProjectile
    {
        private void Start()
        {
            projectileSpeed = 4;
            direction = new Vector2(Random.Range(-1f, 1.01f), Random.Range(-1f, 1.01f));
            Debug.Log("Projectile Start");
        }

    }
}