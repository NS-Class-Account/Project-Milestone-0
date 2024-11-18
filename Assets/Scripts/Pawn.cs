using JetBrains.Annotations;
using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    //Variable used for moving speed
    public float moveSpeed;
    //Variable used for turning speed
    public float turnSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public virtual void Start()
    {
       
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }

    //Values that will continuously be over written based on the child pawns using this component.
    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();
}
