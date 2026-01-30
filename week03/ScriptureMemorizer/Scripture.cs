using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // STRETCH CHALLENGE: Only hide words that are not already hidden
        List<int> visibleIndices = new List<int>();
        
        // Find all visible words
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndices.Add(i);
            }
        }
        
        // Hide up to numberToHide words (or all remaining visible words)
        int wordsToHide = Math.Min(numberToHide, visibleIndices.Count);
        
        for (int i = 0; i < wordsToHide; i++)
        {
            // Pick a random visible word
            int randomIndex = random.Next(visibleIndices.Count);
            int wordIndex = visibleIndices[randomIndex];
            
            // Hide it
            _words[wordIndex].Hide();
            
            // Remove from visible list so we don't pick it again
            visibleIndices.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + " ";
        
        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }
        
        return display.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    
    // STRETCH CHALLENGE: Count remaining visible words
    public int GetVisibleWordCount()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }
}