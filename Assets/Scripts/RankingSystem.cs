using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class RankingSystem : MonoBehaviour
{
    public TMP_Text entriesText;
    public int maxEntriesPerPage = 10;

    private List<string> allEntries = new List<string>();
    private int currentPage = 1;

    // Function to add entries to the ranking system
    public void AddEntry(string newEntry)
    {
        allEntries.Add(newEntry);
        UpdateEntriesText();
    }

    // Function to update the displayed entries text
    private void UpdateEntriesText()
    {
        entriesText.text = "";

        int startIndex = (currentPage - 1) * maxEntriesPerPage;
        int endIndex = Mathf.Min(startIndex + maxEntriesPerPage, allEntries.Count);

        for (int i = startIndex; i < endIndex; i++)
        {
            entriesText.text += allEntries[i] + "\n";
        }
    }

    // Function to navigate to the next page
    public void NextPage()
    {
        currentPage++;
        UpdateEntriesText();
    }

    // Function to navigate to the previous page
    public void PreviousPage()
    {
        if (currentPage > 1)
        {
            currentPage--;
            UpdateEntriesText();
        }
    }
}
