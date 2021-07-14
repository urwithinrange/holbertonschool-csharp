using System;
class Array
{
    public static int elementAt(int[] array, int index)
    {
        int arlen = array.Length;
        if (index > arlen || index < 0) {
            Console.WriteLine("Index out of range");
            return (-1);
            }
        for (int i = 0; i <= index; i++) {
            if (i == index) {
                break;
            }
        }
        return (array [index]);
    }
}
