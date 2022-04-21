using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oracool : MonoBehaviour
{

    int rows = 4;

    int cols = 9;

    public int offsetX = 160;
    public int offsetY = 220;

    public int startX = -640;
    public int startY = 420;

    public Sprite[] cardFaces;
    public GameObject cardPrefab;

    public static string[] suits = new string[] { "H", "D", "C", "S" };
    public static string[] values = new string[] { "A", "6", "7", "8", "9", "10", "J", "Q", "K" };

    public List<string> deck;
    // Start is called before the first frame update
    void Start()
    {
        PlayCards();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayCards()
    {
        deck = GenerateDeck();

        foreach (string card in deck)
        {
            print(card);
        }

        OracoolDeal();
    }
    public static List<string> GenerateDeck()
    {
        List<string> newDeck = new List<string>();
        foreach (string s in suits)
        {
            foreach (string v in values)
            {
                newDeck.Add(s + v);
            }
        }
        return newDeck;
    }

    void OracoolDeal()
    {
        int yOffset = 0;
        foreach (string card in deck)
        { 
                //int posX = startX + i * offsetX;
                //int posY = startY - j * offsetY;


                /*GameObject playerCardf = Instantiate(cards[j * cols + i + 36], new Vector3(posX, posY, -5), Quaternion.identity);
                playerCardf.transform.SetParent(PlayerArea.transform, false);*/

                GameObject newCard = Instantiate(cardPrefab, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
               // playerCard.transform.SetParent(PlayerArea.transform, false);
                newCard.name = card;
            
        }
    }
}
