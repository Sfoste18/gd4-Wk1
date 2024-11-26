using UnityEngine;

public class Playercontroller : MonoBehaviour
{

    public float moveSpeed = 5;
    float horizontalMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //gets input from the player
        horizontalMovement = Input.GetAxis("Horizontal");

        //uses the input to move the player character
        transform.Translate(moveSpeed * Time.deltaTime * horizontalMovement, 0, 0);

        if (horizontalMovement < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (horizontalMovement > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}