using UnityEngine;


public class SimpleExample : MonoBehaviour
{
    //Variable that holds a string for our characters or message
    public string theText = "Hello World";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        //Writes the stored value of the variable "theText" to the console window
        Debug.Log(theText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
