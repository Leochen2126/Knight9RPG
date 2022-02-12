using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACTION : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player warrior = new Player(100, 80, "doggo");
        warrior.info();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
