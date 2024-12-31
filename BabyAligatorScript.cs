
using UnityEngine;

public class BabyAligatorScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    public float flapStrength;

    public LogicScript logic;

    public bool birdIsAlive = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
		myRigidbody.linearVelocity = Vector2.up * flapStrength*2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
    }

	private void OnCollisionEnter2D(Collision2D collision){
		logic.gameOver();
        birdIsAlive = false;
	}
}