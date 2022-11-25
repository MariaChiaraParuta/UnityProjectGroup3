using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class StartGame : MonoBehaviour
{
 public GameObject InsertedName;
 public string Username;
 public GameObject InsertedAge;
 public string Age;
 public void Start()
 {
  gameObject.GetComponent<Button>().onClick.AddListener(LoadScene);
 }

 public void Update()
 {
  Username = InsertedName.GetComponent<TMP_InputField>().text;
  PlayerPrefs.SetString("username", Username);
  Age = InsertedAge.GetComponent<TMP_InputField>().text;
  PlayerPrefs.SetString("age", Age);

 }
 
 private void LoadScene()
 {
  SceneManager.LoadScene("SantaIntro");
 }
 
}
