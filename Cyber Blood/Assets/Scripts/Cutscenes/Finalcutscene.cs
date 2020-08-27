using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finalcutscene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textBox1;
    public GameObject textBox2;
    public GameObject textBox3;
    public GameObject textBox4;
    public string sceneName;
    void Start()
    {
        StartCoroutine(Sequence());
        Scene currentscene = SceneManager.GetActiveScene();
        sceneName = currentscene.name;
    }
    void Update()
    {
        if (Input.GetKeyUp("escape") && sceneName == "FinalCutscene")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(1);
        textBox1.GetComponent<Text>().text = "Ralph blows up the New Government Order's HQ and lives to tell the tale.";
        Destroy(textBox1, 5.0f);
        yield return new WaitForSeconds(6);
        textBox2.GetComponent<Text>().text = "The leftover Superiors now bow to Ralph as a saviour and start accepting themselves as a human species. ";
        Destroy(textBox2, 5.0f);
        yield return new WaitForSeconds(6);
        textBox3.GetComponent<Text>().text = "Congratulations Player, you have saved the future of our planet.";
        Destroy(textBox3, 5.0f);
        yield return new WaitForSeconds(6);;
        textBox4.GetComponent<Text>().text = "A CIU211 Project by Seth, Arjun, Andras & Kevin";
        Destroy(textBox3, 5.0f);
        yield return new WaitForSeconds(6); ;
        SceneManager.LoadScene("MainMenu");
    }
}

