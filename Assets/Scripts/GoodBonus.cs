using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
	public sealed class GoodBonus : InteractiveObject, /*IFlay,*/ IFlicker
	{
		private DisplayBonuses _displayBonuses;
		private Material _material;
		private float _lengthFlay;

		private void Awake()
		{
			_material = GetComponent<Renderer>().material;
			_lengthFlay = Random.Range(1.0f, 5.0f);
			_displayBonuses = new DisplayBonuses();
		}

		protected override void Interaction()
		{
			_displayBonuses.Display(5);
			// Add bonus
		}

		public void Flicker()
		{
			_material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
		}

	}	

}