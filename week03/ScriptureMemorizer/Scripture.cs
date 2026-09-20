using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordList = text.Split(' ');
        foreach (string word in wordList)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";
        foreach (Word currentWord in _words)
        {
            result += currentWord.GetDisplayText() + " ";
        }
        return result.Trim();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int hiddenCount = 3; // Number of words to hide

        for (int i = 0; i < hiddenCount; i++)
        {
            List<int> visibleIndices = new List<int>();
            for (int j = 0; j < _words.Count; j++)
            {
                if (!_words[j].IsHidden())
                {
                    visibleIndices.Add(j);
                }
            }

            if (visibleIndices.Count == 0)
            {
                break;
            }

            int randomPosition = random.Next(visibleIndices.Count);
            int wordindex = visibleIndices[randomPosition];
            _words[wordindex].Hide();
        }
        
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word currentWord in _words)
        {
            if (!currentWord.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
        