using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public sealed class Player : MonoBehaviour
{
    public float speed;
    public List<GameObject> availableWeapons;
    private void Start()
    {
        foreach (var weapon in availableWeapons)
            weapon.SetActive(true);
    }

    private void Update()
    {
        Move();
        if (Input.GetMouseButtonDown(0))
        { 
            //Fire();
        }
    }

    private void Move()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        var movement = new Vector2(speed * inputX, speed * inputY) * Time.deltaTime;
        transform.Translate(movement);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Enemy") || collider.gameObject.CompareTag("enemy-projectile") )
            EditorApplication.isPlaying = false;
    }
}
