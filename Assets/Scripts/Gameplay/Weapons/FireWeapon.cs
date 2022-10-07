using System;
using System.Collections;
using UnityEngine;
using Gameplay.Projectiles;
namespace Gameplay.Weapons
{
    public class FireWeapon : GenericWeapon
    {
        private Vector3[] directions = { new Vector3(0.5f,1),new Vector3(1,0.5f),
            new Vector3(-1,0.5f),new Vector3(1,-0.5f),new Vector3(-1,-0.5f),
            new Vector3(0,1), new Vector3(-0.5f,1),new Vector3(-1,0), 
            new Vector3(-1,-1), new Vector3(0,-1),new Vector3(-1,1), new Vector3(0.5f,-1),new Vector3(1,0),new Vector3(-0.5f,-1),new Vector3(1,1), new Vector3(1,-1),};


        private void Awake()
        {
            weaponCharacteristics.projectileSpeed = 0.4f;
            weaponCharacteristics.firingRate = 0.8f;
            StartCoroutine(Fire());
        }
        public override IEnumerator Fire()
        {
            while (true)
            {
                Console.WriteLine("Fire!");
                for (int i = 0; i < 16; i+=1)
                {
                    GenericProjectile projectile =Instantiate(this.projectile,(transform.position + directions[i]),Quaternion.identity);
                    if(i%2==0)
                    projectile.GetComponent<Rigidbody2D>().velocity =(directions[i] * weaponCharacteristics.projectileSpeed);
                    else
                        projectile.GetComponent<Rigidbody2D>().velocity = (directions[i] * weaponCharacteristics.projectileSpeed*5);

                }

                yield return new WaitForSeconds(4f / weaponCharacteristics.firingRate);
            }
        }
    }
}