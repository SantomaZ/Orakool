using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards
{
    public void GetCoords(int CardX, int CardY)

    {

    }

}

public class DrawCards : MonoBehaviour
{
    

    /*public void OffsetY (int offset, int startY)

    {
        currentY = 
    }
    */
    int rows = 4;

    int cols = 9;

    int offsetX = 160;
    int offsetY = 220;

    int startX = -640;
    int startY = 420;

    public GameObject H6;
    public GameObject H7;
    public GameObject H8;
    public GameObject H9;
    public GameObject H10;
    public GameObject HJ;
    public GameObject HQ;
    public GameObject HK;
    public GameObject H1;
    public GameObject D6;
    public GameObject D7;
    public GameObject D8;
    public GameObject D9;
    public GameObject D10;
    public GameObject DJ;
    public GameObject DQ;
    public GameObject DK;
    public GameObject D1;
    public GameObject C6;
    public GameObject C7;
    public GameObject C8;
    public GameObject C9;
    public GameObject C10;
    public GameObject CJ;
    public GameObject CQ;
    public GameObject CK;
    public GameObject C1;
    public GameObject S6;
    public GameObject S7;
    public GameObject S8;
    public GameObject S9;
    public GameObject S10;
    public GameObject SJ;
    public GameObject SQ;
    public GameObject SK;
    public GameObject S1;
    public GameObject H6f;
    public GameObject H7f;
    public GameObject H8f;
    public GameObject H9f;
    public GameObject H10f;
    public GameObject HJf;
    public GameObject HQf;
    public GameObject HKf;
    public GameObject H1f;
    public GameObject D6f;
    public GameObject D7f;
    public GameObject D8f;
    public GameObject D9f;
    public GameObject D10f;
    public GameObject DJf;
    public GameObject DQf;
    public GameObject DKf;
    public GameObject D1f;
    public GameObject C6f;
    public GameObject C7f;
    public GameObject C8f;
    public GameObject C9f;
    public GameObject C10f;
    public GameObject CJf;
    public GameObject CQf;
    public GameObject CKf;
    public GameObject C1f;
    public GameObject S6f;
    public GameObject S7f;
    public GameObject S8f;
    public GameObject S9f;
    public GameObject S10f;
    public GameObject SJf;
    public GameObject SQf;
    public GameObject SKf;
    public GameObject S1f;
    public GameObject Blank;
    public GameObject PlayerArea;
    public GameObject CheckZone;
    /*
    public GameObject playerCard;
    public GameObject playerCardf;*/

    public List<GameObject> cards = new List<GameObject>();

    /*public List<GameObject> hearts = new List<GameObject>();
    public List<GameObject> diamonds = new List<GameObject>();
    public List<GameObject> spades = new List<GameObject>();
    public List<GameObject> clubs = new List<GameObject>();*/


    /*public List<GameObject> cards = new List hearts.Concat(diamonds).Concat.(spades).Concat(clubs).ToList();*/


