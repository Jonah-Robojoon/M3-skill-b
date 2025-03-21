using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexByte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[8];
    [SerializeField] private int value = 0;
    [SerializeField] private int value1 = 0;
    [SerializeField] private int value2 = 0;

    void Update()
    {
        BinToDec();
    }

    private void BinToDec()
    {

    }

    public string getHex()
    {
        value1 = 0;
        if (bits[0].state) { value1 += 1; }
        if (bits[1].state) { value1 += 2; }
        if (bits[2].state) { value1 += 4; }
        if (bits[3].state) { value1 += 8; }
        value2 = 0;
        if (bits[4].state) { value2 += 1; }
        if (bits[5].state) { value2 += 2; }
        if (bits[6].state) { value2 += 4; }
        if (bits[7].state) { value2 += 8; }
        value = 0;
        value = value2 * 16 + value1;

        string HexValue = value.ToString("X2");
        return HexValue;
    }
}