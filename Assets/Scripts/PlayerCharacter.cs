using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
 
    {
        [SerializeField]
        private int Lives = 5;

        [SerializeField]
        private string Name = "Mario";
    
        [SeralizeField]
        private float JumpHieght = 5, Speed = 5;

        private bool HasKey;

        private bool IsOnGround;

        private RigidBody2D RigidBody2DInstance;
        
        private float HorizontalInput;

	    // Use this for initialization
	    void Start ()
        {
            // Have to initilize our Rigid Body value
            RigidBody2DInstance = GetCompnent<RigidBody2D>();
              
        }
	}
	
	// Update is called once per frame
	private void Update ()
    {
        GetInput();
        Move();
    }

    private void GetInput()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
    }
    private void Move()
    {
        RigidBody2DInstance.velocity = new Vector2(HorizontalInput, 0);
    }