    void Start()
    {
        cards.Add(H6);
        cards.Add(H7);
        cards.Add(H8);
        cards.Add(H9);
        cards.Add(H10);
        cards.Add(HJ);
        cards.Add(HQ);
        cards.Add(HK);
        cards.Add(H1);
        cards.Add(D6);
        cards.Add(D7);
        cards.Add(D8);
        cards.Add(D9);
        cards.Add(D10);
        cards.Add(DJ);
        cards.Add(DQ);
        cards.Add(DK);
        cards.Add(D1);
        cards.Add(C6);
        cards.Add(C7);
        cards.Add(C8);
        cards.Add(C9);
        cards.Add(C10);
        cards.Add(CJ);
        cards.Add(CQ);
        cards.Add(CK);
        cards.Add(C1);
        cards.Add(S6);
        cards.Add(S7);
        cards.Add(S8);
        cards.Add(S9);
        cards.Add(S10);
        cards.Add(SJ);
        cards.Add(SQ);
        cards.Add(SK);
        cards.Add(S1);
        cards.Add(H6f);
        cards.Add(H7f);
        cards.Add(H8f);
        cards.Add(H9f);
        cards.Add(H10f);
        cards.Add(HJf);
        cards.Add(HQf);
        cards.Add(HKf);
        cards.Add(H1f);
        cards.Add(D6f);
        cards.Add(D7f);
        cards.Add(D8f);
        cards.Add(D9f);
        cards.Add(D10f);
        cards.Add(DJf);
        cards.Add(DQf);
        cards.Add(DKf);
        cards.Add(D1f);
        cards.Add(C6f);
        cards.Add(C7f);
        cards.Add(C8f);
        cards.Add(C9f);
        cards.Add(C10f);
        cards.Add(CJf);
        cards.Add(CQf);
        cards.Add(CKf);
        cards.Add(C1f);
        cards.Add(S6f);
        cards.Add(S7f);
        cards.Add(S8f);
        cards.Add(S9f);
        cards.Add(S10f);
        cards.Add(SJf);
        cards.Add(SQf);
        cards.Add(SKf);
        cards.Add(S1f);
        cards.Add(Blank);

        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {

                int posX = startX + i * offsetX;
                int posY = startY - j * offsetY;


                GameObject playerCardf = Instantiate(cards[j * cols + i + 36], new Vector3(posX, posY, -5), Quaternion.identity);
                playerCardf.transform.SetParent(PlayerArea.transform, false);

                GameObject playerCard = Instantiate(cards[j * cols + i], new Vector3(posX, posY, 0), Quaternion.identity);
                playerCard.transform.SetParent(PlayerArea.transform, false);

            }
        }
        /*
        hearts.Add(H6);
        hearts.Add(H7);
        hearts.Add(H8);
        hearts.Add(H9);
        hearts.Add(H10);
        hearts.Add(HJ);
        hearts.Add(HQ);
        hearts.Add(HK);
        hearts.Add(H1);
        diamonds.Add(D6);
        diamonds.Add(D7);
        diamonds.Add(D8);
        diamonds.Add(D9);
        diamonds.Add(D10);
        diamonds.Add(DJ);
        diamonds.Add(DQ);
        diamonds.Add(DK);
        diamonds.Add(D1);
        clubs.Add(C6);
        clubs.Add(C7);
        clubs.Add(C8);
        clubs.Add(C9);
        clubs.Add(C10);
        clubs.Add(CJ);
        clubs.Add(CQ);
        clubs.Add(CK);
        clubs.Add(C1);
        spades.Add(S6);
        spades.Add(S7);
        spades.Add(S8);
        spades.Add(S9);
        spades.Add(S10);
        spades.Add(SJ);
        spades.Add(SQ);
        spades.Add(SK);
        spades.Add(S1);
        */
    }

    public void CheckClick()
    {
        int rndindex = Random.Range(0, cards.Count-37);
        GameObject RandomCard = Instantiate(cards[rndindex], new Vector3(0, 0, 0), Quaternion.identity);
        RandomCard.transform.SetParent(CheckZone.transform, false);
        cards.RemoveAt(rndindex);
        cards.Insert(rndindex, Blank);

    }

    public void OnClick()
    {
        /*
        int posY = startY;

        for (int i = 0; i < cols; i++)
        {
            int posX = startX + i * offsetX;

            GameObject playerCard = Instantiate(hearts[i], new Vector3(posX, posY, 0), Quaternion.identity);
            playerCard.transform.SetParent(PlayerArea.transform, false);

        }

        posY = posY - offsetY;

        for (int i = 0; i < cols; i++)
        {
            int posX = startX + i * offsetX;

            GameObject playerCard = Instantiate(diamonds[i], new Vector3(posX, posY, 0), Quaternion.identity);
            playerCard.transform.SetParent(PlayerArea.transform, false);
        }

        posY = posY - offsetY;

        for (int i = 0; i < cols; i++)
        {
            int posX = startX + i * offsetX;

            GameObject playerCard = Instantiate(spades[i], new Vector3(posX, posY, 0), Quaternion.identity);
            playerCard.transform.SetParent(PlayerArea.transform, false);
        }

        posY = posY - offsetY;

        for (int i = 0; i < cols; i++)
        {
            int posX = startX + i * offsetX;

            GameObject playerCard = Instantiate(clubs[i], new Vector3(posX, posY, 0), Quaternion.identity);
            playerCard.transform.SetParent(PlayerArea.transform, false);
        }
        */
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {

                int posX = startX + i * offsetX;
                int posY = startY - j * offsetY;


                GameObject playerCardf = Instantiate(cards[j * cols + i + 36], new Vector3(posX, posY, -5), Quaternion.identity);
                playerCardf.transform.SetParent(PlayerArea.transform, false);

                GameObject playerCard = Instantiate(cards[j * cols + i], new Vector3(posX, posY, 0), Quaternion.identity);
                playerCard.transform.SetParent(PlayerArea.transform, false);

            }
        }
    }


}
