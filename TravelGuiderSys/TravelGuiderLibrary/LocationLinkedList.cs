using System;
using System.Collections.Generic;

namespace TravelGuiderLibrary
{
    // Represents a linked list of location nodes
    public class LocationLinkedList
    {
        // Head node of the linked list, initially null
        public LocationNode? Head { get; private set; } = null;

        // Adds a new location to the linked list
        public void AddLocation(LocationModel location)
        {
            // Create a new node for the location
            LocationNode newNode = new LocationNode(location);

            // If the list is empty, the new node becomes the head
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                // Otherwise, find the last node and link it to the new node
                LocationNode current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Returns a list of all locations in the linked list
        public List<LocationModel> GetAllLocations()
        {
            List<LocationModel> locations = new List<LocationModel>();
            LocationNode? current = Head;
            // Traverse the linked list and add each location to the list
            while (current != null)
            {
                locations.Add(current.Location);
                current = current.Next;
            }
            return locations;
        }

        // Returns a list of locations sorted based on the given criteria (name and/or budget)
        public List<LocationModel> GetSortedLocations(bool sortByName, bool sortByBudget, string algorithm)
        {
            List<LocationModel> locations = GetAllLocations();

            if (sortByName)
            {
                switch (algorithm)
                {
                    case "BubbleSort":
                        locations = BubbleSortByName(locations);
                        break;
                    case "MergeSort":
                        locations = MergeSortByName(locations);
                        break;
                    case "QuickSort":
                        locations = QuickSortByName(locations);
                        break;
                }
            }
            if (sortByBudget)
            {
                switch (algorithm)
                {
                    case "BubbleSort":
                        locations = BubbleSortByBudget(locations);
                        break;
                    case "MergeSort":
                        locations = MergeSortByBudget(locations);
                        break;
                    case "QuickSort":
                        locations = QuickSortByBudget(locations);
                        break;
                }
            }

            return locations;
        }

        // Sorts the locations list by name using Bubble Sort
        private List<LocationModel> BubbleSortByName(List<LocationModel> locations)
        {
            int n = locations.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(locations[j].LocationName,
                        locations[j + 1].LocationName, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        var temp = locations[j];
                        locations[j] = locations[j + 1];
                        locations[j + 1] = temp;
                    }
                }
            }
            return locations;
        }

        // Sorts the locations list by budget using Bubble Sort
        private List<LocationModel> BubbleSortByBudget(List<LocationModel> locations)
        {
            int n = locations.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (locations[j].Budjet > locations[j + 1].Budjet)
                    {
                        var temp = locations[j];
                        locations[j] = locations[j + 1];
                        locations[j + 1] = temp;
                    }
                }
            }
            return locations;
        }

        // Sorts the locations list by name using Merge Sort
        private List<LocationModel> MergeSortByName(List<LocationModel> locations)
        {
            if (locations.Count <= 1)
                return locations;

            int mid = locations.Count / 2;
            List<LocationModel> left = locations.GetRange(0, mid);
            List<LocationModel> right = locations.GetRange(mid, locations.Count - mid);

            return MergeByName(MergeSortByName(left), MergeSortByName(right));
        }

        private List<LocationModel> MergeByName(List<LocationModel> left, List<LocationModel> right)
        {
            List<LocationModel> result = new List<LocationModel>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (string.Compare(left[i].LocationName, right[j].LocationName, 
                    StringComparison.OrdinalIgnoreCase) <= 0)
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            result.AddRange(left.GetRange(i, left.Count - i));
            result.AddRange(right.GetRange(j, right.Count - j));

            return result;
        }

        // Sorts the locations list by budget using Merge Sort
        private List<LocationModel> MergeSortByBudget(List<LocationModel> locations)
        {
            if (locations.Count <= 1)
                return locations;

            int mid = locations.Count / 2;
            List<LocationModel> left = locations.GetRange(0, mid);
            List<LocationModel> right = locations.GetRange(mid, locations.Count - mid);

            return MergeByBudget(MergeSortByBudget(left), MergeSortByBudget(right));
        }

        private List<LocationModel> MergeByBudget(List<LocationModel> left, List<LocationModel> right)
        {
            List<LocationModel> result = new List<LocationModel>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i].Budjet <= right[j].Budjet)
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            result.AddRange(left.GetRange(i, left.Count - i));
            result.AddRange(right.GetRange(j, right.Count - j));

            return result;
        }

        // Sorts the locations list by name using Quick Sort
        private List<LocationModel> QuickSortByName(List<LocationModel> locations)
        {
            if (locations.Count <= 1)
                return locations;

            List<LocationModel> less = new List<LocationModel>();
            List<LocationModel> equal = new List<LocationModel>();
            List<LocationModel> greater = new List<LocationModel>();

            LocationModel pivot = locations[locations.Count / 2];
            foreach (var location in locations)
            {
                int comparison = string.Compare(location.LocationName, pivot.LocationName, StringComparison.OrdinalIgnoreCase);
                if (comparison < 0)
                    less.Add(location);
                else if (comparison == 0)
                    equal.Add(location);
                else
                    greater.Add(location);
            }

            List<LocationModel> sorted = QuickSortByName(less);
            sorted.AddRange(equal);
            sorted.AddRange(QuickSortByName(greater));

            return sorted;
        }

        // Sorts the locations list by budget using Quick Sort
        private List<LocationModel> QuickSortByBudget(List<LocationModel> locations)
        {
            if (locations.Count <= 1)
                return locations;

            List<LocationModel> less = new List<LocationModel>();
            List<LocationModel> equal = new List<LocationModel>();
            List<LocationModel> greater = new List<LocationModel>();

            LocationModel pivot = locations[locations.Count / 2];
            foreach (var location in locations)
            {
                if (location.Budjet < pivot.Budjet)
                    less.Add(location);
                else if (location.Budjet == pivot.Budjet)
                    equal.Add(location);
                else
                    greater.Add(location);
            }

            List<LocationModel> sorted = QuickSortByBudget(less);
            sorted.AddRange(equal);
            sorted.AddRange(QuickSortByBudget(greater));

            return sorted;
        }

        // Returns a list of locations that match the specified district and budget range
        public List<LocationModel> GetLocationsByDistrictAndBudgetRange(string district, int minBudget, int maxBudget)
        {
            List<LocationModel> matchingLocations = new List<LocationModel>();
            LocationNode? current = Head;
            // Traverse the linked list and check if the location matches the criteria
            while (current != null)
            {
                // Check if the location matches both district and budget range
                if (string.Equals(current.Location.District, district, StringComparison.OrdinalIgnoreCase) &&
                    current.Location.Budjet >= minBudget && current.Location.Budjet <= maxBudget)
                {
                    matchingLocations.Add(current.Location);
                }
                current = current.Next;
            }
            return matchingLocations;
        }
    }
}
