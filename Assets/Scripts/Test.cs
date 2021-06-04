using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     	//Player player = new PlayerBall();  
     	InteractiveObject interactiveObject = new GoodBonus(); 

     	Debug.Log(interactiveObject is GoodBonus);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

}
