using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    public GameObject stage2msg;
    public GameObject Endmsg;
    public Text finalscore;
    // Hoop Throwing ---------------------
    public GameObject Thrownhoop1;
    public GameObject Thrownhoop2;
    public GameObject Thrownhoop3;
    public GameObject Thrownhoop4;
    public GameObject Thrownhoop5;
    // -----------------------------------
    public bool skipped = false;
    // UI -----------------------------
    public Text currentlevel;
    public Text TotalScore;
    public Text Shotsleft;
    public Text Hoopsleft;
    public Text Stage1Score;
    public Text Rocksleft;
    public Text Stage2Score;
    private int shotsleft = 10;
    private int hoopsleft = 5;
    private int rocksleft = 5;
    private int totalscore = 0;
    private int stage1score = 0;
    private int stage2score = 0;
    public GameObject currenthit;
    public GameObject All0;
    public GameObject Hoop10;
    public GameObject Hoop5;
    public GameObject Hoop1;
    public GameObject Rock10;
    public GameObject Rock9;
    public GameObject Rock8;
    public GameObject Rock7;
    public GameObject Rock6;
    public GameObject Rock5;
    public GameObject Rock4;
    public GameObject Rock3;
    public GameObject Rock2;
    public GameObject Rock1;
    // --------------------------------
    public bool hit1 = false;
    public bool hit5 = false;
    public bool hit10 = false;
    // --------------------------------
    public GameObject fireworks;
    public GameObject rock1;
    public GameObject target1;
    public GameObject rock2;
    public GameObject target2;
    public GameObject rock3;
    public GameObject target3;
    public GameObject rock4;
    public GameObject target4;
    public GameObject rock5;
    public GameObject target5;
    public GameObject Threat;
    public int fallenrocks = 0;
    //---------------------------------
    public GameObject firstcolliders;
    public GameObject secondcolliders;
    public GameObject HoopThrowing;
    public GameObject RockThrowing;
    public AudioSource ding;

    public void HoopThrown()
    {
        hoopsleft--;
        StartCoroutine(Countdown("hoop"));
    }
    public void RockThrown()
    {
        rocksleft--;
        StartCoroutine(Countdown("rock"));
    }

    private void CalculateHoopScore()
    {
        if(hit10 == true)
        {
            stage1score = stage1score + 10;
            currenthit.SetActive(false);
            Hoop10.SetActive(true);
            currenthit = Hoop10;
            fireworks.SetActive(true);
            StartCoroutine(Countup());

        }
        else if (hit5 == true)
        {
            stage1score = stage1score + 5;
            currenthit.SetActive(false);
            Hoop5.SetActive(true);
            currenthit = Hoop5;
        }
        else if (hit1 == true)
        {
            stage1score = stage1score + 1;
            currenthit.SetActive(false);
            Hoop1.SetActive(true);
            currenthit = Hoop1;
        }
        else
        {
            currenthit.SetActive(false);
            All0.SetActive(true);
            currenthit = All0;
        }
        ding.Play();
        UpdateUI();
        resethis();
        if (hoopsleft == 4)
        {
            Thrownhoop2.SetActive(true);
        }
        else if (hoopsleft == 3)
        {
            Thrownhoop3.SetActive(true);
        }
        else if (hoopsleft == 2)
        {
            Thrownhoop4.SetActive(true);
        }
        else if (hoopsleft == 1)
        {
            Thrownhoop5.SetActive(true);
        }
        if (hoopsleft == 0)
        {
            currentlevel.text = "Current Level: Rock Throwing";
            firstcolliders.SetActive(false);
            HoopThrowing.SetActive(false);
            Thrownhoop1.SetActive(false);
            Thrownhoop2.SetActive(false);
            Thrownhoop3.SetActive(false);
            Thrownhoop4.SetActive(false);
            Thrownhoop5.SetActive(false);
            stage2msg.SetActive(true);
            StartCoroutine(Countdown("stage"));
            secondcolliders.SetActive(true);
            RockThrowing.SetActive(true);
        }
        skipped = false;
    }
    private void CalculateRockScore()
    {
        stage2score = stage2score + fallenrocks;
        ding.Play();
        if (fallenrocks == 10)
        {
            currenthit.SetActive(false);
            Rock10.SetActive(true);
            currenthit = Rock10;
            fireworks.SetActive(true);
            StartCoroutine(Countup());
        }
        else if (fallenrocks == 9)
        {
            currenthit.SetActive(false);
            Rock9.SetActive(true);
            currenthit = Rock9;
        }
        else if (fallenrocks == 8)
        {
            currenthit.SetActive(false);
            Rock8.SetActive(true);
            currenthit = Rock8;
        }
        else if (fallenrocks == 7)
        {
            currenthit.SetActive(false);
            Rock7.SetActive(true);
            currenthit = Rock7;
        }
        else if (fallenrocks == 6)
        {
            currenthit.SetActive(false);
            Rock6.SetActive(true);
            currenthit = Rock6;
        }
        else if (fallenrocks == 5)
        {
            currenthit.SetActive(false);
            Rock5.SetActive(true);
            currenthit = Rock5;
        }
        else if (fallenrocks == 4)
        {
            currenthit.SetActive(false);
            Rock4.SetActive(true);
            currenthit = Rock4;
        }
        else if (fallenrocks == 3)
        {
            currenthit.SetActive(false);
            Rock3.SetActive(true);
            currenthit = Rock3;
        }
        else if (fallenrocks == 2)
        {
            currenthit.SetActive(false);
            Rock2.SetActive(true);
            currenthit = Rock2;
        }
        else if (fallenrocks == 1)
        {
            currenthit.SetActive(false);
            Rock1.SetActive(true);
            currenthit = Rock1;
        }
        else
        {
            currenthit.SetActive(false);
            All0.SetActive(true);
            currenthit = All0;
        }
        fallenrocks = 0;
        UpdateUI();
        if(rocksleft == 4)
        {
            rock1.SetActive(false);
            rock2.SetActive(true);
            target1.SetActive(false);
            target2.SetActive(true);
        }
        else if(rocksleft == 3)
        {
            rock2.SetActive(false);
            rock3.SetActive(true);
            target2.SetActive(false);
            target3.SetActive(true);
        }
        else if (rocksleft == 2)
        {
            rock3.SetActive(false);
            rock4.SetActive(true);
            target3.SetActive(false);
            target4.SetActive(true);
            Threat.SetActive(true);
        }
        else if (rocksleft == 1)
        {
            rock4.SetActive(false);
            rock5.SetActive(true);
            target4.SetActive(false);
            target5.SetActive(true);
        }
        else
        {
            Endmsg.SetActive(true);

        }
        skipped = false;
    }

    private IEnumerator Countdown(string type)
    {
        if (type == "hoop")
        {
            float counter = 3f;
            while (counter > 0)
            {
                yield return new WaitForSeconds(1);
                counter--;
            }
            CalculateHoopScore();
        }
        else if (type == "stage")
        {
            float counter = 2f;
            while (counter > 0)
            {
                yield return new WaitForSeconds(1);
                counter--;
            }
            stage2msg.SetActive(false);
        }
        else
        {
            float counter = 4f;
            while (counter > 0)
            {
                yield return new WaitForSeconds(1);
                counter--;
            }
            CalculateRockScore();
        }
    }

    private IEnumerator Countup()
    {
        float counter = 3f;
        while (counter > 0)
        {
            yield return new WaitForSeconds(1);
            counter--;
        }
        fireworks.SetActive(false);
    }

    private void resethis()
    {
        hit1 = false;
        hit5 = false;
        hit10 = false;
}
    public void UpdateUI()
    {
        totalscore = stage1score + stage2score;
        shotsleft = hoopsleft + rocksleft;
        string shotsleftstr = "Shots left: " + shotsleft.ToString();
        string totalscorestr = "Total Score: " + totalscore.ToString();
        string finalscorestr = "Final Score: " + totalscore.ToString();
        string hoopsleftstr = "Hoops left: " + hoopsleft.ToString();
        string stage1scorestr = "Score: " + stage1score.ToString();
        string rocksleftstr = "Balls left: " + rocksleft.ToString();
        string stage2scoretr = "Score: " + stage2score.ToString();

        TotalScore.text = totalscorestr;
        finalscore.text = finalscorestr;
        Shotsleft.text = shotsleftstr;
        Hoopsleft.text = hoopsleftstr;
        Stage1Score.text = stage1scorestr;
        Rocksleft.text = rocksleftstr;
        Stage2Score.text = stage2scoretr;
    }
}
