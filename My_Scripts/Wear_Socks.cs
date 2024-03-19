using UnityEngine;

public class Wear_Socks : MonoBehaviour
{
    private int EHsocksleft = 5;
    private int EAsocksleft = 4;
    private int LPHsocksleft = 4;
    private int LPAsocksleft = 4;
    public int Currentsock = 1;
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
        if (cloth.tag == "EgyptHome" && cloth.name == "EHSock")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentsock);
            if (Currentsock == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentsock == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentsock == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentsock == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inEgyptHome.SetActive(true);
            Currentsock = 1;
        }

        if (cloth.tag == "EgyptAway" && cloth.name == "EASock")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentsock);
            if (Currentsock == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentsock == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentsock == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentsock == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inEgyptAway.SetActive(true);
            Currentsock = 2;
        }

        if (cloth.tag == "LiverpoolHome" && cloth.name == "LPHSock")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentsock);
            if (Currentsock == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentsock == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentsock == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentsock == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inLiverpoolHome.SetActive(true);
            Currentsock = 3;
        }

        if (cloth.tag == "LiverpoolAway" && cloth.name == "LPASock")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentsock);
            if (Currentsock == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentsock == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentsock == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentsock == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inLiverpoolAway.SetActive(true);
            Currentsock = 4;
        }
    }

    public void showcloth(int num)
    {
        if (num == 1)
        {
            if (EHsocksleft == 5)
            {
                EgyptHome1.SetActive(true);
            }
            if (EHsocksleft == 4)
            {
                EgyptHome2.SetActive(true);
            }
            if (EHsocksleft == 3)
            {
                EgyptHome3.SetActive(true);
            }
            if (EHsocksleft == 2)
            {
                EgyptHome4.SetActive(true);
            }
            if (EHsocksleft == 1)
            {
                EgyptHome5.SetActive(true);
            }
            EHsocksleft--;
        }
        if (num == 2)
        {
            if (EAsocksleft == 4)
            {
                EgyptAway2.SetActive(true);
            }
            if (EAsocksleft == 3)
            {
                EgyptAway3.SetActive(true);
            }
            if (EAsocksleft == 2)
            {
                EgyptAway4.SetActive(true);
            }
            if (EAsocksleft == 1)
            {
                EgyptAway5.SetActive(true);
            }
            EAsocksleft--;
        }
        if (num == 3)
        {
            if (LPHsocksleft == 4)
            {
                LiverpoolHome2.SetActive(true);
            }
            if (LPHsocksleft == 3)
            {
                LiverpoolHome3.SetActive(true);
            }
            if (LPHsocksleft == 2)
            {
                LiverpoolHome4.SetActive(true);
            }
            if (LPHsocksleft == 1)
            {
                LiverpoolHome5.SetActive(true);
            }
            LPHsocksleft--;
        }
        if (num == 4)
        {
            if (LPAsocksleft == 4)
            {
                LiverpoolAway2.SetActive(true);
            }
            if (LPAsocksleft == 3)
            {
                LiverpoolAway3.SetActive(true);
            }
            if (LPAsocksleft == 2)
            {
                LiverpoolAway4.SetActive(true);
            }
            if (LPAsocksleft == 1)
            {
                LiverpoolAway5.SetActive(true);
            }
            LPAsocksleft--;
        }
    }


}
