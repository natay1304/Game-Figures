using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCharacter : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerCharacter>().HandleDamage();
            Destroy(gameObject);
        }
        else 
        {
            Destroy(other.gameObject);
            
            if (other.CompareTag(gameObject.tag))
            {
                Destroy(gameObject);
            }
        }
    }
}
