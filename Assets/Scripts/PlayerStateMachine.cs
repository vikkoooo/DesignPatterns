using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
	public State currentState;
	private State nextState;
	
	void Start()
	{
		currentState = State.standing; // Default is, we start as standing.
	}

	private void Update()
	{
		// set state to walking
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
		{
			nextState = State.walking;
		}
		// set state to jumping
		else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space))
		{
			nextState = State.jumping;
		}
		// set state to crouching
		else if (Input.GetKey(KeyCode.S))
		{
			nextState = State.crouching;
		}
		// set state attacking
		else if (Input.GetKey(KeyCode.Mouse0))
		{
			nextState = State.attacking;
		}
		// set state standing
		else
		{
			nextState = State.standing;
		}
		
		SetState(nextState);
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
			    if (currentState != State.jumping)
			    {
				    currentState = State.crouching;
			    }
			    break;
		    
		    case State.attacking:
			    if (currentState == State.walking || currentState == State.standing)
			    {
				    currentState = State.attacking;
			    }
			    break;
		    
		    default:
			    Debug.Log("no case found, setting standing");
			    currentState = State.standing;
			    break;
	    }
    }

}
