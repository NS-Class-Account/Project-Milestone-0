using UnityEngine;

public class MoveTest : MonoBehaviour
{
    //An accessible vairable that contains our speed
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //The cubes position is set to move only UP based on the constant set (direction) and multiplied based on it's speed given (EX: 1 for 1 mph or 10 for 10 mph)
        transform.position = transform.position + (Vector3.up * speed);
    }
}
