using UnityEngine;

namespace Gameplay.Enemies.EnemyTypes
{
    public class Twin : GenericEnemy
    {
       private float size=5;
        private void Awake()
        {
            speed = 2;
        }
        protected override void OnTriggerEnter2D(Collider2D collider)
        {
            // TODO this will have to be implemented differently for multiple weapons
            if (collider.gameObject.CompareTag("player-projectile"))
            {
                if(transform.localScale.x>3){
                    var pos1= transform.position + new Vector3(1,2);
                    GameObject obj1=Instantiate(gameObject,pos1,transform.rotation);
                    obj1.transform.localScale -= new Vector3(3,3,3);
                    var pos2= transform.position + new Vector3(2,3);
                    GameObject obj2= Instantiate(gameObject,pos2,transform.rotation);
                    obj2.transform.localScale -= new Vector3(3,3,3);
                    Destroy(gameObject);
                    
                }
                else{
                       Destroy(gameObject);
                       
                }}
            if (collider.gameObject.CompareTag("Player"))
                Debug.Log("Tagged player");
        }
    }

}