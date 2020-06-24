
public class Solution
{
  public List<string> findAndReplacePattern(string[] words, string pattern)
  {
    List<string> result = new List<string>();
    foreach(string word in words){
      //Console.WriteLine($"Word is: {word}");
      if (matchesPattern(word,pattern))
        result.Add(word);
    }
    return result;
  }
  
  private bool matchesPattern(string word, string pattern){
    if (word.Length != pattern.Length)
      return false;
    Dictionary<char,char> patternMap = new Dictionary<char,char>();
    Dictionary<char,char> wordMap = new Dictionary<char,char>();
    for(int i = 0; i <pattern.Length; i++){
      //Console.WriteLine($"Trying to map {pattern[i]} to {word[i]}");
      patternMap.TryAdd(pattern[i],word[i]);
      wordMap.TryAdd(word[i],pattern[i]);
      if (patternMap[pattern[i]]!= word[i] || wordMap[word[i]] != pattern[i])
        return false;
    }
    return true;
  }
}
