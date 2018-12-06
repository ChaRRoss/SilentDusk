using System;
using UnityEngine;
using InControl;

namespace PlayerCharacter
{
	public class PlayerCharacterMovement : MonoBehaviour
	{
			public float PlayerSpeed;
			public Rigidbody PlayerRigidbody;
			
			void Awake()
			{
				if(PlayerRigidbody == null)
				{
					PlayerRigidbody = GetComponent<Rigidbody>();
				}
			}
			
			void FixedUpdate()
			{
				var inputDevice = InputManager.ActiveDevice;
				movement.Set (inputDevice.LeftStickX, 0f,  inputDevice.LeftStickY);        
				movement = movement.normalized * speed * Time.deltaTime;
				PlayerRigidbody.MovePosition (transform.position + movement);
			}
	}
}
