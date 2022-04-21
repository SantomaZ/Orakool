using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSprite : MonoBehaviour
{
    public Sprite cardFace;
    public Sprite cardBack;
    private SpriteRenderer spriteRenderer;
   // private Selectable selectable;
    private Oracool oracool;


    // Start is called before the first frame update
    void Start()
    {
        List<string> deck = Oracool.GenerateDeck();
        oracool = FindObjectOfType<Oracool>();

        int i = 1;
        foreach (string  card in deck)
        {
            if (this.name == card)
            {
                cardFace = oracool.cardFaces[i];
                break;

            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
