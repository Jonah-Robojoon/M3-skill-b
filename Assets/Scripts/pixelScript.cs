using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pixelScript : MonoBehaviour
{
    public Byte ByteG;
    public Byte ByteR;
    public Byte ByteB;

    public GameObject Pixel;

    SpriteRenderer spriteRenderer;

    public string colorCode;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Pixel != null)
        {
            spriteRenderer = Pixel.GetComponent<SpriteRenderer>();
        }

        if (ByteR != null && ByteG != null && ByteB != null && Pixel != null)
        {
            colorCode = "#" + ByteR.getHex() + ByteG.getHex() + ByteB.getHex();

            if (UnityEngine.ColorUtility.TryParseHtmlString(colorCode, out Color newColor))
            {
                spriteRenderer.color = newColor;
            }
            else
            {
                Debug.LogError("Ongeldige hex kleur: " + colorCode);
            }
        }
    }
}
