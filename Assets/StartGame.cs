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

 public void Update()
 {
  Username = InsertedName.GetComponent<TMP_InputField>().text;
 }

 public void Start()
 {
  PlayerPrefs.SetString("username", Username);
  gameObject.GetComponent<Button>().onClick.AddListener(LoadScene);
 }

 private void LoadScene()
 {
  SceneManager.LoadScene("ExplainLevel1");
 }
 
}
