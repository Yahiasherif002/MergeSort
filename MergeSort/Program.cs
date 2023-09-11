internal class Program
{
    static void merge(int[] arr, int left,int middle ,int right)
    {
       
        int n1 = middle  - left + 1; // first subarray is arr[l..m]
        int n2 = right - middle;      // second subarray is arr[r..m]
        int[] leftArray=new int[n1],rightArray=new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = arr[left+i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = arr[middle+1+j];


       int iMerge=0 ,jMerge = 0;
       int k = left;
        
        while(iMerge< n1 && jMerge < n2)
        {
            if (leftArray[iMerge] <= rightArray[jMerge])
            {
                arr[k] = leftArray[iMerge];
                iMerge++;
            }
            else
            {
                arr[k] = rightArray[jMerge];
                jMerge++;
            }
            k++;
        }

        while (iMerge<n1)
        {
            arr[k] = leftArray[iMerge];
            iMerge++;
            k++;
        }
        while (jMerge < n2)
        {
            arr[k] = leftArray[jMerge];
            jMerge++;
            k++;
        }


    }

    static void mergeSort(int[] arr,int left,int right)
    {
        if (left < right)
        {
            int middle = left + (right - left) / 2;

            mergeSort(arr, left, middle);
            mergeSort(arr, middle + 1, right);

            merge(arr, left, middle, right);
        }
    }
    static void printArray(int[] arr)
    {
        int size = arr.Length;
        Console.Write('[');
        for (int i = 0; i < size; i++)
        {
            Console.Write($" {arr[i]} ");
            if(i<size-1)
                Console.Write(", ");
        }
        Console.Write(']');
    }
    private static void Main(string[] args)
    {
        int[] arrToBeSorted = { 80, 40, 50, 45, 30, 10, 23 };
        int size = arrToBeSorted.Length;
        Console.WriteLine( "Original array :");
        printArray(arrToBeSorted);
        mergeSort(arrToBeSorted,0, size-1);
        Console.WriteLine( "\nSorted Array : ");
        printArray(arrToBeSorted);
    }
}