using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AIBehaviour : MonoBehaviour
{
    private LayerMask aiType;

    // Start is called before the first frame update
    void Start()
    {
        aiType = gameObject.GetComponent<LayerMask>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if (aiType == LayerMask.GetMask("Slime"))
        {
            
        }
    }
}
