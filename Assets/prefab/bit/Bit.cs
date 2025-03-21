using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bit : MonoBehaviour
{
    //public GameObject text;
    SpriteRenderer spriteRenderer;

    [SerializeField] TextMeshProUGUI MyText_text;

    // Start is called before the first frame update
    void Start()
    {
        //text.text = "hello world";
        spriteRenderer = GetComponent<SpriteRenderer>();
        //MyText_text = GetComponent<TextMeshProUGUI>();
    }


    public bool state = false;

    // Update is called once per frame
    void Update()
    {
        if (state)
        {
            // Zet de sprite kleur op groen als state true is
            spriteRenderer.color = Color.green;
            MyText_text.text = "1";
        }
        else
        {
            // Zet de sprite kleur op rood als state false is
            spriteRenderer.color = Color.red;
            MyText_text.text = "0";
        }

    }

    private void OnMouseUp()
    {
        state = !state; // Wissel tussen true en false
    }
}
