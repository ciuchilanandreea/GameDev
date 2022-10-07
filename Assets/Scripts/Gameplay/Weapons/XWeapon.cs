using System;
using System.Collections;
using Gameplay.Projectiles;
using UnityEngine;

namespace Gameplay.Weapons
{
    public class XWeapon : GenericWeapon
    {
        private Vector3[] directions = { Vector3.up, Vector3.left, Vector3.down, Vector3.right,
            new Vector3(-1,-1), new Vector3(-1,1), new Vector3(1,1), new Vector3(1,-1),};
        private void Awake()
        {
            weaponCharacteristics.projectileSpeed = 1.8f;
            weaponCharacteristics.firingRate =.7f;
            StartCoroutine(Fire());
        }

        public override IEnumerator Fire()
        {
            while (true)
            {
                Console.WriteLine("Firing XWeapon!");
                for (int i = 0; i < 4; i++)
                {
                    GenericProjectile projectile =
                        Instantiate(this.projectile, transform.position + directions[i], Quaternion.identity);
                    projectile.GetComponent<Rigidbody2D>().velocity =
                        directions[i] * weaponCharacteristics.projectileSpeed;
                }

                yield return new WaitForSeconds(1f / weaponCharacteristics.firingRate);

                for (int i = 4; i < 8; i++)
                {
                    GenericProjectile projectile =
                        Instantiate(this.projectile, transform.position + directions[i], Quaternion.identity);
                    projectile.GetComponent<Rigidbody2D>().velocity =
                        directions[i]/2 * weaponCharacteristics.projectileSpeed;
                }

                yield return new WaitForSeconds(1.5f / weaponCharacteristics.firingRate);
            }
        }
    }
}