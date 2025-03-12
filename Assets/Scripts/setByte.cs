using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class setByte : MonoBehaviour
{
    [SerializeField] Byte myByte;
    [SerializeField] int myInt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myByte.setValue(myInt);
    }
}
