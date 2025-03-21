using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[8];
    [SerializeField] private int value = 0;

    void Update()
    {
        BinToDec();
    }

    private void BinToDec()
    {
        value = 0;
        if (bits[0].state) { value += 1; }
        if (bits[1].state) { value += 2; }
        if (bits[2].state) { value += 4; }
        if (bits[3].state) { value += 8; }
        if (bits[4].state) { value += 16; }
        if (bits[5].state) { value += 32; }
        if (bits[6].state) { value += 64; }
        if (bits[7].state) { value += 128; }
    }

    public void setValue(int newValue)
    {

        // 255
        if (newValue > 255)
        {
            newValue = 255;
        };

        int countValue = 256;

        value = newValue;

        for (int i = 7; i >= 0; i--)
        {
            countValue /= 2;

            if (newValue >= countValue)
            {
                bits[i].state = true;
                newValue -= countValue;
            }
            else
            {
                bits[i].state = false;
            }
        }
    }
    public string getHex()
    {
        string hex = value.ToString("X2");
        return hex;
    }
}