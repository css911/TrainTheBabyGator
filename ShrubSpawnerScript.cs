using UnityEngine;

public class ShrubSpawnerScript : MonoBehaviour
{
    public GameObject shrubs;
    public float shrubSpawnRate = 2;
    
    private float shrubsTimer = 0;
	public float heightOffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnShrubs();
    }

    // Update is called once per frame
    void Update()
    {
        if (shrubsTimer < shrubSpawnRate)
        {
            shrubsTimer = shrubsTimer + Time.deltaTime;
        }
        else
        {
            spawnShrubs();
            shrubsTimer = 0;
        }
    }
    void spawnShrubs(){
		float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
    
        Instantiate(shrubs, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0), transform.rotation);
    }

}
