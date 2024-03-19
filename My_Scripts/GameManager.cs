using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int Ballsleft = 10;
    public GameObject Endmsg;
    public Text finalscore;
    //-----------------------------------------------------
    public Text currentlevel;
    public Text totalballsleft;
    public Text stage1ballsleft;
    public Text stage2ballsleft;
    public Text totalscore;
    public Text penaltyscore;
    public Text stage1score;
    public Text stage2score;
    private int stage1ballsleftnum = 5;
    private int stage2ballsleftnum = 5;
    private int totalscorenum = 0;
    private int penaltyscorenum = 0;
    private int stage1scorenum = 0;
    private int stage2scorenum = 0;
    //------------------------------------------------------
    public AddVelocity addvelocity1;
    public AddVelocity addvelocity2;
    public AudioSource scored;
    public AudioSource missed;
    public AudioSource whistle;
    public AudioSource beforepenalty1;
    public AudioSource beforepenalty2;
    private bool ballin = false;
    public GameObject Scene;
    public GameObject Player;
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;
    public GameObject ball6;
    public GameObject ball7;
    public GameObject ball8;
    public GameObject ball9;
    public GameObject ball10;
    public GameObject target1;
    public GameObject particles1;
    public GameObject target2;
    public GameObject particles2;
    public GameObject target3;
    public GameObject particles3;
    public GameObject target4;
    public GameObject particles4;
    public GameObject target5;
    public GameObject particles5;
    public GameObject target6_10;
    public GameObject particles6_10;
    public GameObject defaulttarget1;
    public GameObject redtarget1;
    public GameObject greentarget1;
    public GameObject defaulttarget2;
    public GameObject redtarget2;
    public GameObject greentarget2;
    public GameObject defaulttarget3;
    public GameObject redtarget3;
    public GameObject greentarget3;
    public GameObject defaulttarget4;
    public GameObject redtarget4;
    public GameObject greentarget4;
    public GameObject defaulttarget5;
    public GameObject redtarget5;
    public GameObject greentarget5;
    public GameObject defaulttarget6_10;
    public GameObject redtarget6_10;
    public GameObject greentarget6_10;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;
    public GameObject wall5;
    public void GoalIn1()
    {
        scored.Play();
        addvelocity1.stopcounter = true;
        addvelocity2.stopcounter = true;
        if (Ballsleft == 10)
        {
            defaulttarget1.SetActive(false);
            greentarget1.SetActive(true);
            particles1.SetActive(true);
            ballin = true;
            stage1scorenum++;
            stage1ballsleftnum--;
            StartCoroutine(Countdown(2,"In"));
        }
        else if(Ballsleft == 9)
        {
            defaulttarget2.SetActive(false);
            greentarget2.SetActive(true);
            particles2.SetActive(true);
            ballin = true;
            stage1scorenum++;
            stage1ballsleftnum--;
            StartCoroutine(Countdown(2, "In"));
        }
        else if(Ballsleft == 8)
        {
            defaulttarget3.SetActive(false);
            greentarget3.SetActive(true);
            particles3.SetActive(true);
            ballin = true;
            stage1scorenum++;
            stage1ballsleftnum--;
            StartCoroutine(Countdown(2, "In"));
        }
        else if(Ballsleft == 7)
        {
            defaulttarget4.SetActive(false);
            greentarget4.SetActive(true);
            particles4.SetActive(true);
            ballin = true;
            stage1scorenum++;
            stage1ballsleftnum--;
            StartCoroutine(Countdown(2, "In"));
        }
        else if(Ballsleft == 6)
        {
            defaulttarget5.SetActive(false);
            greentarget5.SetActive(true);
            particles5.SetActive(true);
            ballin = true;
            stage1scorenum++;
            stage1ballsleftnum--;
            StartCoroutine(Countdown(2, "In"));
        }
        else if(Ballsleft <= 5)
        {
            defaulttarget6_10.SetActive(false);
            greentarget6_10.SetActive(true);
            particles6_10.SetActive(true);
            ballin = true;
            stage2scorenum++;
            stage2ballsleftnum--;
            currentlevel.text = "Free Kicks";
            StartCoroutine(Countdown(2, "In"));
        }
        UpdateUI();
    }
    public void GoalOut1()
    {
        missed.Play();
        if (Ballsleft == 10)
        {
            if (ballin == false)
            {
                ball1.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                defaulttarget1.SetActive(false);
                redtarget1.SetActive(true);
                stage1ballsleftnum--;
                StartCoroutine(Countdown(2, "Out"));
            }
        }
        else if (Ballsleft == 9)
        {
            if (ballin == false)
            {
                ball2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                defaulttarget2.SetActive(false);
                redtarget2.SetActive(true);
                stage1ballsleftnum--;
                StartCoroutine(Countdown(2, "Out"));
            }
        }
        else if (Ballsleft == 8)
        {
            if (ballin == false)
            {
                ball3.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                defaulttarget3.SetActive(false);
                redtarget3.SetActive(true);
                stage1ballsleftnum--;
                StartCoroutine(Countdown(2, "Out"));
            }
        }
        else if (Ballsleft == 7)
        {
            if (ballin == false)
            {
                ball4.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                defaulttarget4.SetActive(false);
                redtarget4.SetActive(true);
                stage1ballsleftnum--;
                StartCoroutine(Countdown(2, "Out"));
            }
        }
        else if (Ballsleft == 6)
        {
            if (ballin == false)
            {
                ball5.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                defaulttarget5.SetActive(false);
                redtarget5.SetActive(true);
                stage1ballsleftnum--;
                StartCoroutine(Countdown(2, "Out"));
            }
        }
        else if(Ballsleft <= 5)
        {
            if (ballin == false)
            {
                ball6.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                ball7.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                ball8.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                ball9.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                ball10.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                defaulttarget6_10.SetActive(false);
                redtarget6_10.SetActive(true);
                stage2ballsleftnum--;
                currentlevel.text = "Free Kicks";
                StartCoroutine(Countdown(2, "Out"));
            }
        }
        UpdateUI();
    }

    private IEnumerator Countdown(float timer,string type)
    {
        float counter = timer;
        while (counter > 0)
        {
            yield return new WaitForSeconds(1);
            counter--;
        }
        if(type == "In")
        {
            GoalIn2();
        }
        else
        {
            GoalOut2();
        }
    }

    public void GoalIn2()
    {
        if (Ballsleft == 10)
        {
            greentarget1.SetActive(false);
            particles1.SetActive(false);
            target1.SetActive(false);
            target2.SetActive(true);
            defaulttarget2.SetActive(true);
            ball1.SetActive(false);
            ball2.SetActive(true);
            Ballsleft--;
            ballin = false;

        }
        else if (Ballsleft == 9)
        {
            greentarget2.SetActive(false);
            particles2.SetActive(false);
            target2.SetActive(false);
            target3.SetActive(true);
            defaulttarget3.SetActive(true);
            ball2.SetActive(false);
            ball3.SetActive(true);
            Ballsleft--;
            ballin = false;

        }
        else if (Ballsleft == 8)
        {
            greentarget3.SetActive(false);
            particles3.SetActive(false);
            target3.SetActive(false);
            target4.SetActive(true);
            defaulttarget4.SetActive(true);
            ball3.SetActive(false);
            ball4.SetActive(true);
            Ballsleft--;
            ballin = false;

        }
        else if (Ballsleft == 7)
        {
            greentarget4.SetActive(false);
            particles4.SetActive(false);
            target4.SetActive(false);
            target5.SetActive(true);
            defaulttarget5.SetActive(true);
            ball4.SetActive(false);
            ball5.SetActive(true);
            Ballsleft--;
            ballin = false;

        }
        else if (Ballsleft == 6)
        {
            greentarget5.SetActive(false);
            particles5.SetActive(false);
            target5.SetActive(false);
            target6_10.SetActive(true);
            defaulttarget6_10.SetActive(true);
            Scene.transform.position = new Vector3(-61.7f, -2.900529f, 33f);
            ball5.SetActive(false);
            ball6.SetActive(true);
            wall1.SetActive(true);
            Ballsleft--;
            ballin = false;

        }
        else if (Ballsleft == 5)
        {
            greentarget6_10.SetActive(false);
            particles6_10.SetActive(false);
            defaulttarget6_10.SetActive(true);
            Scene.transform.position = new Vector3(-57.7f, -2.900529f, 33f);
            ball6.SetActive(false);
            ball7.SetActive(true);
            wall1.SetActive(false);
            wall2.SetActive(true);
            Ballsleft--;
            ballin = false;

        }
        else if (Ballsleft == 4)
        {
            greentarget6_10.SetActive(false);
            particles6_10.SetActive(false);
            defaulttarget6_10.SetActive(true);
            Scene.transform.position = new Vector3(-65.4f, -2.900529f, 33f);
            ball7.SetActive(false);
            ball8.SetActive(true);
            wall2.SetActive(false);
            wall3.SetActive(true);
            Ballsleft--;
            ballin = false;

        }
        else if (Ballsleft == 3)
        {
            greentarget6_10.SetActive(false);
            particles6_10.SetActive(false);
            defaulttarget6_10.SetActive(true);
            Scene.transform.position = new Vector3(-66.9f, -2.900529f, 31.3f);
            ball8.SetActive(false);
            ball9.SetActive(true);
            wall3.SetActive(false);
            wall4.SetActive(true);
            Ballsleft--;
            ballin = false;

        }
        else if (Ballsleft == 2)
        {
            greentarget6_10.SetActive(false);
            particles6_10.SetActive(false);
            defaulttarget6_10.SetActive(true);
            Scene.transform.position = new Vector3(-56.7f, -2.900529f, 31.1f);
            ball9.SetActive(false);
            ball10.SetActive(true);
            wall4.SetActive(false);
            wall5.SetActive(true);
            Ballsleft--;
            ballin = false;

        }
        else
        {
            greentarget6_10.SetActive(false);
            particles6_10.SetActive(false);
            defaulttarget6_10.SetActive(true);
            ball10.SetActive(true);
            Ballsleft--;
            ballin = false;

        }
        whistle.Play();
    }
    public void GoalOut2()
    {
        if (Ballsleft == 10)
        {
            redtarget1.SetActive(false);
            target1.SetActive(false);
            target2.SetActive(true);
            defaulttarget2.SetActive(true);
            ball1.SetActive(false);
            ball2.SetActive(true);
            Ballsleft--;

        }
        else if (Ballsleft == 9)
        {
            redtarget2.SetActive(false);
            target2.SetActive(false);
            target3.SetActive(true);
            defaulttarget3.SetActive(true);
            ball2.SetActive(false);
            ball3.SetActive(true);
            Ballsleft--;
            beforepenalty1.Play();

        }
        else if (Ballsleft == 8)
        {
            redtarget3.SetActive(false);
            target3.SetActive(false);
            target4.SetActive(true);
            defaulttarget4.SetActive(true);
            ball3.SetActive(false);
            ball4.SetActive(true);
            Ballsleft--;

        }
        else if (Ballsleft == 7)
        {
            redtarget4.SetActive(false);
            target4.SetActive(false);
            target5.SetActive(true);
            defaulttarget5.SetActive(true);
            ball4.SetActive(false);
            ball5.SetActive(true);
            Ballsleft--;
            beforepenalty2.Play();

        }
        else if (Ballsleft == 6)
        {
            redtarget5.SetActive(false);
            target5.SetActive(false);
            target6_10.SetActive(true);
            defaulttarget6_10.SetActive(true);
            Scene.transform.position = new Vector3(-61.7f, -2.900529f, 33.2f);
            ball5.SetActive(false);
            ball6.SetActive(true);
            wall1.SetActive(true);
            Ballsleft--;

        }
        else if (Ballsleft == 5)
        {
            redtarget6_10.SetActive(false);
            defaulttarget6_10.SetActive(true);
            Scene.transform.position = new Vector3(-57.7f, -2.900529f, 33f);
            ball6.SetActive(false);
            ball7.SetActive(true);
            wall1.SetActive(false);
            wall2.SetActive(true);
            Ballsleft--;
            beforepenalty1.Play();

        }
        else if (Ballsleft == 4)
        {
            redtarget6_10.SetActive(false);
            defaulttarget6_10.SetActive(true);
            Scene.transform.position = new Vector3(-65.4f, -2.900529f, 33f);
            ball7.SetActive(false);
            ball8.SetActive(true);
            wall2.SetActive(false);
            wall3.SetActive(true);
            Ballsleft--;

        }
        else if (Ballsleft == 3)
        {
            redtarget6_10.SetActive(false);
            defaulttarget6_10.SetActive(true);
            Scene.transform.position = new Vector3(-66.9f, -2.900529f, 31.3f);
            ball8.SetActive(false);
            ball9.SetActive(true);
            wall3.SetActive(false);
            wall4.SetActive(true);
            Ballsleft--;
            beforepenalty2.Play();

        }
        else if (Ballsleft == 2)
        {
            redtarget6_10.SetActive(false);
            defaulttarget6_10.SetActive(true);
            Scene.transform.position = new Vector3(-56.7f, -2.900529f, 31.1f);
            ball9.SetActive(false);
            ball10.SetActive(true);
            wall4.SetActive(false);
            wall5.SetActive(true);
            Ballsleft--;

        }
        else
        {
            redtarget6_10.SetActive(false);
            defaulttarget6_10.SetActive(true);
            ball10.SetActive(true);
            Ballsleft--;
        }
        whistle.Play();
    }

    public void UpdateUI()
    {
        penaltyscorenum = stage1scorenum + stage2scorenum;
        totalscorenum = penaltyscorenum;
        string penaltyBallsleftstr = "Balls left: " + Ballsleft.ToString();
        string totalscorestr = "Total Score: " + totalscorenum.ToString();
        string finalscorestr = "Final Score: " + totalscorenum.ToString();
        string penaltyscorestr = "Score: " + penaltyscorenum.ToString();
        string stage1ballsleftstr = "Balls left: " + stage1ballsleftnum.ToString();
        string stage2ballsleftstr = "Balls left: " + stage2ballsleftnum.ToString();
        string stage1scorestr = "Score: " + stage1scorenum.ToString();
        string stage2scorestr = "Score: " + stage2scorenum.ToString();

        totalballsleft.text = penaltyBallsleftstr;
        stage1ballsleft.text = stage1ballsleftstr;
        stage2ballsleft.text = stage2ballsleftstr;
        totalscore.text = totalscorestr;
        finalscore.text = finalscorestr;
        penaltyscore.text = penaltyscorestr;
        stage1score.text = stage1scorestr;
        stage2score.text = stage2scorestr;
    }
    private void LateUpdate() {
        if(Ballsleft == 0) {
            Endmsg.SetActive(true);
        }
    }
}
