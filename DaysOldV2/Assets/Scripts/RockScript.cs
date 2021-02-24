using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer spriteRenderer;

    public int Aridness = 50;

    public Sprite NormalRock;
    public Sprite DryRock;
    public Sprite WetRock;
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        if (Aridness < 25)
        {
            spriteRenderer.sprite = WetRock;
        }
        else if (Aridness > 75)
        {
            spriteRenderer.sprite = DryRock;
        }
        else
        {
            spriteRenderer.sprite = NormalRock;
        }
    }

    // Update is called once per frame
    void Update()
    {
        

     
    }
}
