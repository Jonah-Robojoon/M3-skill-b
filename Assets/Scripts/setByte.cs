using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class setByte : MonoBehaviour
{
    [SerializeField] Byte myByte;
    [SerializeField] int newValue = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        myByte.setValue(newValue);
    }

    public void SetValue(int mapNewValue)
    {
        newValue = mapNewValue;
    }
}
