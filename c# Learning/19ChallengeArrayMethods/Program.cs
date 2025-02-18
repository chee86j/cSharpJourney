// Given the following string, reverse the order of the words and output the result.

string pangram = "The quick brown fox jumps over the lazy dog";

/*
Expected Output:
    ehT kciuq nworb xof spmuj revo eht yzal god
*/

//-----Solution-----
string[] words = pangram.Split(' ');

for (int i = 0; i < words.Length; i++)
{
    char[] letters = words[i].ToCharArray();
    Array.Reverse(letters);
    words[i] = new string(letters);
}

string result = string.Join(" ", words);
Console.WriteLine(result);

/*
1.  We start by splitting the pangram string into an array of words using the Split()
    method.
2.  We then iterate through each word in the array.
3.  For each word, we convert it into an array of characters using the ToCharArray()
    method.
4.  We reverse the order of the characters in the array using the Array.Reverse()
    method.
5.  We then convert the reversed character array back into a string and assign it back
    to the original word in the array.
6.  Finally, we join the reversed words back into a single string using the Join()
    method and output the result.
*/


// Given the following string, order the stream of items by the order in the 
// orderStream string.
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

/*
Expected Output:
    A345
    B123
    B177
    B179
    C15     - Error
    C234
    C235
    G3003   - Error
*/

//-----Solution-----
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}

/*
1.  We start by splitting the orderStream string into an array of items using the 
    Split() method.
2.  We then sort the items array using the Array.Sort() method, which will order the
    items alphabetically.
3.  We iterate through each item in the sorted array.
4.  If the length of the item is 4 characters, we output the item.
5.  If the length of the item is not 4 characters, we output the item followed by an
    error message.
6.  This solution assumes that the orderStream string contains items with fixed lengths
    of 4 characters and that the items need to be ordered alphabetically.
*/
