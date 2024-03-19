using UnityEngine;

public class Wear_Shoes : MonoBehaviour
{
    private int EHshoesleft = 5;
    private int EAshoesleft = 4;
    private int LPHshoesleft = 4;
    private int LPAshoesleft = 4;
    public int Currentshoes = 1;
    public GameObject inEgyptHome;
    public GameObject inEgyptAway;
    public GameObject inLiverpoolHome;
    public GameObject inLiverpoolAway;
    public GameObject EgyptHome1;
    public GameObject EgyptHome2;
    public GameObject EgyptHome3;
    public GameObject EgyptHome4;
    public GameObject EgyptHome5;
    public GameObject EgyptAway1;
    public GameObject EgyptAway2;
    public GameObject EgyptAway3;
    public GameObject EgyptAway4;
    public GameObject EgyptAway5;
    public GameObject LiverpoolHome1;
    public GameObject LiverpoolHome2;
    public GameObject LiverpoolHome3;
    public GameObject LiverpoolHome4;
    public GameObject LiverpoolHome5;
    public GameObject LiverpoolAway1;
    public GameObject LiverpoolAway2;
    public GameObject LiverpoolAway3;
    public GameObject LiverpoolAway4;
    public GameObject LiverpoolAway5;

    private void OnTriggerEnter(Collider cloth)
    {
        if (cloth.tag == "EgyptHome" && cloth.name == "EHShoes")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentshoes);
            if (Currentshoes == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentshoes == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentshoes == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentshoes == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inEgyptHome.SetActive(true);
            Currentshoes = 1;
        }

        if (cloth.tag == "EgyptAway" && cloth.name == "EAShoes")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentshoes);
            if (Currentshoes == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentshoes == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentshoes == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentshoes == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inEgyptAway.SetActive(true);
            Currentshoes = 2;
        }

        if (cloth.tag == "LiverpoolHome" && cloth.name == "LPHShoes")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentshoes);
            if (Currentshoes == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentshoes == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentshoes == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentshoes == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inLiverpoolHome.SetActive(true);
            Currentshoes = 3;
        }

        if (cloth.tag == "LiverpoolAway" && cloth.name == "LPAShoes")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentshoes);
            if (Currentshoes == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentshoes == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentshoes == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentshoes == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inLiverpoolAway.SetActive(true);
            Currentshoes = 4;
        }
    }

    public void showcloth(int num)
    {
        if (num == 1)
        {
            if (EHshoesleft == 5)
            {
                EgyptHome1.SetActive(true);
            }
            if (EHshoesleft == 4)
            {
                EgyptHome2.SetActive(true);
            }
            if (EHshoesleft == 3)
            {
                EgyptHome3.SetActive(true);
            }
            if (EHshoesleft == 2)
            {
                EgyptHome4.SetActive(true);
            }
            if (EHshoesleft == 1)
            {
                EgyptHome5.SetActive(true);
            }
            EHshoesleft--;
        }
        if (num == 2)
        {
            if (EAshoesleft == 4)
            {
                EgyptAway2.SetActive(true);
            }
            if (EAshoesleft == 3)
            {
                EgyptAway3.SetActive(true);
            }
            if (EAshoesleft == 2)
            {
                EgyptAway4.SetActive(true);
            }
            if (EAshoesleft == 1)
            {
                EgyptAway5.SetActive(true);
            }
            EAshoesleft--;
        }
        if (num == 3)
        {
            if (LPHshoesleft == 4)
            {
                LiverpoolHome2.SetActive(true);
            }
            if (LPHshoesleft == 3)
            {
                LiverpoolHome3.SetActive(true);
            }
            if (LPHshoesleft == 2)
            {
                LiverpoolHome4.SetActive(true);
            }
            if (LPHshoesleft == 1)
            {
                LiverpoolHome5.SetActive(true);
            }
            LPHshoesleft--;
        }
        if (num == 4)
        {
            if (LPAshoesleft == 4)
            {
                LiverpoolAway2.SetActive(true);
            }
            if (LPAshoesleft == 3)
            {
                LiverpoolAway3.SetActive(true);
            }
            if (LPAshoesleft == 2)
            {
                LiverpoolAway4.SetActive(true);
            }
            if (LPAshoesleft == 1)
            {
                LiverpoolAway5.SetActive(true);
            }
            LPAshoesleft--;
        }
    }


}
