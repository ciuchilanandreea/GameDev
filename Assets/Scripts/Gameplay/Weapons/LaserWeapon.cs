using System;
using System.Collections;
using UnityEngine;
using Gameplay.Projectiles;
namespace Gameplay.Weapons
{
    public class LaserWeapon : GenericWeapon
    {
        Vector3 worldMousePos;
        Vector2 direction;
        private void Awake()
        {
            weaponCharacteristics.projectileSpeed = 20.5f;
            weaponCharacteristics.firingRate = 10f;
            StartCoroutine(Fire());
        }
        private void Update()
        {
            worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = worldMousePos - transform.position;
            direction.Normalize();
        }
        public override IEnumerator Fire()
        {
            while (true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    GenericProjectile projectile = Instantiate(this.projectile, transform.position +(Vector3)(direction * 0.5f), Quaternion.identity);
                    Console.WriteLine("Instantiated projectile" + projectile);
                    projectile.GetComponent<Rigidbody2D>().velocity = direction * weaponCharacteristics.projectileSpeed;
                    yield return new WaitForSeconds(0.1f / weaponCharacteristics.firingRate);
                }
                yield return new WaitForSeconds(.001f);
            }

        }
    }
}