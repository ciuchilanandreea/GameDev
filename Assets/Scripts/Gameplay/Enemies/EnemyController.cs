using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using UnityEditor;
using UnityEngine;
using Random = System.Random;

namespace Gameplay.Enemies
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private Transform playerPosition;
        [SerializeField] private List<GameObject> availableEnemyTypes;
        [SerializeField] private AreaBounds arenaBounds;
        [SerializeField] private float spawnFrequency = 1f;
        [SerializeField] private int maxEnemies = 20;
        private void Start()
        {
            StartCoroutine(SpawnEnemies());
        }

        IEnumerator SpawnEnemies()
        {
            Random rand = new Random();

            for (int i = 1;i<=maxEnemies;i++)
            {
                int enemyTypeIndex = rand.Next(0, availableEnemyTypes.Count);
                Vector3 position = new Vector3((float)rand.NextDouble() * (arenaBounds.xMax - arenaBounds.xMin) + arenaBounds.xMin,
                    (float)rand.NextDouble() * (arenaBounds.yMax - arenaBounds.yMin) + arenaBounds.yMin,0);
                while (Math.Abs(playerPosition.position.y - position.y) < 2 &&
                       Math.Abs(playerPosition.position.x - position.x) < 2)
                {
                    position.x = (float)rand.NextDouble() * (arenaBounds.xMax - arenaBounds.xMin) + arenaBounds.xMin;
                    position.y = (float)rand.NextDouble() * (arenaBounds.yMax - arenaBounds.yMin) + arenaBounds.yMin;
                }
                Debug.Log($"Attempting to spawn enemy of type {availableEnemyTypes[enemyTypeIndex]}" +
                          $" at location {position}, while player is at position" +
                          $"{playerPosition.position}" );
                Instantiate(availableEnemyTypes[enemyTypeIndex],position,Quaternion.identity);
                yield return new WaitForSeconds(2f / (1f+ spawnFrequency));
            }
            // Victory
            EditorApplication.isPlaying = false;
        }
    }
}
