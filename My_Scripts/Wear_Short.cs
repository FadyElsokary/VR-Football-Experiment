using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wear_Short : MonoBehaviour
{
    private int EHshortsleft = 5;
    private int EAshortsleft = 4;
    private int LPHshortsleft = 4;
    private int LPAshortsleft = 4;
    public int Currentshort = 1;
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
        if (cloth.tag == "EgyptHome" && cloth.name == "EgyptHomeShort")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentshort);
            if (Currentshort == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentshort == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentshort == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentshort == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inEgyptHome.SetActive(true);
            Currentshort = 1;
        }

        if (cloth.tag == "EgyptAway" && cloth.name == "EgyptAwayShorts")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentshort);
            if (Currentshort == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentshort == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentshort == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentshort == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inEgyptAway.SetActive(true);
            Currentshort = 2;
        }

        if (cloth.tag == "LiverpoolHome" && cloth.name == "LiverpoolHomeShorts")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentshort);
            if (Currentshort == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentshort == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentshort == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentshort == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inLiverpoolHome.SetActive(true);
            Currentshort = 3;
        }

        if (cloth.tag == "LiverpoolAway" && cloth.name == "LiverpoolAwayShorts")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentshort);
            if (Currentshort == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentshort == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentshort == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentshort == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inLiverpoolAway.SetActive(true);
            Currentshort = 4;
        }
    }

    public void showcloth(int num)
    {
        if (num == 1)
        {
            if (EHshortsleft == 5)
            {
                EgyptHome1.SetActive(true);
            }
            if (EHshortsleft == 4)
            {
                EgyptHome2.SetActive(true);
            }
            if (EHshortsleft == 3)
            {
                EgyptHome3.SetActive(true);
            }
            if (EHshortsleft == 2)
            {
                EgyptHome4.SetActive(true);
            }
            if (EHshortsleft == 1)
            {
                EgyptHome5.SetActive(true);
            }
            EHshortsleft--;
        }
        if (num == 2)
        {
            if (EAshortsleft == 4)
            {
                EgyptAway2.SetActive(true);
            }
            if (EAshortsleft == 3)
            {
                EgyptAway3.SetActive(true);
            }
            if (EAshortsleft == 2)
            {
                EgyptAway4.SetActive(true);
            }
            if (EAshortsleft == 1)
            {
                EgyptAway5.SetActive(true);
            }
            EAshortsleft--;
        }
        if (num == 3)
        {
            if (LPHshortsleft == 4)
            {
                LiverpoolHome2.SetActive(true);
            }
            if (LPHshortsleft == 3)
            {
                LiverpoolHome3.SetActive(true);
            }
            if (LPHshortsleft == 2)
            {
                LiverpoolHome4.SetActive(true);
            }
            if (LPHshortsleft == 1)
            {
                LiverpoolHome5.SetActive(true);
            }
            LPHshortsleft--;
        }
        if (num == 4)
        {
            if (LPAshortsleft == 4)
            {
                LiverpoolAway2.SetActive(true);
            }
            if (LPAshortsleft == 3)
            {
                LiverpoolAway3.SetActive(true);
            }
            if (LPAshortsleft == 2)
            {
                LiverpoolAway4.SetActive(true);
            }
            if (LPAshortsleft == 1)
            {
                LiverpoolAway5.SetActive(true);
            }
            LPAshortsleft--;
        }
    }


}
