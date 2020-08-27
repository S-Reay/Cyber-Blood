using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cutscene3 : MonoBehaviour
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
        if (Input.GetKeyUp("escape") && sceneName == "Cutscene3")
        {
            SceneManager.LoadScene("Area3");
        }
    }
    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(1);
        textBox1.GetComponent<Text>().text = "In the end, Ralph successfully destroys the Deathzone and comes out alive.";
        Destroy(textBox1, 5.0f);
        yield return new WaitForSeconds(6);
        textBox2.GetComponent<Text>().text = "After taking shelter in a nearby destroyed village, Ralph sets out the next day.";
        Destroy(textBox2, 5.0f);
        yield return new WaitForSeconds(6);
        textBox3.GetComponent<Text>().text = "Lily guides him to a crack in the Capital City Walls that was commonly used by The Blood Driven but was yet to be discovered by the Superiors.";
        Destroy(textBox3, 5.0f);
        yield return new WaitForSeconds(6);
        textBox4.GetComponent<Text>().text = "Ralph's revenge begins now......";
        Destroy(textBox4, 5.0f);
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("Area3");
    }
}

