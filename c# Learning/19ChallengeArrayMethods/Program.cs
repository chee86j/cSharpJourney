string pangram = "The quick brown fox jumps over the lazy dog";

/*
Expected Output:
    ehT kciuq nworb xof spmuj revo eht yzal god
*/

//-----Reverse a String-----
char[] pangramArray = pangram.ToCharArray();
Array.Reverse(pangramArray);
Console.WriteLine(pangramArray);
