using System.Collections.Generic;
using UnityEngine;

namespace Flyweight
{
    public class PositionBuildingCity : MonoBehaviour
    {
        private List<City> _allCities = new();

        private List<Vector3> _apartmentBuildingPos;
        private List<Vector3> _salesBuildingPos;
        private List<Vector3> _industrialBuildingPos;

        private void Start()
        {
            _apartmentBuildingPos = GetBuildingPositions();
            _salesBuildingPos = GetBuildingPositions();
            _industrialBuildingPos = GetBuildingPositions();

            for (int i = 0; i < 10000; i++)
            {
                City newCity = new();

                //Whit flyweight
                newCity.apartmentBuildingPos = _apartmentBuildingPos;
                newCity.salesBuildingPos = _salesBuildingPos;
                newCity.industrialBuildingPos= _industrialBuildingPos;

                _allCities.Add(newCity);
            }

        }

        private List<Vector3> GetBuildingPositions()
        {
            List<Vector3> buildingPositions = new();

            for (int i = 0; i < 1000; i++)
            {
                buildingPositions.Add(new Vector3());
                Debug.Log("Create new Position Building");
            }

            return buildingPositions;
        }
    }
}