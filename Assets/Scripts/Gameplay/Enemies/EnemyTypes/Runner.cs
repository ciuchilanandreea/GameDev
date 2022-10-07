namespace Gameplay.Enemies.EnemyTypes
{
    public class Runner : GenericEnemy
    {
       
        private void Awake()
        {
            speed = 4;
        }
        //TODO
        //Nu merge codul asta
        // protected override void Fire(){
        //    var position= transform.position;
        //     Instantiate(projectile,position,Quaternion.identity);
        // } 
         
        
    }

}