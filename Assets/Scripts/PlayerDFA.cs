using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDFA : MonoBehaviour
{
	private State currentState;
	private State nextState;
	
	void Start()
	{
		currentState = State.standing;
	}

	private void Update()
	{
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
		{
			// set state to walking
			nextState = State.walking;
		}
		else if (Input.GetKey(KeyCode.W))
		{
			// set state to jumping
			nextState = State.jumping;
		}
		else if (Input.GetKey(KeyCode.S))
		{
			// set state to crouching
			nextState = State.crouching;
		}
		else if (Input.GetKey(KeyCode.Space))
		{
			// set state attacking
			nextState = State.attacking;
		}
		else
		{
			// set state standing
			nextState = State.standing;
		}
		
		SetState(nextState);
		Debug.Log(currentState);
	}

	public enum State
	{
		standing,
		walking,
		jumping,
		crouching,
		attacking,
	}

	private void SetState(State nextState_)
    {
	    // Switch case
	    switch(nextState_) 
	    {
		    case State.standing:
			    // code block
			    currentState = State.standing;
			    break;
		    
		    case State.walking:
			    if (currentState == State.standing)
			    {
				    currentState = State.walking;
			    }
			    break;
		    
		    case State.jumping:
			    if (currentState == State.standing || currentState == State.walking)
			    {
				    currentState = State.jumping;
			    }
			    break;
		    
		    case State.crouching:
			    // code block
			    if (currentState != State.jumping)
			    {
				    currentState = State.crouching;
			    }
			    break;
		    
		    case State.attacking:
			    // code block
			    if (currentState == State.walking || currentState == State.standing)
			    {
				    currentState = State.attacking;
			    }
			    break;
		    default:
			    // code block
			    Debug.Log("no case found, setting standing");
			    currentState = State.standing;
			    break;
	    }
    }

    
    
}
