﻿using UnityEngine;

namespace TouchScript.Examples.RawInput
{
	public class Ball : MonoBehaviour 
	{
		public float Speed = 1f;
		
		private void Update()
		{
			Speed *= 1.01f;
			transform.position += transform.forward*Speed*Time.deltaTime;
			if (Speed > 1000) Destroy(gameObject);
		}
	}
}