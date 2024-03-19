using UnityEngine;

public class Wear_Shirt : MonoBehaviour
{
    private int EHshirtsleft = 5;
    private int EAshirtsleft = 4;
    private int LPHshirtsleft = 4;
    private int LPAshirtsleft = 4;
    public int Currentjersey = 1;
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
        if (cloth.tag == "EgyptHome" && cloth.name == "EgyptHomeJersey")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentjersey);
            if(Currentjersey == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentjersey == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentjersey == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentjersey == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inEgyptHome.SetActive(true);
            Currentjersey = 1;
        }

        if (cloth.tag == "EgyptAway" && cloth.name == "EgyptAwayJersey")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentjersey);
            if (Currentjersey == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentjersey == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentjersey == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentjersey == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inEgyptAway.SetActive(true);
            Currentjersey = 2;
        }

        if (cloth.tag == "LiverpoolHome" && cloth.name == "LiverpoolHomeJersey")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentjersey);
            if (Currentjersey == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentjersey == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentjersey == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentjersey == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inLiverpoolHome.SetActive(true);
            Currentjersey = 3;
        }

        if (cloth.tag == "LiverpoolAway" && cloth.name == "LiverpoolAwayJersey")
        {
            Destroy(cloth.gameObject);
            showcloth(Currentjersey);
            if (Currentjersey == 1)
            {
                inEgyptHome.SetActive(false);
            }
            if (Currentjersey == 2)
            {
                inEgyptAway.SetActive(false);
            }
            if (Currentjersey == 3)
            {
                inLiverpoolHome.SetActive(false);
            }
            if (Currentjersey == 4)
            {
                inLiverpoolAway.SetActive(false);
            }
            inLiverpoolAway.SetActive(true);
            Currentjersey = 4;
        }
    }

    public void showcloth(int num)
    {
        if(num == 1)
        {
            if(EHshirtsleft == 5)
            {
                EgyptHome1.SetActive(true);
            }
            if (EHshirtsleft == 4)
            {
                EgyptHome2.SetActive(true);
            }
            if (EHshirtsleft == 3)
            {
                EgyptHome3.SetActive(true);
            }
            if (EHshirtsleft == 2)
            {
                EgyptHome4.SetActive(true);
            }
            if (EHshirtsleft == 1)
            {
                EgyptHome5.SetActive(true);
            }
            EHshirtsleft--;
        }
        if (num == 2)
        {
            if (EAshirtsleft == 4)
            {
                EgyptAway2.SetActive(true);
            }
            if (EAshirtsleft == 3)
            {
                EgyptAway3.SetActive(true);
            }
            if (EAshirtsleft == 2)
            {
                EgyptAway4.SetActive(true);
            }
            if (EAshirtsleft == 1)
            {
                EgyptAway5.SetActive(true);
            }
            EAshirtsleft--;
        }
        if (num == 3)
        {
            if (LPHshirtsleft == 4)
            {
                LiverpoolHome2.SetActive(true);
            }
            if (LPHshirtsleft == 3)
            {
                LiverpoolHome3.SetActive(true);
            }
            if (LPHshirtsleft == 2)
            {
                LiverpoolHome4.SetActive(true);
            }
            if (LPHshirtsleft == 1)
            {
                LiverpoolHome5.SetActive(true);
            }
            LPHshirtsleft--;
        }
        if (num == 4)
        {
            if (LPAshirtsleft == 4)
            {
                LiverpoolAway2.SetActive(true);
            }
            if (LPAshirtsleft == 3)
            {
                LiverpoolAway3.SetActive(true);
            }
            if (LPAshirtsleft == 2)
            {
                LiverpoolAway4.SetActive(true);
            }
            if (LPAshirtsleft == 1)
            {
                LiverpoolAway5.SetActive(true);
            }
            LPAshirtsleft--;
        }
    }


}
