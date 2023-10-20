using UnityEngine;

public class Food : MonoBehaviour
{
    public float foodValue = 10f;
    public float timeToRespawn = 10f;
    private float respawnTimer;

    private void Start()
    {
        respawnTimer = timeToRespawn;
    }

    private void Update()
    {
        if (respawnTimer <= 0)
        {
            RespawnFood();
            respawnTimer = timeToRespawn;
        }
        else
        {
            respawnTimer -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Baby"))
        {
            Baby baby = other.GetComponent<Baby>();
            if (baby != null)
            {
                baby.EatFood(foodValue);
                Destroy(gameObject);
            }
        }
    }

    private void RespawnFood()
    {
        // Instantiate a new food object
        Instantiate(gameObject, new Vector3(Random.Range(-5, 5), Random.Range(-3, 3), 0), Quaternion.identity);
    }
}
