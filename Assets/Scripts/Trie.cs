using UnityEditor;
using UnityEngine;
public class Trie
{
    private readonly TrieNode root;
    public Trie()
    {
        root = new TrieNode();
    }
    public void Insert(string word)
    {
        var currentNode = root;
        Debug.Log(word);
        foreach (var letter in word)
        {
            if (!currentNode.children.ContainsKey(letter))
            {
                currentNode.children[letter] = new TrieNode();
                Debug.Log(letter);
            }
            currentNode = currentNode.children[letter];
            Debug.Log(". end of word ");
        }
        currentNode.isEndOfWord = true;
    }
    public bool Search(string word)
    {
        var currentNode = root;
        foreach (var letter in word)
        {
            if (!currentNode.children.ContainsKey(letter))
            {
                return false;
            }
            currentNode = currentNode.children[letter];
        }
        return currentNode.isEndOfWord;
    }
    public bool StartWith(string prefix)
    {
        var currentNode = root;
        foreach (var letter in prefix)
        {
            if (!currentNode.children.ContainsKey(letter))
            {
                return false;
            }
            currentNode = currentNode.children[letter];
        }
        return true;
    }
}
