using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingArmMotion : MonoBehaviour
{
    //GameObjects
    public GameObject LeftHand;
    public GameObject RightHand;
    public GameObject CenterEyeCamera;
    public GameObject ForwardDirection;

    //Vector3 positions

    private Vector3 PositionPreviousFrameLeftHand;
    private Vector3 PositionPreviousFrameRightHand;
    private Vector3 PlayerPositionPreviousFrame;
    private Vector3 PlayerPositionThisFrame; 
    private Vector3 PositionThisFrameLeftHand;
    private Vector3 PositionThisFrameRightHand;

    //Speed
    public float Speed = 70;
    private float HandSpeed;

  

     void Start()
    {
      

        //Set original Previous frame positions at start up
        PlayerPositionPreviousFrame = transform.position;
        PositionPreviousFrameLeftHand = LeftHand.transform.position;
        PositionPreviousFrameRightHand = RightHand.transform.position;
    }

    private void Update()
    {
        //Get the forward direction from the center eye camera and set it to the forward direction object
        float yRotation = CenterEyeCamera.transform.eulerAngles.y;
        ForwardDirection.transform.eulerAngles = new Vector3(0, yRotation, 0);

        //Get current positions of hands
        PositionThisFrameLeftHand = LeftHand.transform.position;
        PositionThisFrameRightHand = RightHand.transform.position;
        // Position of the player
        PlayerPositionThisFrame = transform.position;

        //Get distance the hands and player has moved since the last frame
        var playerDistanceMoved = Vector3.Distance(PlayerPositionThisFrame, PlayerPositionPreviousFrame);
        var leftHandDistanceMoved = Vector3.Distance(PositionPreviousFrameLeftHand, PositionThisFrameLeftHand);
        var rightHandDistanceMoved = Vector3.Distance(PositionPreviousFrameRightHand, PositionThisFrameRightHand);

        //Add them up to get the hand speed from the user minus the movement of the player 
        HandSpeed = ((leftHandDistanceMoved - playerDistanceMoved) + (rightHandDistanceMoved - playerDistanceMoved));
        

        if (Time.timeSinceLevelLoad > 1f)
            transform.position += ForwardDirection.transform.forward * HandSpeed * Speed * Time.deltaTime;
        
      

        //Set previous positions of hands for the next frame
        PositionPreviousFrameLeftHand = PositionThisFrameLeftHand;
        PositionPreviousFrameRightHand = PositionThisFrameRightHand;
        //Set player position previous frame
        PlayerPositionPreviousFrame = PlayerPositionThisFrame;

    }
}
