using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GunManager : MonoBehaviour
{
   public GunsDatabase gunsDB;
   public Text textDesc;
   public SpriteRenderer art;
   
   private int selectionOption=0;
    void Start()
    {
        UpdateGun(selectionOption);
    }
    public void NextOption()
    {
        selectionOption++;
        if(selectionOption>=gunsDB.GunCount)
        {
            selectionOption=0;
        }
        UpdateGun(selectionOption);
    }
    public void BackOption()
    {
        selectionOption--;
        if (selectionOption<0)
        {
            selectionOption=gunsDB.GunCount-1;
        }
        UpdateGun(selectionOption);
    }
    private void UpdateGun(int selectionOption)
    {
        Guns gun= gunsDB.GetGun(selectionOption);
        art.sprite=gun.gunSprite;
       
        textDesc.text=gun.gunDescription;
    }

}
