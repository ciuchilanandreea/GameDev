using System.Collections;
using Gameplay.Projectiles;
using Gameplay.Weapons;
using UnityEngine;

public abstract class GenericWeapon : MonoBehaviour
{
    [SerializeField]
    protected GenericProjectile projectile;
    public WeaponCharacteristics weaponCharacteristics;

    public virtual IEnumerator Fire()
    {
        yield break;
    }

}
