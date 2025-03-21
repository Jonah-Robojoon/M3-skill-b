using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bitMap : MonoBehaviour
{
    [SerializeField] GameObject[] bitmapBytes = new GameObject[8];
    [SerializeField] int[] Values = new int[8];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= bitmapBytes.Length; i++)
        {
            bitmapBytes[i].GetComponent<setByte>().SetValue(Values[i]);
        }
    }
}
