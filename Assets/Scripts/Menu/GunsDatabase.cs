using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class GunsDatabase : ScriptableObject
{
   public Guns[] gun;

   public int GunCount
   {
       get{
           return gun.Length;
       }
   }
   public Guns GetGun(int index)
   {
       return gun[index];
   }
}
