using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    //Variable used to hold the pawn
    public Pawn pawn;

    // Overrides the Start function
    public virtual void Start()
    {

    }

    // Overrides the Update Function
    public virtual void Update()
    {

    }

    //Child classes can override the way inputs are processed
    public abstract void ProcessInputs();
}
