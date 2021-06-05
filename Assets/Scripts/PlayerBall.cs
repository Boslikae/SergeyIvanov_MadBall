using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
	public sealed class PlayerBall : Player
	{
		public PlayerBall()
		{
			//Debug.Log("PlayerBall");
		}

		private void FixedUpdate()
		{
			Move();
			Jump();
		}
	}
}
