using UnityEngine;
using System.Collections.Generic;

public class XMasGame : MonoBehaviour{

    /*
    Aufgabenstellung: Refaktorisierung

    - Legen Sie ein neues Unity-Projekt mit dem Namen "Test_Refaktorisierung" an.
    - Erstellen Sie eine neue private Git-Repository: "Test_1_Unity_[IhrName]".
    - Initialisieren Sie das Projekt mit den notwendigen Inhalten und pushen Sie es in Ihre Repository.
    - Im Projekt erstellen Sie einen Ordner "Scripts" mit zwei Unterordnern: "badCode" und "goodCode".
    - Im "badCode"-Ordner speichern Sie alle orig.-Skripte wie "XMasGame_badCode.cs".
    - Refaktorisieren Sie die badCode Skripte gemäß den Best Practices der Code-Formatierung und
      speichern Sie die verbesserte Version im "goodCode"-Ordner ohne den Zusatz _badCode z.B.: "XMasGame.cs".
      (Achten Sie darauf, sowohl den Dateinamen als auch den Klassennamen im Skript zu ändern.)
    - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion
    - Nach jeder Refaktorisierungen erfolgt ein Push auf Git mit deskriptiven Namen.
    - NumberFilter.cs und SceneObjectManager.cs sollen um Screenshots der jeweiligen Button Funktionen, also die
      entsprechenden ConsolenAusgabe ergänzt werden. Laden Sie die Screenshoots mit entsprechnder Bezeichnung zu ihrer Repo .md hoch.
    - Der Einsatz von KI-Tools wie ChatGPT etc. ist nicht gestattet
    - Hilfestellungen untereinander sind nicht gestattet
    - Zum Abschluss soll vor Abgabe ein Finaler Push zur mit dem Namen Abgabe erfolgen.
    - Nach Abschluss ALLER Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
     */
    
    public int Presents = 4;
    public string isWinning;
    public int SantaHealth = 100;
    public List<string> GiftInventory = new List<string>();
    public GameObject Sleigh;
    private bool isFalling;
    private float FlyingSpeed = 10f;
    public GameObject SantaGo;

        void Start()
    { 
        SantaHealth = 80;
        Debug.Log("Weihnachtsabenteuer beginnt!"); 
    }
    void Update()
    { 
        SantaGo = GameObject.Find("Santa");
        if (SantaHealth > 0)
        { 
            CheckMovement(); 
            CheckInventory();
        }
        else 
        {
            Debug.Log("Weihnachten ist vorbei!");
        } 
    } 
    
    void CheckMovement()
{
        if (isFalling)
        {
            var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            Sleigh.transform.Translate(move * FlyingSpeed * Time.deltaTime);
        }
        else 
        {
            Debug.Log("Santa kann nicht fliegen!"); 
        } 
    }
    void CheckInventory() 
    {
        if (GiftInventory.Count == 0) 
        { 
            Debug.Log("Keine Geschenke vorhanden.");
        } 
        else 
        { 
            foreach (var gift in GiftInventory)
            {
                Debug.Log("Geschenk im Inventar: " + gift); 
            }
        }
         
    }
public void TakeDamage(int damage)
    { 
        SantaHealth -= damage;

        if (SantaHealth < 0) 
        {
            SantaHealth = 0; 
        } 
    }
            public void AddGiftToInventory(string gift)
    { 
        if (GiftInventory.Contains(gift))
        {
            GiftInventory.Add(gift); 
        } 
    } 
    public void StartFlying()
    {
        isFalling = true; 
    }
    public void StopFlying()
    { 
        isFalling = false; 
    }}
