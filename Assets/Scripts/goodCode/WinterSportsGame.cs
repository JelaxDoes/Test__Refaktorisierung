using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class WinterSportsGame : MonoBehaviour
{
    /*
    Aufgabenstellung: Refaktorisierung

    - Refaktorisieren Sie das Skript gemäß den Best Practices der Code-Formatierung.
    - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
    - Achten Sie auf die konsistente Benennung von Variablen und Methoden.
    - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
    - Zum Abschluss soll vor Abgabe ein Finaler Push zur mit dem Namen Abgabe erfolgen.
    - Nach Abschluss ALLER Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
    */

    public int PlayerStamina = 100;
    public GameObject Ski;
    public List<string> Achievements = new List<string>();
    private bool isSkiing;
    public float speed = 10f;

    void Start()
    { 
        PlayerStamina = 100;     // Player hat 100 Leben und die Konsole sagt "WinterSports beginnt!"
        Debug.Log("WinterSports beginnt!");
    }
    void Update()
    {
        if (PlayerStamina > 0)  // Wenn die Playerhealt über 0 ist soll es die CheckSkiing Methode und die Check Achievements Methode abrufen
        {
            CheckSkiing();
            CheckAchievements();
        }
        else // Wenn Player health 0 oder drunter ist sagt die Konsole " Spiel beendet!"
        { 
            Debug.Log("Spiel beendet!"); 
        }
    }
    void CheckSkiing()
    {
        if (isSkiing)
        {
            var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // movement 
            Ski.transform.Translate(move * speed * Time.deltaTime);
        }
        else
        { 
            Debug.Log("Spieler kann nicht Ski fahren!"); // wenn er sich nicht bewegt "Spieler kann nicht Ski fahren!"
        } 
    }
    void CheckAchievements()
    {
        if (Achievements.Count == 0)
        { 
            Debug.Log("Keine Erfolge erzielt."); // Wenn der Achievement count 0 ist sagt die Konsole "Keine Erfolge erzielt."
        } 
        else 
        { 
            foreach (var achievement in Achievements)
            { 
                Debug.Log("Erfolg: " + achievement);  // sonst wird für jedes Achievement das es gibt " Erfolg: " name des achievements nagegeben von der Konsole
            } 
        }
    }
    public void LoseStamina(int amount)
    { 
        PlayerStamina -= amount;   // PlayerStamina ist nicht der Amount
        if (PlayerStamina < 0)// wenn playerstamina <0 ist ist sie automatisch 0
        { 
            PlayerStamina = 0; 
        } 
    }
    public void AddAchievement(string achievement)
    {
        if (!Achievements.Contains(achievement))
        {
            Achievements.Add(achievement); 
        } 
    }
    public void StartSkiing()  // er bewegt sich
    {
        isSkiing = true;
    }
    public void StopSkiing() // er bewegt sich nicht
    {
        isSkiing = false;
    }
}
