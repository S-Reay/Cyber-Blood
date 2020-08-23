using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textBox1;
    public GameObject textBox2;
    public GameObject textBox3;
    public GameObject textBox4;
    public GameObject textBox5;
    public GameObject textBox6;
    public GameObject textBox7;
    void Start()
    {
        textBox7.SetActive(false);
        StartCoroutine(Sequence());
    }

    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(1);
        textBox1.GetComponent<Text>().text = "In the year 2060, Humanity has toyed with it's own biology and created human parts made of metal, termed Cybernetics. They have become commonplace for those who can pay and acquire a legal license for it.";
        yield return new WaitForSeconds(7);
        textBox2.GetComponent<Text>().text = "However, the system for acquiring a license has been corrupted by the New Government Order, and only high ranking officials receive it. A war has sparked between those who agree and those who don't.";
        yield return new WaitForSeconds(7);
        textBox3.GetComponent<Text>().text = "Those who are modified with cybernetics are called the Superiors, or robots, while those who are unmodified are called the Inferiors, or humans.";
        yield return new WaitForSeconds(7);
        textBox4.GetComponent<Text>().text = "The inferiors set up a resistance group called the Blood Driven, meaning that they believe in human blood flowing through their body more than metal parts.";
        yield return new WaitForSeconds(7);
        textBox5.GetComponent<Text>().text = "Years of battles between the two groups have essentially separated the world’s population to two different species of humans & territories.";
        yield return new WaitForSeconds(7);
        textBox6.GetComponent<Text>().text = "Initially the Blood Driven were successful, entering The Superiors Territory and destroying their largest factories that created cybernetics.";
        yield return new WaitForSeconds(7);
        Destroy(textBox1, 0.1f);
        Destroy(textBox2, 0.1f);
        Destroy(textBox3, 0.1f);
        Destroy(textBox4, 0.1f);
        Destroy(textBox5, 0.1f);
        Destroy(textBox6, 0.1f);
        textBox7.SetActive(true);
        yield return new WaitForSeconds(7);
        Destroy(textBox7, 1.0f);
        SceneManager.LoadScene("FirstArea");
    }
}
