using UnityEngine;

namespace Gameplay.Enemies.EnemyTypes
{
    public class Bomb : GenericEnemy
    {
        private float size = 7;
        private void Awake()
        {
            speed = 2;
        }
        protected override void OnTriggerEnter2D(Collider2D collider)
        {
            // TODO this will have to be implemented differently for multiple weapons
            if (collider.gameObject.CompareTag("player-projectile"))
            {
                if (transform.localScale.x > 4)
                {
                    speed = 3;
                    var pos1 = transform.position + new Vector3(1, 2);
                    GameObject obj1 = Instantiate(gameObject, pos1, transform.rotation);
                    obj1.transform.localScale -= new Vector3(2, 2, 2);
                    var pos2 = transform.position + new Vector3(2, 1);
                    GameObject obj2 = Instantiate(gameObject, pos2, transform.rotation);
                    obj2.transform.localScale -= new Vector3(2, 2, 2);
                    var pos3 = transform.position + new Vector3(2, 2);
                    GameObject obj3 = Instantiate(gameObject, pos3, transform.rotation);
                    obj3.transform.localScale -= new Vector3(2, 2, 2);
                    Destroy(gameObject);

                }
                else
                if (transform.localScale.x > 1)
                {
                    speed = 5;
                    var pos1 = transform.position + new Vector3(1, 2);
                    GameObject obj1 = Instantiate(gameObject, pos1, transform.rotation);
                    obj1.transform.localScale -= new Vector3(2, 2, 2);
                    var pos2 = transform.position + new Vector3(1, 0);
                    GameObject obj2 = Instantiate(gameObject, pos2, transform.rotation);
                    obj2.transform.localScale -= new Vector3(2, 2,2);
                    var pos3 = transform.position + new Vector3(0, 1);
                    GameObject obj3 = Instantiate(gameObject, pos3, transform.rotation);
                    obj3.transform.localScale -= new Vector3(2, 2, 2);
                    Destroy(gameObject);

                }
                else
                {
                    Destroy(gameObject);

                }
            }
            if (collider.gameObject.CompareTag("Player"))
                Debug.Log("Tagged player");
        }
    }

}