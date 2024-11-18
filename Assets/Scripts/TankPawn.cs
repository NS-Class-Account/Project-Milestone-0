using UnityEngine;

//Child class of Pawn
public class TankPawn : Pawn
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        //Access Start from main Pain as a derived class (TankPawn), had to look up "base.".
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        //Same thing as the Start
        base.Start();
    }

    public override void MoveForward()
    {
        //information displayed in the log for moving forward
        Debug.Log("Move Forward");
    }

    public override void MoveBackward()
    {
        //information displayed in the log for moving backward
        Debug.Log("Move Backward");
    }

    public override void RotateClockwise()
    {
        //information displayed in the log for rotating clockwise
        Debug.Log("Rotate Clockwise");
    }

    public override void RotateCounterClockwise()
    {
        //information displayed in the log for rotating counter clockwise
        Debug.Log("Rotate CounterClockwise");
    }
}
