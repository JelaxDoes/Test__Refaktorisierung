using UnityEngine;
using System.Collections.Generic;

public class ItemCollector_badCode : MonoBehaviour
{
    /*
    Aufgabenstellung: Refaktorisierung

    - Vereinfachen Sie die Methode 'CollectItems' mithilfe eines Arrays und einer foreach-Schleife.
    - Refaktorisieren Sie den Code gemäß den Best Practices der Code-Formatierung.
    - Ergänzen Sie Codeblöcke mit Kommentaren zur Beschreibung ihrer Funktion.
    - Nach jeder Refaktorisierung erfolgt ein Push auf Git mit deskriptiven Namen.
    - Nach Abschluss aller Refaktorisierungen laden Sie oli90martin@web.de als Collaborator zu Ihrer Git-Repository ein.
    */

     public GameObject Item1;
     public GameObject Item2;
     public GameObject Item3;
     public GameObject Item4;
     public GameObject Item5;
     private List<GameObject> CollectedItems = new List<GameObject>();

     void Update()
     {
         CollectItems();
     }

    void CollectItems()
    {
        
        if (Item1 != null)
        {
            CollectedItems.Add(Item1);
        }
        else
        {
           foreach(var item in CollectedItems)
            {
                CollectedItems.Add(Item);
            }
        }

        if (Item2 != null)
        {
            CollectedItems.Add(Item2);
        }
        if (Item3 != null)
        {
            CollectedItems.Add(Item3);
        }
        if (Item4 != null)
        {
            CollectedItems.Add(Item4);
        }
        if (Item5 != null)
        {
            CollectedItems.Add(Item5);
        }
    }
}
