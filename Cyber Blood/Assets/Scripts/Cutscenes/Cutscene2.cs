using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cutscene2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textBox1;
    public GameObject textBox2;
    public GameObject textBox3;
    public GameObject textBox4;
    public GameObject textBox5;
    public GameObject textBox6;
    public GameObject textBox7;
    public GameObject textBox8;
    public GameObject textBox9;
    public GameObject textBox10;
    public GameObject textBox11;
    public GameObject textBox12;
    public GameObject textBox13;
    public GameObject textBox14;
    public GameObject textBox15;
    public GameObject textBox16;
    public GameObject textBox17;
    public string sceneName;
    void Start()
    {
        StartCoroutine(Sequence());
        Scene currentscene = SceneManager.GetActiveScene();
        sceneName = currentscene.name;
    }
    void Update()
    {
        if (Input.GetKeyUp("escape") && sceneName == "Cutscene2")
        {
            SceneManager.LoadScene("Area2");
        }
    }
    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(1);
        textBox1.GetComponent<Text>().text = "As a last resort, the border forces decided to blow themselves up in order to stop Ralph.";
        Destroy(textBox1, 4.0f);
        yield return new WaitForSeconds(5);
        textBox2.GetComponent<Text>().text = "4 days later......";
        Destroy(textBox2, 3.0f);
        yield return new WaitForSeconds(4);
        textBox3.GetComponent<Text>().text = "Lily: Hey you, you're finally awake. You were trying to cross the border, right? You were successful, barely.";
        yield return new WaitForSeconds(5);
        textBox4.GetComponent<Text>().text = "Ralph: *Tries to get up and look around for a nearby weapon.*";
        yield return new WaitForSeconds(3);
        textBox5.GetComponent<Text>().text = "Lily: If you're looking for your weapons, it's on the nearby table. I'm not the enemy. All you need to do is look at me to confirm it.";
        yield return new WaitForSeconds(5);
        textBox6.GetComponent<Text>().text = "Ralph: I thought I was the only one left.";
        yield return new WaitForSeconds(3);
        textBox7.GetComponent<Text>().text = "Lily: That makes two of us. You lost an arm and a lot of blood. We're the same blood type, so I transferred some of mine. Your arm has been replaced with a cybernetic.";
        yield return new WaitForSeconds(7);
        Destroy(textBox3, 0.1f);
        Destroy(textBox4, 0.1f);
        Destroy(textBox5, 0.1f);
        Destroy(textBox6, 0.1f);
        Destroy(textBox7, 0.1f);
        yield return new WaitForSeconds(1);
        textBox8.GetComponent<Text>().text = "Ralph: Then that doesn't make me human anymore.";
        yield return new WaitForSeconds(3);
        textBox9.GetComponent<Text>().text = "Lily: As long as you still have blood and organs, you're human. I would've killed you if I didn't see a beating biological heart.";
        yield return new WaitForSeconds(5);
        textBox10.GetComponent<Text>().text = "Ralph: So our goals are the same. I've realized I can't do this alone. Will you come with me?";
        yield return new WaitForSeconds(5);
        textBox11.GetComponent<Text>().text = "Lily: On your suicide mission to kill the robot leaders? No, but I've lived in this territory long enough to be able to guide you.";
        yield return new WaitForSeconds(5);
        textBox12.GetComponent<Text>().text = "Ralph: I can accept that. Where am I right now and what do I need to do?";
        yield return new WaitForSeconds(5);
        Destroy(textBox8, 0.1f);
        Destroy(textBox9, 0.1f);
        Destroy(textBox10, 0.1f);
        Destroy(textBox11, 0.1f);
        Destroy(textBox12, 0.1f);
        yield return new WaitForSeconds(1);
        textBox13.GetComponent<Text>().text = "Lily: Right now you're in my underground shelter 400 miles East of the border. There's no hope of you entering the Capital City with the Deathzone nearby.";
        yield return new WaitForSeconds(6);
        textBox14.GetComponent<Text>().text = "Lily: No need to ask. The Deathzone is the Robot's largest military base. You need to detonate all the missiles in there and use the bunker nearby to save yourself.";
        yield return new WaitForSeconds(6);
        textBox15.GetComponent<Text>().text = "Lily: Of course, that's easier said than done. Just remember, I can't save you again.";
        yield return new WaitForSeconds(4);
        textBox16.GetComponent<Text>().text = "Ralph: I'm not giving up now. I'll leave tomorrow.";
        yield return new WaitForSeconds(3);
        textBox17.GetComponent<Text>().text = "Lily: Take this radio. It's directly linked to me.";
        yield return new WaitForSeconds(4);
        Destroy(textBox13, 0.1f);
        Destroy(textBox14, 0.1f);
        Destroy(textBox15, 0.1f);
        Destroy(textBox16, 0.1f);
        Destroy(textBox17, 0.1f);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Area2");
    }


}
