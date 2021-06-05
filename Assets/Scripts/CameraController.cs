using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{

	public class CameraController : MonoBehaviour
	{
    
		[SerializeField] public Player Player;
		private Vector3 _offset;

    	void Start()
    	{
        	_offset = transform.position - Player.transform.position;
    	}

    	void LateUpdate()
    	{
        	transform.position = Player.transform.position + _offset;
    	}
	}

}	