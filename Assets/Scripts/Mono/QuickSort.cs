using UnityEngine;

public class QuickSort : MonoBehaviour
{
	public static void QuickSortAlgorithm(int[] arr, int low, int high)
	{
		if (low < high)
		{
			int pi = Partition(arr, low, high);

			QuickSortAlgorithm(arr, low, pi - 1);
			QuickSortAlgorithm(arr, pi + 1, high);
		}
	}

	public static int Partition(int[] arr, int low, int high)
	{
		int pivot = arr[high];
		int i = low - 1;

		for (int j = low; j < high; j++)
		{
			if (arr[j] < pivot)
			{
				i++;
				Swap(arr, i, j);
			}
		}

		Swap(arr, i + 1, high);
		return i + 1;
	}

	public static void Swap(int[] arr, int i, int j)
	{
		int temp = arr[i];
		arr[i] = arr[j];
		arr[j] = temp;
	}
}
