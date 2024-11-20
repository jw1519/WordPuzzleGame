using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrieNode : MonoBehaviour
{
    public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    public bool IsEndOfWord = false;
}
