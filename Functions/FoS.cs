namespace FoS;
using System;
using System.Collections.Generic;

class FoS
{
    public static string BruteForce(string pattern, string text)
    {
        int t_size = text.Length;
        int p_size = pattern.Length;
        int last_i = t_size - p_size;
        int start = 0;
        List<int> list_of_indices = new List<int>();
        //string answer = "";

        // index each search window starts from
        for (start = 0; start <= last_i; start++)
        {
            int count = 0;
            // searching within each search window
            for (int i = 0; i < p_size; i++)
            {
                if (text[start + i] == pattern[i])
                    count++;
                else
                    break;
            }
            if (count == p_size)
                list_of_indices.Add(start);
        }

        int aux = 0;

        if (list_of_indices.Count > 10)
        {
            foreach (int result in list_of_indices)
            {
                aux++;
            }
            string ans = aux.ToString() + " ocurrencias";
            return ans;
        }
        else
        {
            string stringOfIndices = string.Join(" - ", list_of_indices);
            return stringOfIndices;
        }
    }
    private static int[] ComputeLPS(string pat)
    {
        int m = pat.Length;
        int[] lps = new int[m];

        int i = 1;
        int j = 0;

        while (i < m)
        {
            if (pat[i] == pat[j])
            {
                lps[i] = j + 1;
                i++;
                j++;
            }
            else
            {
                if (j == 0)
                {
                    lps[i] = 0;
                    i++;
                }
                else
                {
                    j = lps[j - 1];
                }
            }
        }
        return lps;
    }
    public static string SearchKMP(string pattern, string text)
    {
        int n = text.Length;
        int m = pattern.Length;

        List<int> listOfIndices = new List<int>();
        //string answer = "";

        int[] lps = ComputeLPS(pattern);
        int i = 0; // index for text
        int j = 0; // index for pat

        while (i < n)
        {
            if (pattern[j] == text[i])
            {
                i++;
                j++;
            }
            else
            {
                if (j == 0)
                {
                    i++;
                }
                else
                {
                    j = lps[j - 1];
                }
            }

            if (j == m)
            {
                listOfIndices.Add(i - j);
                j = lps[j - 1];
            }
        }

        int count = 0;

        if (listOfIndices.Count > 10)
        {
            foreach (int result in listOfIndices)
            {
                count++;
            }
            string ans = count.ToString() + " ocurrencias";
            return ans;
        }
        else
        {
            string stringOfIndices = string.Join(" - ", listOfIndices);
            return stringOfIndices;
        }
    }

    private static Dictionary<char, int> GenerateBadMatchTable(string pattern)
    {
        var badMatchTable = new Dictionary<char, int>();
        int patternLength = pattern.Length;

        for (int i = 0; i < patternLength - 1; i++)
        {
            char currentChar = pattern[i];
            int distance = patternLength - i - 1;

            if (!badMatchTable.ContainsKey(currentChar))
            {
                badMatchTable[currentChar] = distance;
            }
            else
            {
                badMatchTable[currentChar] = Math.Max(distance, badMatchTable[currentChar]);
            }
        }

        return badMatchTable;
    }

    public static string BoyerMoore(string pattern, string text)
    {
        var badMatchTable = GenerateBadMatchTable(pattern);
        int textLength = text.Length;
        int patternLength = pattern.Length;
        int index = patternLength - 1;
        var results = new List<int>();

        while (index < textLength)
        {
            int patternIndex = patternLength - 1;
            int textIndex = index;

            while (patternIndex >= 0 && text[textIndex] == pattern[patternIndex])
            {
                patternIndex--;
                textIndex--;
            }

            if (patternIndex < 0)
            {
                results.Add(textIndex + 1); // Se encontró una coincidencia
            }

            char mismatchedChar = text[textIndex];
            if (badMatchTable.ContainsKey(mismatchedChar))
            {
                int badMatchShift = badMatchTable[mismatchedChar];
                index += badMatchShift;
            }
            else
            {
                index += patternLength; // Saltar la longitud completa del patrón
            }
        }

        int count = 0;

        if (results.Count > 10)
        {
            foreach (int result in results)
            {
                count++;
            }
            string ans = count.ToString() + " ocurrencias";
            return ans;
        }
        else
        {
            string stringOfIndices = string.Join(" - ", results);
            return stringOfIndices;
        }
    }
}